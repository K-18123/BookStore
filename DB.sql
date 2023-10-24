use master
if exists (select * from sysdatabases where name = 'BOOKSTORE')
	drop database BOOKSTORE
go
create database BOOKSTORE
go
use BOOKSTORE
go

create table TACGIA (
	IDTG int identity(1,1) not null primary key,
	Ten nvarchar (max),
	DiaChi nvarchar (max),
	Mail nvarchar(max),
	GioiThieu nvarchar(max)
)

create table VAITRO (
	IDTG int ,
	IDSach int ,
	VaiTro nvarchar(max)
)

create table SACH (
	IDSach int identity(1,1) primary key,
	TenSach nvarchar (max),
	GiaBan float,
	SoLuongKho int,
	MoTa nvarchar(max),
	AnhMinhHoa nvarchar(max),
	NgayPhatHanh datetime,
	SLXem int,
	SLBan int,
	IDNXB int,
	IDTheLoai int,
	IDDanhGia int,
	)
