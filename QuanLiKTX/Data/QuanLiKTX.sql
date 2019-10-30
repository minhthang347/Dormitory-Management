CREATE DATABASE QuanLiKTX
GO

USE QuanLiKTX
GO

CREATE TABLE Toa
(
	MaToa varchar(10) not null primary key,
	GioiTinh nvarchar(10) not null
)
GO

CREATE TABLE Phong
(
	MaPhong varchar(10) not null primary key,
	MaToa varchar(10) not null,
	LoaiPhong int not null,
	SoLuong int not null,
	Gia int not null, -- tinh theo nam
	CSDien int not null,
	CSNuoc int not null,

	foreign key (MaToa) references Toa(MaToa)
)
GO

CREATE TABLE SinhVien
(
	CMND varchar(10) primary key,
	HoTen nvarchar(100) not null,
	GioiTinh nvarchar(10) not null,
	MSSV varchar(20) not null,
	Truong nvarchar(100) not null,
	Que nvarchar(100) not null,
	NgaySinh date not null,
	MaPhong varchar(10) not null,
	BHYT nvarchar(100) not null,
	NoiTru nvarchar(100) not null,

	foreign key (MaPhong) references Phong(MaPhong)
)
GO

CREATE TABLE HoaDonPhong
(
	MaHD int identity primary key,
	MaPhong varchar(10) not null,
	NgayHD date not null,
	CSDienCu int not null,
	CSDienMoi int not null,
	CSNuocCu int not null,
	CSNuocMoi int not null,

	foreign key (MaPhong) references Phong(MaPhong)
)
GO

CREATE TABLE TaiKhoan
(
	TenDN varchar(100) primary key,
	MatKhau varchar(100) not null,
	ChucVu int not null, -- 1 : admin / 0 : nhan vien
)
GO

CREATE PROCEDURE UpdateSinhVien 
@CMND varchar(10),@HoTen nvarchar(100),@MSSV varchar(20),@Truong nvarchar(100),@Que nvarchar(100),@NgaySinh date
AS
UPDATE SinhVien
SET HoTen=@HoTen, MSSV=@MSSV, Truong=@Truong, Que = @Que, NgaySinh=@NgaySinh
WHERE CMND = @CMND
GO

CREATE PROCEDURE PaySinhVien
@CMND varchar(10), @BHYT nvarchar(100), @NoiTru nvarchar(100)
AS
UPDATE SinhVien
SET BHYT=@BHYT, NoiTru=@NoiTru
WHERE CMND = @CMND
GO

CREATE PROCEDURE ChooseRoom
@MaToa varchar(10)--, @LoaiPhong int, @SoLuong int
AS
select MaPhong as [Tên phòng], LoaiPhong as [Loại phòng], SoLuong as [SL đang ở], Gia[Giá phòng] from Phong where MaToa=@MaToa and LoaiPhong>SoLuong
GO
	
CREATE PROCEDURE ChangeSoLuong
@MaPhong varchar(10),@SoLuong int
AS
UPDATE Phong
SET SoLuong=@SoLuong
WHERE MaPhong=@MaPhong
GO

CREATE PROCEDURE AddSV
@CMND varchar(10),@HoTen nvarchar(100),@GioiTinh nvarchar(10),@MSSV varchar(20),
@Truong nvarchar(100),@Que nvarchar(100),@NgaySinh date,@MaPhong varchar(10),
@BHYT nvarchar(100), @NoiTru nvarchar(100)
AS
INSERT INTO SinhVien(CMND,HoTen,GioiTinh,MSSV,Truong,Que,NgaySinh,MaPhong,BHYT,NoiTru)
VALUES (@CMND,@HoTen,@GioiTinh,@MSSV,@Truong,@Que,@NgaySinh,@MaPhong,@BHYT,@NoiTru)
GO

