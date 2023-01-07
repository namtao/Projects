
import configparser
import logging
import os
import re
import urllib.parse
from collections import Counter, OrderedDict

import numpy as np
import pandas as pd


def merge_dict(dict1, dict2):
    # tối ưu hóa hiệu suất dataframe
    for i in dict2.keys():
        if (i in dict1):
            dict1[i] = dict1[i] + dict2[i]
        else:
            dict1[i] = dict2[i]
    return dict1


def removeEscape(value):
    return ' '.join(str(value).splitlines()).strip()


def read_excel():
    # C:\Users\Nam\Downloads\ADDJ\Hậu Giang\EXCEL ĐÃ BIÊN MỤC\Vị Thủy\KS\Vị Thắng\vị thắng-KS.2006.01.xlsx
    count = 0
    for root, dirs, files in os.walk(r'C:\Users\Nam\Downloads\ADDJ\Hậu Giang\EXCEL ĐÃ BIÊN MỤC\Vị Thanh'):
        for file in files:
            pattern = re.compile(".*"+'xls')

            if pattern.match(file):
                df = pd.read_excel(os.path.join(root, file))
                for col in df.columns:
                    series = df[col].dropna()
                    count += int(series.shape[0]) - 1
                    print(('\rTổng số bản ghi: {:<20,}'.format(count)), end='')
                    break


def tktruong(conn, sql):
    # đếm số trường
    df = pd.read_sql_query(sql, conn)
    df.replace(r'^\s*$', np.nan, regex=True, inplace=True)
    # df.replace(np.nan, ' ', regex=True, inplace=True)
    return np.sum(df.count())  # đếm số ô có thông tin (loại bỏ nan)


def tksoluong(conn, sql):
    df = pd.read_sql_query(sql, conn)
    return int(removeEscape(df.to_string(index=False)))


