from typing import Optional

from config.config import db_connect
from sqlmodel import Field, SQLModel


class Config(SQLModel, table=True):
    id: Optional[int] = Field(default=None, primary_key=True)
    loaihoso: str
    thongtin: str
    duongdan: str


class Acount(SQLModel, table=True):
    id: Optional[int] = Field(default=None, primary_key=True)
    username: str
    password: str
    fullname: str