CREATE PROCEDURE AddHD
@MaPhong varchar(10),@NgayHD date,@CSDienCu int,@CSDienMoi int,@CSNuocCu int,@CSNuocMoi int
AS
INSERT INTO HoaDonPhong(MaPhong,NgayHD,CSDienCu,CSDienMoi,CSNuocCu,CSNuocMoi)
VALUES (@MaPhong,@NgayHD,@CSDienCu,@CSDienMoi,@CSNuocCu,@CSNuocMoi)
GO

CREATE PROCEDURE AddTK
@TenDN varchar(100),@MatKhau varchar(100),@ChucVu int
AS
INSERT INTO TaiKhoan(TenDN,MatKhau,ChucVu)
VALUES (@TenDN,@MatKhau,@ChucVu)
GO

CREATE PROCEDURE Login
@TenDN varchar(100),@MatKhau varchar(100)
AS
SELECT * FROM TaiKhoan WHERE TenDN=@TenDN and MatKhau=@MatKhau
GO

-- Tài khoản
INSERT INTO TaiKhoan(TenDN,MatKhau,ChucVu) VALUES (N'admin',N'1',1)
INSERT INTO TaiKhoan(TenDN,MatKhau,ChucVu) VALUES (N'mt',N'123',0)

-- Toà nhà
INSERT INTO Toa(MaToa,GioiTinh) VALUES ('B1',N'Nam')
INSERT INTO Toa(MaToa,GioiTinh) VALUES ('B2',N'Nữ')

-- Phòng 
INSERT INTO Phong(MaPhong,MaToa,LoaiPhong,SoLuong,Gia,CSDien,CSNuoc)
VALUES ('B1P0101','B1',6,4,400000,150,65)
INSERT INTO Phong(MaPhong,MaToa,LoaiPhong,SoLuong,Gia,CSDien,CSNuoc)
VALUES ('B1P0103','B1',6,6,400000,200,100)
INSERT INTO Phong(MaPhong,MaToa,LoaiPhong,SoLuong,Gia,CSDien,CSNuoc)
VALUES ('B1P0102','B1',6,3,400000,155,95)
INSERT INTO Phong(MaPhong,MaToa,LoaiPhong,SoLuong,Gia,CSDien,CSNuoc)
VALUES ('B2P0202','B2',8,5,300000,190,55)

-- Sinh viên
INSERT INTO SinhVien(CMND,HoTen,GioiTinh,MSSV,Truong,Que,NgaySinh,MaPhong,BHYT,NoiTru) 
VALUES ('2251135678',N'Nguyễn Văn A',N'Nam','15520123',N'CNTT',N'TPHCM','1997-01-21','B1P0101',N'Chưa đóng',N'Chưa đóng')
INSERT INTO SinhVien(CMND,HoTen,GioiTinh,MSSV,Truong,Que,NgaySinh,MaPhong,BHYT,NoiTru) 
VALUES ('2251130000',N'Trần Văn C',N'Nam','15520001',N'CNTT',N'Đồng Nai','1998-03-23','B1P0102',N'Đã đóng',N'Chưa đóng')
INSERT INTO SinhVien(CMND,HoTen,GioiTinh,MSSV,Truong,Que,NgaySinh,MaPhong,BHYT,NoiTru) 
VALUES ('2251138765',N'Nguyễn Thị B',N'Nữ','15520321',N'KHXHNV',N'HN','1997-12-30','B2P0202',N'Đã đóng',N'Đã đóng')

-- Hoá đơn
INSERT INTO HoaDonPhong(MaPhong,NgayHD,CSDienCu,CSDienMoi,CSNuocCu,CSNuocMoi)
VALUES ('B1P0101','2018-11-01',100,150,50,65)
INSERT INTO HoaDonPhong(MaPhong,NgayHD,CSDienCu,CSDienMoi,CSNuocCu,CSNuocMoi)
VALUES ('B1P0102','2018-11-02',115,155,80,95)
INSERT INTO HoaDonPhong(MaPhong,NgayHD,CSDienCu,CSDienMoi,CSNuocCu,CSNuocMoi)
VALUES ('B2P0202','2018-11-10',110,190,40,55)
