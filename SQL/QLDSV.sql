USE [master]
GO
/****** Object:  Database [QLDSV]    Script Date: 8/16/2023 12:38:42 AM ******/
CREATE DATABASE [QLDSV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLDSV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QLDSV.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLDSV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QLDSV_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLDSV] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLDSV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLDSV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLDSV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLDSV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLDSV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLDSV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLDSV] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLDSV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLDSV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLDSV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLDSV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLDSV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLDSV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLDSV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLDSV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLDSV] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLDSV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLDSV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLDSV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLDSV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLDSV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLDSV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLDSV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLDSV] SET RECOVERY FULL 
GO
ALTER DATABASE [QLDSV] SET  MULTI_USER 
GO
ALTER DATABASE [QLDSV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLDSV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLDSV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLDSV] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLDSV] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLDSV] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QLDSV] SET QUERY_STORE = OFF
GO
USE [QLDSV]
GO
/****** Object:  User [gv9]    Script Date: 8/16/2023 12:38:42 AM ******/
CREATE USER [gv9] FOR LOGIN [GV9] WITH DEFAULT_SCHEMA=[gv9]
GO
/****** Object:  User [gv8]    Script Date: 8/16/2023 12:38:42 AM ******/
CREATE USER [gv8] FOR LOGIN [GV8] WITH DEFAULT_SCHEMA=[gv8]
GO
/****** Object:  User [gv7]    Script Date: 8/16/2023 12:38:42 AM ******/
CREATE USER [gv7] FOR LOGIN [GV7] WITH DEFAULT_SCHEMA=[gv7]
GO
/****** Object:  User [gv6]    Script Date: 8/16/2023 12:38:42 AM ******/
CREATE USER [gv6] FOR LOGIN [GV6] WITH DEFAULT_SCHEMA=[gv6]
GO
/****** Object:  User [gv5]    Script Date: 8/16/2023 12:38:42 AM ******/
CREATE USER [gv5] FOR LOGIN [GV5] WITH DEFAULT_SCHEMA=[gv5]
GO
/****** Object:  User [gv4]    Script Date: 8/16/2023 12:38:42 AM ******/
CREATE USER [gv4] FOR LOGIN [GV4] WITH DEFAULT_SCHEMA=[gv4]
GO
/****** Object:  User [gv3]    Script Date: 8/16/2023 12:38:42 AM ******/
CREATE USER [gv3] FOR LOGIN [GV3] WITH DEFAULT_SCHEMA=[gv3]
GO
/****** Object:  User [gv2]    Script Date: 8/16/2023 12:38:42 AM ******/
CREATE USER [gv2] FOR LOGIN [GV2] WITH DEFAULT_SCHEMA=[gv2]
GO
/****** Object:  User [gv10]    Script Date: 8/16/2023 12:38:42 AM ******/
CREATE USER [gv10] FOR LOGIN [GV10] WITH DEFAULT_SCHEMA=[gv10]
GO
/****** Object:  User [gv1]    Script Date: 8/16/2023 12:38:42 AM ******/
CREATE USER [gv1] FOR LOGIN [GV1] WITH DEFAULT_SCHEMA=[gv1]
GO
/****** Object:  User [ad]    Script Date: 8/16/2023 12:38:42 AM ******/
CREATE USER [ad] FOR LOGIN [ADM] WITH DEFAULT_SCHEMA=[ad]
GO
/****** Object:  DatabaseRole [GIANGVIEN]    Script Date: 8/16/2023 12:38:42 AM ******/
CREATE ROLE [GIANGVIEN]
GO
/****** Object:  DatabaseRole [ADMIN]    Script Date: 8/16/2023 12:38:42 AM ******/
CREATE ROLE [ADMIN]
GO
ALTER ROLE [GIANGVIEN] ADD MEMBER [gv9]
GO
ALTER ROLE [GIANGVIEN] ADD MEMBER [gv8]
GO
ALTER ROLE [GIANGVIEN] ADD MEMBER [gv7]
GO
ALTER ROLE [GIANGVIEN] ADD MEMBER [gv6]
GO
ALTER ROLE [GIANGVIEN] ADD MEMBER [gv5]
GO
ALTER ROLE [GIANGVIEN] ADD MEMBER [gv4]
GO
ALTER ROLE [GIANGVIEN] ADD MEMBER [gv3]
GO
ALTER ROLE [GIANGVIEN] ADD MEMBER [gv2]
GO
ALTER ROLE [GIANGVIEN] ADD MEMBER [gv10]
GO
ALTER ROLE [GIANGVIEN] ADD MEMBER [gv1]
GO
ALTER ROLE [ADMIN] ADD MEMBER [ad]
GO
/****** Object:  Schema [ad]    Script Date: 8/16/2023 12:38:43 AM ******/
CREATE SCHEMA [ad]
GO
/****** Object:  Schema [ADMIN]    Script Date: 8/16/2023 12:38:43 AM ******/
CREATE SCHEMA [ADMIN]
GO
/****** Object:  Schema [GIANGVIEN]    Script Date: 8/16/2023 12:38:43 AM ******/
CREATE SCHEMA [GIANGVIEN]
GO
/****** Object:  Schema [gv1]    Script Date: 8/16/2023 12:38:43 AM ******/
CREATE SCHEMA [gv1]
GO
/****** Object:  Schema [gv10]    Script Date: 8/16/2023 12:38:43 AM ******/
CREATE SCHEMA [gv10]
GO
/****** Object:  Schema [gv2]    Script Date: 8/16/2023 12:38:43 AM ******/
CREATE SCHEMA [gv2]
GO
/****** Object:  Schema [gv3]    Script Date: 8/16/2023 12:38:43 AM ******/
CREATE SCHEMA [gv3]
GO
/****** Object:  Schema [gv4]    Script Date: 8/16/2023 12:38:43 AM ******/
CREATE SCHEMA [gv4]
GO
/****** Object:  Schema [gv5]    Script Date: 8/16/2023 12:38:43 AM ******/
CREATE SCHEMA [gv5]
GO
/****** Object:  Schema [gv6]    Script Date: 8/16/2023 12:38:43 AM ******/
CREATE SCHEMA [gv6]
GO
/****** Object:  Schema [gv7]    Script Date: 8/16/2023 12:38:43 AM ******/
CREATE SCHEMA [gv7]
GO
/****** Object:  Schema [gv8]    Script Date: 8/16/2023 12:38:43 AM ******/
CREATE SCHEMA [gv8]
GO
/****** Object:  Schema [gv9]    Script Date: 8/16/2023 12:38:43 AM ******/
CREATE SCHEMA [gv9]
GO
/****** Object:  UserDefinedFunction [dbo].[InThongTinSinhVien]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[InThongTinSinhVien] (@Diem float)
RETURNS nvarchar(500)
AS
BEGIN
   DECLARE @ThongTin nvarchar(500)
   SELECT @ThongTin = 'Mã sinh viên: ' + MASV + ', Họ và tên: ' + HoTen + ', Ngày sinh: ' + CONVERT(nvarchar(10), NgaySinh, 103)
   FROM SINHVIEN
   WHERE MASV IN (SELECT MASV FROM KETQUA WHERE DIEMTONGKET = @Diem)
   RETURN @ThongTin
END
GO
/****** Object:  UserDefinedFunction [dbo].[LAYTENMONHOC]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[LAYTENMONHOC]
    (@MAMONHOC char(6))
RETURNS nvarchar(50)
AS
BEGIN
    DECLARE @TENMONHOC nvarchar(50)
    SELECT @TENMONHOC = TENMONHOC
    FROM MONHOC
    WHERE MAMONHOC = @MAMONHOC
    RETURN @TENMONHOC
END
GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SINHVIEN](
	[MASV] [char](6) NOT NULL,
	[HOTEN] [nvarchar](50) NULL,
	[NGAYSINH] [date] NULL,
	[GIOITINH] [nvarchar](5) NULL,
	[DIACHI] [nvarchar](50) NULL,
	[TINHTRANG] [nvarchar](30) NULL,
	[MALOP] [char](6) NULL,
 CONSTRAINT [pk_SV] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[DSSINHVIEN]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[DSSINHVIEN] (@masv char(6))
RETURNS TABLE
AS	
	RETURN
	(SELECT * FROM SINHVIEN
	 WHERE MASV = @masv)
GO
/****** Object:  Table [dbo].[DANGNHAP]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANGNHAP](
	[TAIKHOAN] [nvarchar](50) NOT NULL,
	[MATKHAU] [nvarchar](30) NULL,
	[QUYEN] [char](10) NULL,
 CONSTRAINT [pk_DN] PRIMARY KEY CLUSTERED 
(
	[TAIKHOAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GIANGVIEN]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIANGVIEN](
	[MAGV] [char](6) NOT NULL,
	[HOTEN] [nvarchar](50) NULL,
	[GIOITINH] [nvarchar](5) NULL,
	[SODIENTHOAI] [nvarchar](15) NULL,
	[EMAIL] [nvarchar](50) NULL,
	[PHANLOAI] [nvarchar](50) NULL,
	[TAIKHOAN_GV] [nvarchar](50) NULL,
 CONSTRAINT [pk_GV] PRIMARY KEY CLUSTERED 
(
	[MAGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GIANGVIEN_DAY_MONHOC]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIANGVIEN_DAY_MONHOC](
	[MAGV] [char](6) NOT NULL,
	[MAMONHOC] [char](6) NOT NULL,
 CONSTRAINT [pk_GVDMH] PRIMARY KEY CLUSTERED 
(
	[MAGV] ASC,
	[MAMONHOC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KETQUA]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KETQUA](
	[MASV] [char](6) NOT NULL,
	[MAMONHOC] [char](6) NOT NULL,
	[DIEMQUATRINH] [float] NULL,
	[DIEMCUOIKY] [float] NULL,
	[DIEMTONGKET] [float] NULL,
	[HOCKY] [int] NULL,
	[XEPLOAI] [nvarchar](20) NULL,
	[GHICHU] [nvarchar](150) NULL,
 CONSTRAINT [pk_KQ] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC,
	[MAMONHOC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOPHOC]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOPHOC](
	[MALOP] [char](6) NOT NULL,
	[TENLOP] [nvarchar](50) NULL,
	[GVQUANLY] [char](6) NULL,
 CONSTRAINT [pk_LH] PRIMARY KEY CLUSTERED 
(
	[MALOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MONHOC]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MONHOC](
	[MAMONHOC] [char](6) NOT NULL,
	[TENMONHOC] [nvarchar](50) NULL,
	[SOTINCHI] [int] NULL,
	[HOCKY] [int] NULL,
 CONSTRAINT [pk_MH] PRIMARY KEY CLUSTERED 
(
	[MAMONHOC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHANQUYEN]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHANQUYEN](
	[MAQUYEN] [char](10) NOT NULL,
	[TENQUYEN] [nvarchar](20) NULL,
 CONSTRAINT [pk_PHANQUYEN] PRIMARY KEY CLUSTERED 
(
	[MAQUYEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DANGNHAP] ([TAIKHOAN], [MATKHAU], [QUYEN]) VALUES (N'admin', N'123456', N'ADM       ')
INSERT [dbo].[DANGNHAP] ([TAIKHOAN], [MATKHAU], [QUYEN]) VALUES (N'gv01@hcmue', N'123gv01', N'GV        ')
INSERT [dbo].[DANGNHAP] ([TAIKHOAN], [MATKHAU], [QUYEN]) VALUES (N'gv02@hcmue', N'123gv02', N'GV        ')
INSERT [dbo].[DANGNHAP] ([TAIKHOAN], [MATKHAU], [QUYEN]) VALUES (N'gv03@hcmue', N'123gv03', N'GV        ')
INSERT [dbo].[DANGNHAP] ([TAIKHOAN], [MATKHAU], [QUYEN]) VALUES (N'gv04@hcmue', N'123gv04', N'GV        ')
INSERT [dbo].[DANGNHAP] ([TAIKHOAN], [MATKHAU], [QUYEN]) VALUES (N'gv05@hcmue', N'123gv05', N'GV        ')
INSERT [dbo].[DANGNHAP] ([TAIKHOAN], [MATKHAU], [QUYEN]) VALUES (N'gv06@hcmue', N'123gv06', N'GV        ')
INSERT [dbo].[DANGNHAP] ([TAIKHOAN], [MATKHAU], [QUYEN]) VALUES (N'gv07@hcmue', N'123gv07', N'GV        ')
INSERT [dbo].[DANGNHAP] ([TAIKHOAN], [MATKHAU], [QUYEN]) VALUES (N'gv08@hcmue', N'123gv08', N'GV        ')
INSERT [dbo].[DANGNHAP] ([TAIKHOAN], [MATKHAU], [QUYEN]) VALUES (N'gv09@hcmue', N'123gv09', N'GV        ')
INSERT [dbo].[DANGNHAP] ([TAIKHOAN], [MATKHAU], [QUYEN]) VALUES (N'gv10@hcmue', N'123gv10', N'GV        ')
GO
INSERT [dbo].[GIANGVIEN] ([MAGV], [HOTEN], [GIOITINH], [SODIENTHOAI], [EMAIL], [PHANLOAI], [TAIKHOAN_GV]) VALUES (N'GV01  ', N'Lương Trần Ngọc Khiết', N'Nam', N'0173948272', N'khietltn@lecture.gmail.com', N'Chính thức', N'gv01@hcmue')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HOTEN], [GIOITINH], [SODIENTHOAI], [EMAIL], [PHANLOAI], [TAIKHOAN_GV]) VALUES (N'GV02  ', N'Mai Ngân Giang', N'Nữ', N'0473829123', N'giangmn@lecture.gmail.com', N'Chính thức', N'gv02@hcmue')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HOTEN], [GIOITINH], [SODIENTHOAI], [EMAIL], [PHANLOAI], [TAIKHOAN_GV]) VALUES (N'GV03  ', N'Nguyễn Văn Thịnh', N'Nam', N'0628392873', N'thinhnv@lecture.gmail.com', N'Chính thức', N'gv03@hcmue')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HOTEN], [GIOITINH], [SODIENTHOAI], [EMAIL], [PHANLOAI], [TAIKHOAN_GV]) VALUES (N'GV04  ', N'Nguyễn Văn Nam', N'Nam', N'0473879123', N'namnv@lecture.gmail.com', N'Thỉnh giảng', N'gv04@hcmue')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HOTEN], [GIOITINH], [SODIENTHOAI], [EMAIL], [PHANLOAI], [TAIKHOAN_GV]) VALUES (N'GV05  ', N'Nguyễn Viết Hưng', N'Nam', N'0628349533', N'hungnv@lecture.gmail.com', N'Chính thức', N'gv05@hcmue')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HOTEN], [GIOITINH], [SODIENTHOAI], [EMAIL], [PHANLOAI], [TAIKHOAN_GV]) VALUES (N'GV06  ', N'Lê Ngọc Thảo Vy', N'Nữ', N'0975315789', N'vylnt@lecture.gmail.com', N'Chính thức', N'gv06@hcmue')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HOTEN], [GIOITINH], [SODIENTHOAI], [EMAIL], [PHANLOAI], [TAIKHOAN_GV]) VALUES (N'GV07  ', N'Nguyễn Thị Bích Trâm', N'Nữ', N'0863468942', N'tramntb@lecture.gmail.com', N'Chính thức', N'gv07@hcmue')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HOTEN], [GIOITINH], [SODIENTHOAI], [EMAIL], [PHANLOAI], [TAIKHOAN_GV]) VALUES (N'GV08  ', N'Trần Thanh Nhã', N'Nam', N'0642796247', N'nhatt@lecture.gmail.com', N'Chính thức', N'gv08@hcmue')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HOTEN], [GIOITINH], [SODIENTHOAI], [EMAIL], [PHANLOAI], [TAIKHOAN_GV]) VALUES (N'GV09  ', N'Trần Hữu Quốc Thư', N'Nam', N'0637962689', N'thuthq@lecture.gmail.com', N'Thỉnh giảng', N'gv09@hcmue')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HOTEN], [GIOITINH], [SODIENTHOAI], [EMAIL], [PHANLOAI], [TAIKHOAN_GV]) VALUES (N'GV10  ', N'Ngô Văn Sơn', N'Nam', N'0732489642', N'sơngv@lecture.gmail.com', N'Chính thức', N'gv10@hcmue')
GO
INSERT [dbo].[GIANGVIEN_DAY_MONHOC] ([MAGV], [MAMONHOC]) VALUES (N'GV01  ', N'MH01  ')
INSERT [dbo].[GIANGVIEN_DAY_MONHOC] ([MAGV], [MAMONHOC]) VALUES (N'GV01  ', N'MH02  ')
INSERT [dbo].[GIANGVIEN_DAY_MONHOC] ([MAGV], [MAMONHOC]) VALUES (N'GV02  ', N'MH06  ')
INSERT [dbo].[GIANGVIEN_DAY_MONHOC] ([MAGV], [MAMONHOC]) VALUES (N'GV03  ', N'MH04  ')
INSERT [dbo].[GIANGVIEN_DAY_MONHOC] ([MAGV], [MAMONHOC]) VALUES (N'GV04  ', N'MH08  ')
INSERT [dbo].[GIANGVIEN_DAY_MONHOC] ([MAGV], [MAMONHOC]) VALUES (N'GV04  ', N'MH09  ')
INSERT [dbo].[GIANGVIEN_DAY_MONHOC] ([MAGV], [MAMONHOC]) VALUES (N'GV05  ', N'MH07  ')
INSERT [dbo].[GIANGVIEN_DAY_MONHOC] ([MAGV], [MAMONHOC]) VALUES (N'GV06  ', N'MH02  ')
INSERT [dbo].[GIANGVIEN_DAY_MONHOC] ([MAGV], [MAMONHOC]) VALUES (N'GV07  ', N'MH05  ')
INSERT [dbo].[GIANGVIEN_DAY_MONHOC] ([MAGV], [MAMONHOC]) VALUES (N'GV08  ', N'MH03  ')
INSERT [dbo].[GIANGVIEN_DAY_MONHOC] ([MAGV], [MAMONHOC]) VALUES (N'GV09  ', N'MH05  ')
INSERT [dbo].[GIANGVIEN_DAY_MONHOC] ([MAGV], [MAMONHOC]) VALUES (N'GV09  ', N'MH06  ')
INSERT [dbo].[GIANGVIEN_DAY_MONHOC] ([MAGV], [MAMONHOC]) VALUES (N'GV10  ', N'MH01  ')
INSERT [dbo].[GIANGVIEN_DAY_MONHOC] ([MAGV], [MAMONHOC]) VALUES (N'GV10  ', N'MH08  ')
GO
INSERT [dbo].[KETQUA] ([MASV], [MAMONHOC], [DIEMQUATRINH], [DIEMCUOIKY], [DIEMTONGKET], [HOCKY], [XEPLOAI], [GHICHU]) VALUES (N'SV01  ', N'MH01  ', 8, 9, 8.5, 1, N'Giỏi', N'')
INSERT [dbo].[KETQUA] ([MASV], [MAMONHOC], [DIEMQUATRINH], [DIEMCUOIKY], [DIEMTONGKET], [HOCKY], [XEPLOAI], [GHICHU]) VALUES (N'SV01  ', N'MH09  ', 7, 8, 7.5, 2, N'Khá', N'')
INSERT [dbo].[KETQUA] ([MASV], [MAMONHOC], [DIEMQUATRINH], [DIEMCUOIKY], [DIEMTONGKET], [HOCKY], [XEPLOAI], [GHICHU]) VALUES (N'SV02  ', N'MH03  ', 8, 9, 8.5, 1, N'Giỏi', N'')
INSERT [dbo].[KETQUA] ([MASV], [MAMONHOC], [DIEMQUATRINH], [DIEMCUOIKY], [DIEMTONGKET], [HOCKY], [XEPLOAI], [GHICHU]) VALUES (N'SV02  ', N'MH07  ', 7, 9, 8, 2, N'Giỏi', NULL)
INSERT [dbo].[KETQUA] ([MASV], [MAMONHOC], [DIEMQUATRINH], [DIEMCUOIKY], [DIEMTONGKET], [HOCKY], [XEPLOAI], [GHICHU]) VALUES (N'SV03  ', N'MH04  ', 9, 9, 9, 1, N'Xuất sắc', NULL)
INSERT [dbo].[KETQUA] ([MASV], [MAMONHOC], [DIEMQUATRINH], [DIEMCUOIKY], [DIEMTONGKET], [HOCKY], [XEPLOAI], [GHICHU]) VALUES (N'SV03  ', N'MH06  ', 6, 8, 7, 2, N'Khá', NULL)
INSERT [dbo].[KETQUA] ([MASV], [MAMONHOC], [DIEMQUATRINH], [DIEMCUOIKY], [DIEMTONGKET], [HOCKY], [XEPLOAI], [GHICHU]) VALUES (N'SV04  ', N'MH02  ', 8, 9, 8.5, 1, N'Giỏi', NULL)
INSERT [dbo].[KETQUA] ([MASV], [MAMONHOC], [DIEMQUATRINH], [DIEMCUOIKY], [DIEMTONGKET], [HOCKY], [XEPLOAI], [GHICHU]) VALUES (N'SV04  ', N'MH03  ', 7, 7, 7, 2, N'Khá', NULL)
INSERT [dbo].[KETQUA] ([MASV], [MAMONHOC], [DIEMQUATRINH], [DIEMCUOIKY], [DIEMTONGKET], [HOCKY], [XEPLOAI], [GHICHU]) VALUES (N'SV05  ', N'MH02  ', 5, 8, 6.5, 1, N'Khá', NULL)
INSERT [dbo].[KETQUA] ([MASV], [MAMONHOC], [DIEMQUATRINH], [DIEMCUOIKY], [DIEMTONGKET], [HOCKY], [XEPLOAI], [GHICHU]) VALUES (N'SV05  ', N'MH06  ', 6, 6, 6, 2, N'Trung bình', NULL)
INSERT [dbo].[KETQUA] ([MASV], [MAMONHOC], [DIEMQUATRINH], [DIEMCUOIKY], [DIEMTONGKET], [HOCKY], [XEPLOAI], [GHICHU]) VALUES (N'SV06  ', N'MH03  ', 7, 8, 7.5, 1, N'Khá', NULL)
INSERT [dbo].[KETQUA] ([MASV], [MAMONHOC], [DIEMQUATRINH], [DIEMCUOIKY], [DIEMTONGKET], [HOCKY], [XEPLOAI], [GHICHU]) VALUES (N'SV06  ', N'MH04  ', 9, 4, 6.5, 2, N'Khá', NULL)
INSERT [dbo].[KETQUA] ([MASV], [MAMONHOC], [DIEMQUATRINH], [DIEMCUOIKY], [DIEMTONGKET], [HOCKY], [XEPLOAI], [GHICHU]) VALUES (N'SV07  ', N'MH05  ', 5, 8, 6.5, 1, N'Khá', NULL)
INSERT [dbo].[KETQUA] ([MASV], [MAMONHOC], [DIEMQUATRINH], [DIEMCUOIKY], [DIEMTONGKET], [HOCKY], [XEPLOAI], [GHICHU]) VALUES (N'SV07  ', N'MH07  ', 10, 6, 8, 2, N'Giỏi', NULL)
INSERT [dbo].[KETQUA] ([MASV], [MAMONHOC], [DIEMQUATRINH], [DIEMCUOIKY], [DIEMTONGKET], [HOCKY], [XEPLOAI], [GHICHU]) VALUES (N'SV08  ', N'MH01  ', 3, 8, 5.5, 1, N'Trung bình', NULL)
INSERT [dbo].[KETQUA] ([MASV], [MAMONHOC], [DIEMQUATRINH], [DIEMCUOIKY], [DIEMTONGKET], [HOCKY], [XEPLOAI], [GHICHU]) VALUES (N'SV08  ', N'MH09  ', 7, 5, 6, 2, N'Trung bình', NULL)
INSERT [dbo].[KETQUA] ([MASV], [MAMONHOC], [DIEMQUATRINH], [DIEMCUOIKY], [DIEMTONGKET], [HOCKY], [XEPLOAI], [GHICHU]) VALUES (N'SV09  ', N'MH03  ', 8, 7, 7.5, 2, N'Khá', NULL)
INSERT [dbo].[KETQUA] ([MASV], [MAMONHOC], [DIEMQUATRINH], [DIEMCUOIKY], [DIEMTONGKET], [HOCKY], [XEPLOAI], [GHICHU]) VALUES (N'SV09  ', N'MH05  ', 9, 10, 9.5, 1, N'Xuất sắc', NULL)
INSERT [dbo].[KETQUA] ([MASV], [MAMONHOC], [DIEMQUATRINH], [DIEMCUOIKY], [DIEMTONGKET], [HOCKY], [XEPLOAI], [GHICHU]) VALUES (N'SV10  ', N'MH06  ', 4, 9, 6.5, 1, N'Khá', NULL)
INSERT [dbo].[KETQUA] ([MASV], [MAMONHOC], [DIEMQUATRINH], [DIEMCUOIKY], [DIEMTONGKET], [HOCKY], [XEPLOAI], [GHICHU]) VALUES (N'SV10  ', N'MH09  ', 5, 5, 5, 2, N'Trung bình', NULL)
GO
INSERT [dbo].[LOPHOC] ([MALOP], [TENLOP], [GVQUANLY]) VALUES (N'CNTTA ', N'Công nghệ thông tin A', N'GV01  ')
INSERT [dbo].[LOPHOC] ([MALOP], [TENLOP], [GVQUANLY]) VALUES (N'CNTTB ', N'Công nghệ thông tin B', N'GV03  ')
INSERT [dbo].[LOPHOC] ([MALOP], [TENLOP], [GVQUANLY]) VALUES (N'CNTTC ', N'Công nghệ thông tin C', N'GV04  ')
INSERT [dbo].[LOPHOC] ([MALOP], [TENLOP], [GVQUANLY]) VALUES (N'CNTTD ', N'Công nghệ thông tin D', N'GV07  ')
INSERT [dbo].[LOPHOC] ([MALOP], [TENLOP], [GVQUANLY]) VALUES (N'SPTA  ', N'Sư phạm tin A', N'GV02  ')
INSERT [dbo].[LOPHOC] ([MALOP], [TENLOP], [GVQUANLY]) VALUES (N'SPTB  ', N'Sư phạm tin B', N'GV08  ')
GO
INSERT [dbo].[MONHOC] ([MAMONHOC], [TENMONHOC], [SOTINCHI], [HOCKY]) VALUES (N'MH01  ', N'Công Nghệ Web', 3, 1)
INSERT [dbo].[MONHOC] ([MAMONHOC], [TENMONHOC], [SOTINCHI], [HOCKY]) VALUES (N'MH02  ', N'Công Nghệ Phần Mềm', 3, 1)
INSERT [dbo].[MONHOC] ([MAMONHOC], [TENMONHOC], [SOTINCHI], [HOCKY]) VALUES (N'MH03  ', N'Cơ Sở Dữ Liệu', 3, 1)
INSERT [dbo].[MONHOC] ([MAMONHOC], [TENMONHOC], [SOTINCHI], [HOCKY]) VALUES (N'MH04  ', N'Các Hệ Cơ Sở Dữ Liệu', 3, 1)
INSERT [dbo].[MONHOC] ([MAMONHOC], [TENMONHOC], [SOTINCHI], [HOCKY]) VALUES (N'MH05  ', N'Lập Trình Cơ Bản', 3, 2)
INSERT [dbo].[MONHOC] ([MAMONHOC], [TENMONHOC], [SOTINCHI], [HOCKY]) VALUES (N'MH06  ', N'Lập Trình Nâng Cao', 3, 1)
INSERT [dbo].[MONHOC] ([MAMONHOC], [TENMONHOC], [SOTINCHI], [HOCKY]) VALUES (N'MH07  ', N'Toán Rời Rạc', 3, 1)
INSERT [dbo].[MONHOC] ([MAMONHOC], [TENMONHOC], [SOTINCHI], [HOCKY]) VALUES (N'MH08  ', N'Hệ Thống Mã Nguồn Mở', 2, 2)
INSERT [dbo].[MONHOC] ([MAMONHOC], [TENMONHOC], [SOTINCHI], [HOCKY]) VALUES (N'MH09  ', N'Công Nghệ Net', 3, 1)
GO
INSERT [dbo].[PHANQUYEN] ([MAQUYEN], [TENQUYEN]) VALUES (N'ADM       ', N'ADMIN')
INSERT [dbo].[PHANQUYEN] ([MAQUYEN], [TENQUYEN]) VALUES (N'GV        ', N'GIANGVIEN')
GO
INSERT [dbo].[SINHVIEN] ([MASV], [HOTEN], [NGAYSINH], [GIOITINH], [DIACHI], [TINHTRANG], [MALOP]) VALUES (N'SV01  ', N'Nguyễn Đình Hưng', CAST(N'2001-10-10' AS Date), N'Nam', N'Phú Định', N'Đang học', N'CNTTA ')
INSERT [dbo].[SINHVIEN] ([MASV], [HOTEN], [NGAYSINH], [GIOITINH], [DIACHI], [TINHTRANG], [MALOP]) VALUES (N'SV02  ', N'Vũ Khắc Cường', CAST(N'2003-09-09' AS Date), N'Nam', N'Bình Định', N'Đang học', N'CNTTC ')
INSERT [dbo].[SINHVIEN] ([MASV], [HOTEN], [NGAYSINH], [GIOITINH], [DIACHI], [TINHTRANG], [MALOP]) VALUES (N'SV03  ', N'Phạm Lê Tường Vy', CAST(N'2003-01-09' AS Date), N'Nữ', N'Bình Dương', N'Đang học', N'SPTA  ')
INSERT [dbo].[SINHVIEN] ([MASV], [HOTEN], [NGAYSINH], [GIOITINH], [DIACHI], [TINHTRANG], [MALOP]) VALUES (N'SV04  ', N'Lý Ngọc Lê Thy', CAST(N'2002-06-10' AS Date), N'Nữ', N'TP HCM', N'Đang học', N'CNTTA ')
INSERT [dbo].[SINHVIEN] ([MASV], [HOTEN], [NGAYSINH], [GIOITINH], [DIACHI], [TINHTRANG], [MALOP]) VALUES (N'SV05  ', N'Nguyễn Hà Minh', CAST(N'2003-06-12' AS Date), N'Nam', N'Quảng Ngãi', N'Đang học', N'CNTTB ')
INSERT [dbo].[SINHVIEN] ([MASV], [HOTEN], [NGAYSINH], [GIOITINH], [DIACHI], [TINHTRANG], [MALOP]) VALUES (N'SV06  ', N'Lý Trung Đức', CAST(N'2003-07-12' AS Date), N'Nam', N'Hà Tĩnh', N'Đang học', N'CNTTA ')
INSERT [dbo].[SINHVIEN] ([MASV], [HOTEN], [NGAYSINH], [GIOITINH], [DIACHI], [TINHTRANG], [MALOP]) VALUES (N'SV07  ', N'Lê Văn Vũ', CAST(N'2003-04-02' AS Date), N'Nam', N'Đắk Lắk', N'Đang học', N'SPTB  ')
INSERT [dbo].[SINHVIEN] ([MASV], [HOTEN], [NGAYSINH], [GIOITINH], [DIACHI], [TINHTRANG], [MALOP]) VALUES (N'SV08  ', N'Trần Nhật Linh', CAST(N'2003-02-09' AS Date), N'Nam', N'Cao Bằng', N'Đang học', N'SPTB  ')
INSERT [dbo].[SINHVIEN] ([MASV], [HOTEN], [NGAYSINH], [GIOITINH], [DIACHI], [TINHTRANG], [MALOP]) VALUES (N'SV09  ', N'Bùi Quốc Đạt', CAST(N'2002-11-19' AS Date), N'Nam', N'TP HCM', N'Đang học', N'CNTTB ')
INSERT [dbo].[SINHVIEN] ([MASV], [HOTEN], [NGAYSINH], [GIOITINH], [DIACHI], [TINHTRANG], [MALOP]) VALUES (N'SV10  ', N'Trần Nhất Khang', CAST(N'2002-09-26' AS Date), N'Nam', N'Vũng Tàu', N'Đang học', N'CNTTD ')
GO
ALTER TABLE [dbo].[DANGNHAP]  WITH CHECK ADD  CONSTRAINT [fk_DN_QUYEN] FOREIGN KEY([QUYEN])
REFERENCES [dbo].[PHANQUYEN] ([MAQUYEN])
GO
ALTER TABLE [dbo].[DANGNHAP] CHECK CONSTRAINT [fk_DN_QUYEN]
GO
ALTER TABLE [dbo].[GIANGVIEN]  WITH CHECK ADD  CONSTRAINT [fk_GV_TAIKHOAN] FOREIGN KEY([TAIKHOAN_GV])
REFERENCES [dbo].[DANGNHAP] ([TAIKHOAN])
GO
ALTER TABLE [dbo].[GIANGVIEN] CHECK CONSTRAINT [fk_GV_TAIKHOAN]
GO
ALTER TABLE [dbo].[GIANGVIEN_DAY_MONHOC]  WITH CHECK ADD  CONSTRAINT [fk_GVDMH_MAGV] FOREIGN KEY([MAGV])
REFERENCES [dbo].[GIANGVIEN] ([MAGV])
GO
ALTER TABLE [dbo].[GIANGVIEN_DAY_MONHOC] CHECK CONSTRAINT [fk_GVDMH_MAGV]
GO
ALTER TABLE [dbo].[GIANGVIEN_DAY_MONHOC]  WITH CHECK ADD  CONSTRAINT [fk_GVDMH_MAMONHOC] FOREIGN KEY([MAMONHOC])
REFERENCES [dbo].[MONHOC] ([MAMONHOC])
GO
ALTER TABLE [dbo].[GIANGVIEN_DAY_MONHOC] CHECK CONSTRAINT [fk_GVDMH_MAMONHOC]
GO
ALTER TABLE [dbo].[KETQUA]  WITH CHECK ADD  CONSTRAINT [fk_KQ_MAMONHOC] FOREIGN KEY([MAMONHOC])
REFERENCES [dbo].[MONHOC] ([MAMONHOC])
GO
ALTER TABLE [dbo].[KETQUA] CHECK CONSTRAINT [fk_KQ_MAMONHOC]
GO
ALTER TABLE [dbo].[KETQUA]  WITH CHECK ADD  CONSTRAINT [fk_KQ_MASV] FOREIGN KEY([MASV])
REFERENCES [dbo].[SINHVIEN] ([MASV])
GO
ALTER TABLE [dbo].[KETQUA] CHECK CONSTRAINT [fk_KQ_MASV]
GO
ALTER TABLE [dbo].[LOPHOC]  WITH CHECK ADD  CONSTRAINT [fk_LH_GVQUANLY] FOREIGN KEY([GVQUANLY])
REFERENCES [dbo].[GIANGVIEN] ([MAGV])
GO
ALTER TABLE [dbo].[LOPHOC] CHECK CONSTRAINT [fk_LH_GVQUANLY]
GO
/****** Object:  StoredProcedure [dbo].[Check_Exists_LopHoc]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Check_Exists_LopHoc]
@tenlop nvarchar(200)
as
begin
	select l.MALOP
	from LOPHOC l
	where l.[TENLOP] = N''+@tenlop
end
GO
/****** Object:  StoredProcedure [dbo].[Check_Exists_MonHoc]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Check_Exists_MonHoc]
@tenmh nvarchar(200)
as
begin
	select m.MAMONHOC
	from MONHOC m
	where m.[TENMONHOC] = N''+@tenmh
end
GO
/****** Object:  StoredProcedure [dbo].[HienThiDiemSinhVien]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[HienThiDiemSinhVien]
AS
BEGIN
   SELECT KETQUA.MASV, SINHVIEN.HOTEN, SINHVIEN.MALOP, KETQUA.MAMONHOC, KETQUA.DIEMQUATRINH, KETQUA.DIEMCUOIKY, KETQUA.DIEMTONGKET,
		  KETQUA.HOCKY, KETQUA.XEPLOAI, KETQUA.GHICHU
   FROM KETQUA, SINHVIEN
   WHERE KETQUA.MASV = SINHVIEN.MASV
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DSMonHoc]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--lấy danh sách môn học 
create proc [dbo].[SP_DSMonHoc]
as
begin
    select * from MONHOC
end

GO
/****** Object:  StoredProcedure [dbo].[sp_DSSV]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DSSV]
  @monHoc NVarChar(50),
  @xepLoai NVarChar(50)
as
begin
SELECT ROW_NUMBER() OVER (ORDER BY SINHVIEN.MASV) AS STT,
SINHVIEN.MASV, SINHVIEN.HOTEN, SINHVIEN.NGAYSINH, SINHVIEN.GIOITINH, SINHVIEN.DIACHI,SINHVIEN.MALOP, SINHVIEN.TINHTRANG
FROM SINHVIEN
iNNER JOIN KETQUA ON KETQUA.MASV = SINHVIEN.MASV
INNER JOIN MONHOC ON KETQUA.MAMONHOC = MONHOC.MAMONHOC 
WHERE MONHOC.TENMONHOC= @monHoc AND KETQUA.XEPLOAI =  @xepLoai
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GiangVien]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_GiangVien]
AS
	BEGIN
		SELECT * FROM GIANGVIEN
	END
GO
/****** Object:  StoredProcedure [dbo].[SP_lAYDSHS]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_lAYDSHS]
as
begin
    select * from SINHVIEN
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Retrieve_LopHoc]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_Retrieve_LopHoc]
as
begin
	select * from LOPHOC
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Retrieve_MonHoc]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_Retrieve_MonHoc]
as
begin
	select * from MONHOC
end
GO
/****** Object:  StoredProcedure [dbo].[sp_SinhVien]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_SinhVien]
AS
	BEGIN
		SELECT * FROM SINHVIEN
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_SuaGV]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_SuaGV] @magv char(6), @hoten nvarchar(50), @gioitinh nvarchar(5), @sodienthoai nvarchar(15), @email nvarchar(50),
					 @phanloai nvarchar(50), @taikhoan nvarchar(50)
AS
	BEGIN
		UPDATE GIANGVIEN
		SET HOTEN = @hoten,
			GIOITINH = @gioitinh,
			SODIENTHOAI = @sodienthoai,
			EMAIL = @email,
			PHANLOAI = @phanloai,
			TAIKHOAN_GV = @taikhoan
		WHERE MAGV = @magv
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_SuaSV]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_SuaSV] @masv char(6), @hoten nvarchar(50), @ngaysinh date, @gioitinh nvarchar(5), @diachi nvarchar(50),
					 @tinhtrang nvarchar(30), @malop char(6)
AS
	BEGIN
		UPDATE SINHVIEN
		SET HOTEN = @hoten,
			NGAYSINH = @ngaysinh,
			GIOITINH = @gioitinh,
			DIACHI = @diachi,
			TINHTRANG = @tinhtrang,
			MALOP = @malop
		WHERE MASV = @masv
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemGV]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ThemGV] @magv char(6), @hoten nvarchar(50), @gioitinh nvarchar(5), @sodienthoai nvarchar(15), @email nvarchar(50),
					  @phanloai nvarchar(50), @taikhoan nvarchar(50), @matkhau nvarchar(30)

AS
BEGIN
    INSERT INTO DANGNHAP VALUES 
	(@taikhoan, @matkhau, 'GV')

    INSERT INTO GIANGVIEN VALUES 
	(@magv, @hoten, @gioitinh, @sodienthoai, @email, @phanloai, @taikhoan)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemMonHocChoGiangVien]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ThemMonHocChoGiangVien] @magv char(6), @mamonhoc char(6)
AS
BEGIN
    -- Kiểm tra xem giảng viên và môn học đã tồn tại trong bảng GIANGVIEN_DAY_MONHOC chưa
    IF NOT EXISTS (SELECT 1 FROM GIANGVIEN_DAY_MONHOC
				   WHERE MAGV = @magv AND MAMONHOC = @mamonhoc)
    BEGIN
        -- Thêm môn học cho giảng viên
        INSERT INTO GIANGVIEN_DAY_MONHOC VALUES
		(@magv, @mamonhoc)
    END
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemSV]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ThemSV] @masv char(6), @hoten nvarchar(50), @ngaysinh date, @gioitinh nvarchar(5), @diachi nvarchar(50),
					  @tinhtrang nvarchar(30), @malop char(6)
AS
	BEGIN
		INSERT INTO SINHVIEN VALUES
		(@masv, @hoten, @ngaysinh, @gioitinh, @diachi, @tinhtrang, @malop)
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_ThongTinGV]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ThongTinGV] @magv char(6)
AS
	BEGIN
		SELECT * FROM GIANGVIEN
		WHERE MAGV = @magv
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_ThongTinMH]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ThongTinMH] @magv char(6)
AS
	BEGIN
		SELECT GIANGVIEN_DAY_MONHOC.MAGV, GIANGVIEN.HOTEN, GIANGVIEN_DAY_MONHOC.MAMONHOC, MONHOC.TENMONHOC, MONHOC.SOTINCHI
		FROM GIANGVIEN, GIANGVIEN_DAY_MONHOC, MONHOC
		WHERE GIANGVIEN.MAGV = GIANGVIEN_DAY_MONHOC.MAGV
		AND GIANGVIEN_DAY_MONHOC.MAMONHOC = MONHOC.MAMONHOC
		AND GIANGVIEN.MAGV = @magv
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_TimKiemSV]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_TimKiemSV] @malop char(6)
AS
	BEGIN
		SELECT * FROM SINHVIEN
		WHERE MALOP = @malop
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaGV]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_XoaGV] @magv char(6)
AS 
	BEGIN
		DELETE FROM GIANGVIEN
		WHERE MAGV = @magv
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaMonHocCuaGiangVien]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_XoaMonHocCuaGiangVien] @magv char(6), @mamonhoc char(6)
AS
BEGIN
    -- Kiểm tra xem giảng viên và môn học đã tồn tại trong bảng GIANGVIEN_DAY_MONHOC chưa
    IF EXISTS (SELECT 1 FROM GIANGVIEN_DAY_MONHOC
			   WHERE MAGV = @magv AND MAMONHOC = @mamonhoc)
    BEGIN
		--Xóa môn học cho giảng viên
        DELETE FROM GIANGVIEN_DAY_MONHOC
        WHERE MAGV = @magv AND MAMONHOC = @mamonhoc
    END
END
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaSV]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_XoaSV] @masv char(6)
AS 
	BEGIN
		DELETE FROM SINHVIEN 
		WHERE MASV = @masv
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaThongTinGV]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_XoaThongTinGV] (@MAGV char(6))
AS
BEGIN
    -- Kiểm tra xem có dữ liệu trong bảng LOPHOC hay không
    IF NOT EXISTS (SELECT 1 FROM LOPHOC WHERE GVQUANLY = @MAGV)
    BEGIN
        -- Nếu không có dữ liệu trong bảng LOPHOC, thực hiện xóa thông tin giảng viên
		  DECLARE @TKGV NVARCHAR(50) = (SELECT TAIKHOAN_GV FROM GIANGVIEN WHERE MAGV = @MAGV)

        -- Xóa dữ liệu trong bảng GIANGVIEN_DAY_MONHOC
        DELETE FROM GIANGVIEN_DAY_MONHOC
        WHERE MAGV = @MAGV

        -- Xóa dữ liệu trong bảng GIANGVIEN
        DELETE FROM GIANGVIEN 
		WHERE MAGV = @MAGV

        -- Xóa dữ liệu trong bảng DANGNHAP
        DELETE FROM DANGNHAP
        WHERE TAIKHOAN = @TKGV
    END
END
GO
/****** Object:  StoredProcedure [dbo].[SuaDiemSinhVien]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaDiemSinhVien]
    @MaSV char(6),
    @MaMonHoc char(6),
    @DiemQuaTrinh float,
    @DiemCuoiKy float,
    @HocKy int,
    @GhiChu nvarchar(150)
AS
BEGIN
   UPDATE KETQUA
   SET DIEMQUATRINH = @DiemQuaTrinh, DIEMCUOIKY = @DiemCuoiKy, HOCKY = @HocKy, GHICHU = @GhiChu
   WHERE MASV = @MaSV AND MAMONHOC = @MaMonHoc
END
GO
/****** Object:  StoredProcedure [dbo].[ThemDiemSinhVien]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemDiemSinhVien]
    @MaSV char(6),
    @MaMonHoc char(6),
    @DiemQuaTrinh float,
    @DiemCuoiKy float,
    @HocKy int,
    @GhiChu nvarchar(150)
AS
BEGIN
    DECLARE @HoTen nvarchar(50)
    DECLARE @MaLop char(6)
    
    -- Lấy thông tin sinh viên từ bảng SINHVIEN
    SELECT @HoTen = HOTEN, @MaLop = MALOP
    FROM SINHVIEN
    WHERE MASV = @MaSV

    -- Thêm điểm vào bảng KETQUA
    INSERT INTO KETQUA (MASV, MAMONHOC, DIEMQUATRINH, DIEMCUOIKY, HOCKY, GHICHU)
    VALUES (@MaSV, @MaMonHoc, @DiemQuaTrinh, @DiemCuoiKy, @HocKy, @GhiChu)
END
GO
/****** Object:  StoredProcedure [dbo].[ThongTinKetQuaSinhVien]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThongTinKetQuaSinhVien]
AS
	BEGIN
		SELECT * FROM KETQUA
	END

EXEC ThongTinKetQuaSinhVien
GO
/****** Object:  StoredProcedure [dbo].[TimDiemSinhVienTheoMonHoc]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TimDiemSinhVienTheoMonHoc]
   @MaMonHoc char(6)
AS
BEGIN
   SELECT * FROM KETQUA WHERE MAMONHOC = @MaMonHoc
END
GO
/****** Object:  StoredProcedure [dbo].[TimDiemTheoMaSinhVien]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TimDiemTheoMaSinhVien]
   @MaSV char(6)
AS
BEGIN
   SELECT * FROM KETQUA WHERE MASV = @MaSV 
END
GO
/****** Object:  StoredProcedure [dbo].[TimDiemTheoMaSinhVien_MonHoc]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TimDiemTheoMaSinhVien_MonHoc]
   @MaSV char(6), @MaMonHoc char(6)
AS
BEGIN
   SELECT * FROM KETQUA WHERE MASV = @MaSV AND MAMONHOC = @MaMonHoc
END
GO
/****** Object:  StoredProcedure [dbo].[USP_Mutation_AddLopHoc]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_Mutation_AddLopHoc]
@malop char(6),
@tenlop nvarchar(50),
@gvql char(6)
as
begin
	insert into [LOPHOC] (MALOP, TENLOP, GVQUANLY)
	values 
	(@malop, @tenlop, @gvql)
end
GO
/****** Object:  StoredProcedure [dbo].[USP_Mutation_AddMonHoc]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_Mutation_AddMonHoc]
@mamh char(6),
@tenmh nvarchar(50),
@sotc int,
@hocky int
as
begin
	declare @ids table (id char(6));
	insert into [MONHOC] (MAMONHOC, TENMONHOC, SOTINCHI, HOCKY)
	output inserted.MAMONHOC into @ids 
	values 
	(@mamh, @tenmh, @sotc, @hocky)
end
GO
/****** Object:  StoredProcedure [dbo].[USP_Mutation_DeleteLopHoc]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_Mutation_DeleteLopHoc]
@malop char(6)
as
begin
	delete from LOPHOC where MALOP = @malop
end
GO
/****** Object:  StoredProcedure [dbo].[USP_Mutation_DeleteMonHoc]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_Mutation_DeleteMonHoc]
@mamh char(6)
as
begin
	delete from MONHOC where MAMONHOC = @mamh
end
GO
/****** Object:  StoredProcedure [dbo].[USP_Mutation_UpdateLopHoc]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_Mutation_UpdateLopHoc]
@malop char(6),
@tenlop nvarchar(50),
@gvql char(6)
as
begin
	update [LOPHOC] set
		TENLOP = N'' + @tenlop,
		GVQUANLY = @gvql
	where MALOP = @malop
end
GO
/****** Object:  StoredProcedure [dbo].[USP_Mutation_UpdateMonHoc]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_Mutation_UpdateMonHoc]
@mamh char(6),
@tenmh nvarchar(50),
@sotc int,
@hocky int
as
begin
	update [MONHOC] set
		TENMONHOC = N'' + @tenmh,
		SOTINCHI = @sotc,
		HOCKY = @hocky
	where MAMONHOC = @mamh
end
GO
/****** Object:  StoredProcedure [dbo].[USP_Query_LH]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_Query_LH]
@malop char(6) 
as
begin
	select [LOPHOC].MALOP as [Mã lớp], [LOPHOC].TENLOP as [Tên lớp], 
	[LOPHOC].GVQUANLY as [Giảng viên quản lý]
	from [LOPHOC]
	where [LOPHOC].MALOP = @malop
end
GO
/****** Object:  StoredProcedure [dbo].[USP_Query_lophoc]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_Query_lophoc]
as
begin
	select [LOPHOC].MALOP as [Mã lớp], [LOPHOC].TENLOP as [Tên lớp], 
	[LOPHOC].GVQUANLY as [Giảng viên quản lý]
	from [LOPHOC]
end
GO
/****** Object:  StoredProcedure [dbo].[USP_Query_MH]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_Query_MH]
@mamh char(6) 
as
begin
	select [MONHOC].MAMONHOC as [Mã môn học], [MONHOC].TENMONHOC as [Tên môn học], 
	[MONHOC].SOTINCHI as [Số tín chỉ], [MONHOC].HOCKY as [Học kỳ]
	from [MONHOC]
	where [MONHOC].MAMONHOC = @mamh
end
GO
/****** Object:  StoredProcedure [dbo].[USP_Query_monhoc]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_Query_monhoc]
as
begin
	select [MONHOC].MAMONHOC as [Mã môn học], [MONHOC].TENMONHOC as [Tên môn học], 
	[MONHOC].SOTINCHI as [Số tín chỉ], [MONHOC].HOCKY as [Học kỳ]
	from [MONHOC]
end
GO
/****** Object:  StoredProcedure [dbo].[XEMDIEM]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[XEMDIEM]
AS
BEGIN
    DECLARE @MASV char(6)
    DECLARE @MAMONHOC char(6)
    DECLARE @DIEMQUATRINH float
    DECLARE @DIEMCUOIKY float
    DECLARE @DIEMTONGKET float

    DECLARE db_cursor CURSOR FOR
    SELECT MASV, MAMONHOC, DIEMQUATRINH, DIEMCUOIKY, DIEMTONGKET
    FROM KETQUA

    OPEN db_cursor
    FETCH NEXT FROM db_cursor INTO @MASV, @MAMONHOC, @DIEMQUATRINH, @DIEMCUOIKY, @DIEMTONGKET

    WHILE @@FETCH_STATUS = 0
    BEGIN
		PRINT 'MASV: ' +  @MASV + 'MAMONHOC: ' + @MAMONHOC + 'DIEMQUATRINH: ' + CAST(@DIEMQUATRINH AS NVARCHAR) + ', DIEMCUOIKY: ' + CAST(@DIEMCUOIKY AS NVARCHAR) + ', DIEMTONGKET: ' + CAST(@DIEMTONGKET AS NVARCHAR)
        FETCH NEXT FROM db_cursor INTO @MASV, @MAMONHOC, @DIEMQUATRINH, @DIEMCUOIKY, @DIEMTONGKET
    END

    CLOSE db_cursor
    DEALLOCATE db_cursor
END
GO
/****** Object:  StoredProcedure [dbo].[XoaDiemSinhVien]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[XoaDiemSinhVien]
   @MaSV char(6), @MaMonHoc	char(6), @HocKy int
AS
BEGIN
   DELETE FROM KETQUA WHERE MASV = @MaSV AND MAMONHOC = @MaMonHoc AND HOCKY = @HocKy
END
GO
/****** Object:  Trigger [dbo].[tg_KiemTraGioiTinhGiangVien]    Script Date: 8/16/2023 12:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tg_KiemTraGioiTinhGiangVien]
ON [dbo].[GIANGVIEN]
FOR INSERT, UPDATE
AS
BEGIN
	IF EXISTS (SELECT 1 FROM INSERTED
			   WHERE GIOITINH NOT IN (N'Nam', N'Nữ'))
    BEGIN
		Print 'KiemTraGioiTinhGiangVien'
        ROLLBACK TRAN
    END
    -- Nếu thông tin hợp lệ, tiến hành thêm hoặc sửa thông tin giảng viên
    IF EXISTS (SELECT 1 FROM INSERTED)
    BEGIN
        -- Thực hiện thêm giảng viên nếu mã giảng viên chưa tồn tại trong bảng GIANGVIEN
        INSERT INTO GIANGVIEN (MAGV, HOTEN, GIOITINH, SODIENTHOAI, EMAIL, PHANLOAI, TAIKHOAN_GV)
        SELECT INSERTED.MAGV, INSERTED.HOTEN, INSERTED.GIOITINH, INSERTED.SODIENTHOAI, INSERTED.EMAIL, INSERTED.PHANLOAI, INSERTED.TAIKHOAN_GV
        FROM INSERTED 
        LEFT JOIN GIANGVIEN ON INSERTED.MAGV = GIANGVIEN.MAGV
        WHERE GIANGVIEN.MAGV IS NULL
    END
    ELSE
    BEGIN
        -- Thực hiện sửa thông tin giảng viên nếu mã giảng viên đã tồn tại trong bảng GIANGVIEN
        UPDATE GIANGVIEN
        SET
            GIANGVIEN.HOTEN = INSERTED.HOTEN,
            GIANGVIEN.SODIENTHOAI = INSERTED.SODIENTHOAI,
            GIANGVIEN.EMAIL = INSERTED.EMAIL,
            GIANGVIEN.PHANLOAI = INSERTED.PHANLOAI
        FROM GIANGVIEN
        JOIN INSERTED ON GIANGVIEN.MAGV = INSERTED.MAGV
    END
END
GO
ALTER TABLE [dbo].[GIANGVIEN] ENABLE TRIGGER [tg_KiemTraGioiTinhGiangVien]
GO
/****** Object:  Trigger [dbo].[CAPNHATDIEMTONGKET_XEPLOAI]    Script Date: 8/16/2023 12:38:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[CAPNHATDIEMTONGKET_XEPLOAI]
ON [dbo].[KETQUA]
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE KETQUA
    SET DIEMTONGKET = (inserted.DIEMQUATRINH + inserted.DIEMCUOIKY) / 2,
        XEPLOAI = 
            CASE
				WHEN ((inserted.DIEMQUATRINH + inserted.DIEMCUOIKY) / 2) >= 9 THEN N'Xuất sắc'
                WHEN ((inserted.DIEMQUATRINH + inserted.DIEMCUOIKY) / 2) >= 8 THEN N'Giỏi'
                WHEN ((inserted.DIEMQUATRINH + inserted.DIEMCUOIKY) / 2) >= 6.5 THEN N'Khá'
                WHEN ((inserted.DIEMQUATRINH + inserted.DIEMCUOIKY) / 2) >= 5.0 THEN N'Trung bình'
                ELSE N'Yếu'
            END
    FROM KETQUA
    INNER JOIN inserted ON KETQUA.MASV = inserted.MASV AND KETQUA.MAMONHOC = inserted.MAMONHOC
END
GO
ALTER TABLE [dbo].[KETQUA] ENABLE TRIGGER [CAPNHATDIEMTONGKET_XEPLOAI]
GO
/****** Object:  Trigger [dbo].[tg_KiemTraGT_TTR]    Script Date: 8/16/2023 12:38:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tg_KiemTraGT_TTR]
ON [dbo].[SINHVIEN]
FOR INSERT, UPDATE
AS
BEGIN
    -- Kiểm tra giới tính và tình trạng học của các bản ghi được chèn hoặc sửa
    IF EXISTS (SELECT 1 FROM INSERTED
               WHERE GIOITINH NOT IN (N'Nam', N'Nữ') OR TINHTRANG NOT IN (N'Đang học', N'Đã tốt nghiệp', N'Thôi học'))
    BEGIN
        ROLLBACK TRAN
    END
    ELSE
    BEGIN
        -- Nếu thông tin hợp lệ, tiến hành thêm hoặc sửa thông tin sinh viên
        IF EXISTS (SELECT 1 FROM INSERTED)
        BEGIN
            -- Thực hiện thêm sinh viên nếu mã sinh viên chưa tồn tại trong bảng SINHVIEN
            INSERT INTO SINHVIEN (MASV, HOTEN, NGAYSINH, GIOITINH, DIACHI, TINHTRANG, MALOP)
            SELECT INSERTED.MASV, INSERTED.HOTEN, INSERTED.NGAYSINH, INSERTED.GIOITINH, INSERTED.DIACHI, INSERTED.TINHTRANG, INSERTED.MALOP
            FROM INSERTED 
            LEFT JOIN SINHVIEN ON INSERTED.MASV = SINHVIEN.MASV
            WHERE SINHVIEN.MASV IS NULL
        END
        ELSE
        BEGIN
            -- Thực hiện sửa thông tin sinh viên nếu mã sinh viên đã tồn tại trong bảng SINHVIEN
            UPDATE SINHVIEN
            SET
                HOTEN = INSERTED.HOTEN,
                NGAYSINH = INSERTED.NGAYSINH,
                GIOITINH = INSERTED.GIOITINH,
                DIACHI = INSERTED.DIACHI,
                TINHTRANG = INSERTED.TINHTRANG,
                MALOP = INSERTED.MALOP
            FROM SINHVIEN 
            JOIN INSERTED ON SINHVIEN.MASV = INSERTED.MASV
        END
    END
END
GO
ALTER TABLE [dbo].[SINHVIEN] ENABLE TRIGGER [tg_KiemTraGT_TTR]
GO
USE [master]
GO
ALTER DATABASE [QLDSV] SET  READ_WRITE 
GO
