﻿
namespace DB
{
    partial class QuaTrinhXuLy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuaTrinhXuLy));
            this.cbxNDK = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxQuyenSo = new System.Windows.Forms.ComboBox();
            this.cbxLoai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSum = new System.Windows.Forms.Label();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.lbSumData = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soSánhChiTiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tổngHợpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinPhiênBảnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxNhiemVu = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxNDK
            // 
            this.cbxNDK.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNDK.FormattingEnabled = true;
            this.cbxNDK.Location = new System.Drawing.Point(641, 51);
            this.cbxNDK.Margin = new System.Windows.Forms.Padding(10, 10, 15, 15);
            this.cbxNDK.Name = "cbxNDK";
            this.cbxNDK.Size = new System.Drawing.Size(334, 27);
            this.cbxNDK.TabIndex = 2;
            this.cbxNDK.DropDown += new System.EventHandler(this.cbxNDK_DropDown);
            this.cbxNDK.TextChanged += new System.EventHandler(this.cbxNDK_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(548, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 1000000034;
            this.label3.Text = "Nơi đăng ký";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(305, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 1000000033;
            this.label4.Text = "Quyển số";
            // 
            // cbxQuyenSo
            // 
            this.cbxQuyenSo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxQuyenSo.FormattingEnabled = true;
            this.cbxQuyenSo.Location = new System.Drawing.Point(388, 50);
            this.cbxQuyenSo.Margin = new System.Windows.Forms.Padding(10, 10, 15, 15);
            this.cbxQuyenSo.Name = "cbxQuyenSo";
            this.cbxQuyenSo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxQuyenSo.Size = new System.Drawing.Size(145, 27);
            this.cbxQuyenSo.TabIndex = 1;
            this.cbxQuyenSo.DropDown += new System.EventHandler(this.cbxQuyenSo_DropDown);
            this.cbxQuyenSo.TextChanged += new System.EventHandler(this.cbxQuyenSo_TextChanged);
            // 
            // cbxLoai
            // 
            this.cbxLoai.BackColor = System.Drawing.Color.White;
            this.cbxLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLoai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLoai.FormattingEnabled = true;
            this.cbxLoai.Items.AddRange(new object[] {
            "HT_KHAISINH",
            "HT_KHAITU",
            "HT_KETHON",
            "HT_NHANCHAMECON"});
            this.cbxLoai.Location = new System.Drawing.Point(97, 51);
            this.cbxLoai.Margin = new System.Windows.Forms.Padding(10, 10, 15, 15);
            this.cbxLoai.Name = "cbxLoai";
            this.cbxLoai.Size = new System.Drawing.Size(194, 27);
            this.cbxLoai.TabIndex = 3;
            this.cbxLoai.TextChanged += new System.EventHandler(this.cbxLoai_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 1000000037;
            this.label2.Text = "Loại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 19);
            this.label5.TabIndex = 1000000037;
            this.label5.Text = "Tổng số trường hợp: ";
            // 
            // lbSum
            // 
            this.lbSum.AutoSize = true;
            this.lbSum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSum.Location = new System.Drawing.Point(168, 164);
            this.lbSum.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.lbSum.Name = "lbSum";
            this.lbSum.Size = new System.Drawing.Size(17, 19);
            this.lbSum.TabIndex = 1000000037;
            this.lbSum.Text = "0";
            // 
            // datagrid
            // 
            this.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagrid.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(19, 200);
            this.datagrid.Margin = new System.Windows.Forms.Padding(20);
            this.datagrid.Name = "datagrid";
            this.datagrid.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid.Size = new System.Drawing.Size(956, 315);
            this.datagrid.TabIndex = 1000000038;
            this.datagrid.TabStop = false;
            this.datagrid.Visible = false;
            // 
            // lbSumData
            // 
            this.lbSumData.AutoSize = true;
            this.lbSumData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSumData.Location = new System.Drawing.Point(790, 164);
            this.lbSumData.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.lbSumData.Name = "lbSumData";
            this.lbSumData.Size = new System.Drawing.Size(17, 19);
            this.lbSumData.TabIndex = 1000000039;
            this.lbSumData.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(638, 163);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 19);
            this.label6.TabIndex = 1000000041;
            this.label6.Text = "Số trường hợp khác:";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(991, 27);
            this.menuStrip.TabIndex = 1000000044;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.toolStripSeparator1});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.saveToolStripMenuItem.Text = "Lưu vào Excel";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soSánhChiTiếtToolStripMenuItem,
            this.toolStripSeparator2,
            this.tổngHợpToolStripMenuItem});
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 23);
            this.aboutToolStripMenuItem.Text = "Tools";
            // 
            // soSánhChiTiếtToolStripMenuItem
            // 
            this.soSánhChiTiếtToolStripMenuItem.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soSánhChiTiếtToolStripMenuItem.Name = "soSánhChiTiếtToolStripMenuItem";
            this.soSánhChiTiếtToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.soSánhChiTiếtToolStripMenuItem.Text = "So sánh chi tiết";
            this.soSánhChiTiếtToolStripMenuItem.Click += new System.EventHandler(this.soSánhChiTiếtToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(185, 6);
            // 
            // tổngHợpToolStripMenuItem
            // 
            this.tổngHợpToolStripMenuItem.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tổngHợpToolStripMenuItem.Name = "tổngHợpToolStripMenuItem";
            this.tổngHợpToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.tổngHợpToolStripMenuItem.Text = "So sánh tổng hợp";
            this.tổngHợpToolStripMenuItem.Click += new System.EventHandler(this.tổngHợpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinPhiênBảnToolStripMenuItem1});
            this.aboutToolStripMenuItem1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(59, 23);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // thôngTinPhiênBảnToolStripMenuItem1
            // 
            this.thôngTinPhiênBảnToolStripMenuItem1.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thôngTinPhiênBảnToolStripMenuItem1.Name = "thôngTinPhiênBảnToolStripMenuItem1";
            this.thôngTinPhiênBảnToolStripMenuItem1.Size = new System.Drawing.Size(207, 24);
            this.thôngTinPhiênBảnToolStripMenuItem1.Text = "Thông tin phiên bản";
            this.thôngTinPhiênBảnToolStripMenuItem1.Click += new System.EventHandler(this.thôngTinPhiênBảnToolStripMenuItem1_Click);
            // 
            // dtTo
            // 
            this.dtTo.CalendarFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(641, 101);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(140, 27);
            this.dtTo.TabIndex = 5;
            // 
            // dtFrom
            // 
            this.dtFrom.CalendarFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(388, 102);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(145, 27);
            this.dtFrom.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 1000000049;
            this.label1.Text = "Tình trạng";
            // 
            // cbxNhiemVu
            // 
            this.cbxNhiemVu.BackColor = System.Drawing.Color.White;
            this.cbxNhiemVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNhiemVu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNhiemVu.FormattingEnabled = true;
            this.cbxNhiemVu.Items.AddRange(new object[] {
            "",
            "KIỂM TRA LẦN 1",
            "KIỂM TRA LẦN 2"});
            this.cbxNhiemVu.Location = new System.Drawing.Point(97, 104);
            this.cbxNhiemVu.Margin = new System.Windows.Forms.Padding(10, 10, 15, 15);
            this.cbxNhiemVu.Name = "cbxNhiemVu";
            this.cbxNhiemVu.Size = new System.Drawing.Size(194, 27);
            this.cbxNhiemVu.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(304, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 19);
            this.label7.TabIndex = 1000000050;
            this.label7.Text = "Thời gian";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(577, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 19);
            this.label8.TabIndex = 1000000051;
            this.label8.Text = "=>";
            // 
            // QuaTrinhXuLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(991, 537);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxNhiemVu);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbSumData);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.lbSum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxLoai);
            this.Controls.Add(this.cbxQuyenSo);
            this.Controls.Add(this.cbxNDK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "QuaTrinhXuLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quá trình xử lý";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuaTrinhXuLy_FormClosing);
            this.Load += new System.EventHandler(this.QuaTrinhXuLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxNDK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxQuyenSo;
        private System.Windows.Forms.ComboBox cbxLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbSum;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.Label lbSumData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxNhiemVu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinPhiênBảnToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem soSánhChiTiếtToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tổngHợpToolStripMenuItem;
    }
}