def thongkehotich():
    fileName = r'D:\Data\Dak Nong\Thống kê hộ tịch.xlsx'
    config = configparser.ConfigParser()
    config.read(r'config.ini')

    conndaknong = f'mssql+pyodbc://{config["daknong"]["user"]}:{urllib.parse.quote_plus(config["daknong"]["pass"])}@{config["daknong"]["host"]}/{config["daknong"]["db"]}?driver={config["daknong"]["driver"]}'

    connhcm = f'mssql+pyodbc://{config["hcm"]["user"]}:{urllib.parse.quote_plus(config["hcm"]["pass"])}@{config["hcm"]["host"]}/{config["hcm"]["db"]}?driver={config["hcm"]["driver"]}'

    connhn = f'mssql+pyodbc://{config["hn"]["user"]}:{urllib.parse.quote_plus(config["hn"]["pass"])}@{config["hn"]["host"]}/{config["hn"]["db"]}?driver={config["hn"]["driver"]}'

    print("Thống kê hộ tịch")

    dicLoai = {'ks': 'HT_KHAISINH', 'kt': 'HT_KHAITU', 'kh': 'HT_KETHON',
               'cmc': 'HT_NHANCHAMECON', 'hn': 'HT_XACNHANHONNHAN'}

    dic = {33333: ['Sở Tư Pháp', conndaknong],
           44444: ['PTP TP Gia Nghĩa', conndaknong],
           55555: ['TP DAK SONG', connhn],
           66666: ['DAK R\'LAP', connhcm],
           77777: ['UBND HUYỆN ĐẮK MIL', connhn]}

    d = {'Nơi đăng ký': [], 'Loại sổ': [], 'Tổng số trường hợp': [],
         'Số lượng biên mục': [], 'Tỷ lệ biên mục': [], 'Tổng số trường biên mục': []}

    for k, v in dic.items():
        print(v[0])
        d['Nơi đăng ký'].extend([v[0], '', '', '', ''])

        for k1, v1 in dicLoai.items():
            print('\t' + v1)

            ndk = 'noiCap' if (v1 == 'HT_XACNHANHONNHAN') else 'noiDangKy'

            tongsoluong = tksoluong(v[1], 'select count(*) from ' + v1 + ' ks join HT_NOIDANGKY ndk on ks.' +
                                    ndk + ' = ndk.MaNoiDangKy where MaCapCha = ' + str(k))

            soluongbienmuc = tksoluong(
                v[1],
                'select count(*) from ' + v1 + ' ks join HT_NOIDANGKY ndk on ks.' + ndk +
                ' = ndk.MaNoiDangKy where MaCapCha = ' + str(k) + 'and TinhTrangID in (5, 6, 7)')

            tongtruong = tktruong(
                v[1], 'SELECT * from tk_' + k1 + '(' + str(k) + ')')

            # print("\t{:<20}: {:10,}{:10,}{:15,}".format(
            #     v1, tongsoluong, soluongbienmuc, tongtruong))
            # print()

            # d['Nơi đăng ký'].append(v[0])
            d['Loại sổ'].append(v1)
            d['Tổng số trường hợp'].append(tongsoluong)
            d['Số lượng biên mục'].append(soluongbienmuc)
            try:
                d['Tỷ lệ biên mục'].append((soluongbienmuc/tongsoluong))
            except ZeroDivisionError:
                d['Tỷ lệ biên mục'].append(1)

            d['Tổng số trường biên mục'].append(tongtruong)

        print('------------------------------')

    sl = sum(d['Tổng số trường hợp'])
    bm = sum(d['Số lượng biên mục'])

    d['Nơi đăng ký'].append('Tổng')
    d['Loại sổ'].append('Hộ tịch')
    d['Tổng số trường hợp'].append(sl)
    d['Số lượng biên mục'].append(bm)
    d['Tỷ lệ biên mục'].append(bm/sl)
    d['Tổng số trường biên mục'].append(sum(d['Tổng số trường biên mục']))

    writer = pd.ExcelWriter(fileName, engine='xlsxwriter')
    df_new = pd.DataFrame(d).to_excel(
        writer, sheet_name='Thống kê hộ tịch', index=False)

    workbook = writer.book
    worksheet = writer.sheets['Thống kê hộ tịch']

    format_number = workbook.add_format({'num_format': '#,##0'})

    format_percentage = workbook.add_format({'num_format': '00.00%'})

    # Set the column width and format.

    format_data = workbook.add_format()
    format_data.set_valign('vcenter')
    # format_data.set_align('center')
    format_data.set_text_wrap()

    worksheet.set_column('A:Z', 25, format_data)
    worksheet.set_column(2, 2, 20, format_number)
    worksheet.set_column(3, 3, 20, format_number)
    worksheet.set_column(4, 4, 20, format_percentage)
    worksheet.set_column(5, 5, 20, format_number)

    # thêm định dạng của 1 ô hoặc dải ô
    worksheet.conditional_format('A27:D27', {'type': 'no_errors',
                                             'format': workbook.add_format(
                                                 {'bold': True, 'font_color': 'red', 'num_format': '#,##0'})})

    worksheet.conditional_format('E27', {'type': 'no_errors',
                                         'format': workbook.add_format(
                                                 {'bold': True, 'font_color': 'red', 'num_format': '00.00%'})})

    worksheet.conditional_format('F27', {'type': 'no_errors',
                                         'format': workbook.add_format(
                                                 {'bold': True, 'font_color': 'red', 'num_format': '#,##0'})})

    writer.save()
    writer.close()

    os.system('\"'+fileName+'\"')


def thongkehotich2():
    fileName = r'D:\Data\Dak Nong\1. Thống kê hộ tịch.xlsx'
    config = configparser.ConfigParser()
    config.read(r'config.ini')

    conndaknong = f'mssql+pyodbc://{config["daknong"]["user"]}:{urllib.parse.quote_plus(config["daknong"]["pass"])}@{config["daknong"]["host"]}/{config["daknong"]["db"]}?driver={config["daknong"]["driver"]}'

    connhcm = f'mssql+pyodbc://{config["hcm"]["user"]}:{urllib.parse.quote_plus(config["hcm"]["pass"])}@{config["hcm"]["host"]}/{config["hcm"]["db"]}?driver={config["hcm"]["driver"]}'

    connhn = f'mssql+pyodbc://{config["hn"]["user"]}:{urllib.parse.quote_plus(config["hn"]["pass"])}@{config["hn"]["host"]}/{config["hn"]["db"]}?driver={config["hn"]["driver"]}'

    print("Thống kê hộ tịch")

    dicLoai = {'ks': 'HT_KHAISINH', 'kt': 'HT_KHAITU', 'kh': 'HT_KETHON',
               'cmc': 'HT_NHANCHAMECON', 'hn': 'HT_XACNHANHONNHAN'}

    dic = {33333: ['Sở Tư Pháp', conndaknong],
           44444: ['PTP TP Gia Nghĩa', conndaknong],
           55555: ['TP DAK SONG', connhn],
           66666: ['DAK R\'LAP', connhcm],
           77777: ['UBND HUYỆN ĐẮK MIL', connhn]}

    d = {
        'Nơi đăng ký': [],
        'Loại sổ': [],
        'Số trường hợp (2007 - nay)': [],
        'Số trường hợp (1999 - 2006)': [],
        'Tổng số trường hợp': [],
        'Tổng số trường biên mục': []
    }

    for k, v in dic.items():
        print(v[0])
        d['Nơi đăng ký'].extend([v[0], '', '', '', ''])

        for k1, v1 in dicLoai.items():
            print('\t' + v1)

            ndk = 'noiCap' if (v1 == 'HT_XACNHANHONNHAN') else 'noiDangKy'

            tongsoluong = tksoluong(v[1], 'select count(*) from ' + v1 + ' ks join HT_NOIDANGKY ndk on ks.' +
                                    ndk + ' = ndk.MaNoiDangKy where MaCapCha = ' + str(k))

            soluongbienmuc = tksoluong(
                v[1],
                'select count(*) from ' + v1 + ' ks join HT_NOIDANGKY ndk on ks.' + ndk +
                ' = ndk.MaNoiDangKy where MaCapCha = ' + str(k) + 'and TinhTrangID in (5, 6, 7)')

            tongtruong = tktruong(
                v[1], 'SELECT * from tk_' + k1 + '(' + str(k) + ')')

            # print("\t{:<20}: {:10,}{:10,}{:15,}".format(
            #     v1, tongsoluong, soluongbienmuc, tongtruong))
            # print()

            # d['Nơi đăng ký'].append(v[0])
            d['Loại sổ'].append(v1)
            # d['Tổng số trường hợp'].append(tongsoluong)

            # d['Tổng số trường biên mục'].append(tongtruong)

        print('------------------------------')

    sl = sum(d['Tổng số trường hợp'])

    d['Nơi đăng ký'].append('Tổng')
    d['Loại sổ'].append('Hộ tịch')
    d['Số trường hợp (1999 - 2006)'].extend([53, 0, 146, 16, 0, 6394, 0, 2116, 0, 0, 5712, 534,
                                             0, 7, 552, 16550, 563, 4178, 45, 2331, 24258, 1364, 5489, 120, 1973, 72401])
    d['Số trường hợp (2007 - nay)'].extend([0, 1, 90, 0, 0, 16931, 1461, 5550, 48, 8465, 19003, 1801,
                                              6912, 9, 4934, 23639, 2798, 8286, 22, 7807, 37755, 4224, 11251, 67, 8174, 169228])
    d['Tổng số trường hợp'].extend([53, 1, 236, 16, 0, 23325, 1461, 7666, 48, 8465, 24715, 2335,
                              6912, 16, 5486, 40189, 3361, 12464, 67, 10138, 62013, 5588, 16740, 187, 10147, 241629])
    d['Tổng số trường biên mục'].extend(
        [1925, 825660, 1062630, 2555360, 1234455, 28, 56304, 69552, 146898, 92905, 6332, 231785, 242177, 505856, 384738,
         455, 1328, 435, 5237, 1900, 0, 232528, 133284, 235287, 266098, 8293157])

    writer = pd.ExcelWriter(fileName, engine='xlsxwriter')
    df_new = pd.DataFrame(d).to_excel(
        writer, sheet_name='Thống kê hộ tịch', index=False)

    workbook = writer.book
    worksheet = writer.sheets['Thống kê hộ tịch']

    format_number = workbook.add_format({'num_format': '#,##0'})

    format_percentage = workbook.add_format({'num_format': '00.00%'})

    # Set the column width and format.

    format_data = workbook.add_format()
    format_data.set_valign('vcenter')
    # format_data.set_align('center')
    format_data.set_text_wrap()

    worksheet.set_column('A:Z', 25, format_data)
    worksheet.set_column(2, 2, 25, format_number)
    worksheet.set_column(3, 3, 25, format_number)
    worksheet.set_column(4, 4, 25, format_number)
    worksheet.set_column(5, 5, 25, format_number)

    # thêm định dạng của 1 ô hoặc dải ô
    worksheet.conditional_format('A27:D27', {'type': 'no_errors',
                                             'format': workbook.add_format(
                                                 {'bold': True, 'font_color': 'red', 'num_format': '#,##0'})})

    worksheet.conditional_format('E27', {'type': 'no_errors',
                                         'format': workbook.add_format(
                                                 {'bold': True, 'font_color': 'red', 'num_format': '#,##0'})})

    worksheet.conditional_format('F27', {'type': 'no_errors',
                                         'format': workbook.add_format(
                                                 {'bold': True, 'font_color': 'red', 'num_format': '#,##0'})})

    writer.save()
    writer.close()

    os.system('\"'+fileName+'\"')


thongkehotich()
