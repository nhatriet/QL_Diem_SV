use QLDSV
----------------------------------------------YÊU CẦU CỦA CHỨC NĂNG----------------------------------------------------------
--Chức năng quản lý sinh viên:
--1. Store Proceduce:
--1.1. Tìm kiếm sinh viên theo mã lớp học.
CREATE PROC sp_TimKiemSV @malop char(6)
AS
	BEGIN
		SELECT * FROM SINHVIEN
		WHERE MALOP = @malop
	END

EXEC sp_TimKiemSV N'CNTTA'

--1.2. Thêm sinh viên.
CREATE PROC sp_ThemSV @masv char(6), @hoten nvarchar(50), @ngaysinh date, @gioitinh nvarchar(5), @diachi nvarchar(50),
					  @tinhtrang nvarchar(30), @malop char(6)
AS
	BEGIN
		INSERT INTO SINHVIEN VALUES
		(@masv, @hoten, @ngaysinh, @gioitinh, @diachi, @tinhtrang, @malop)
	END

EXEC sp_ThemSV N'SV11', N'Nguyễn Xuân Lan', N'2003-12-08', N'Nữ', N'Long An', N'Đang học', N'SPTA'
SELECT * FROM SINHVIEN

--1.3. Xóa sinh viên theo mã sinh viên
CREATE PROC sp_XoaSV @masv char(6)
AS 
	BEGIN
		DELETE FROM SINHVIEN 
		WHERE MASV = @masv
	END

EXEC sp_XoaSV N'SV11'
SELECT * FROM SINHVIEN

--1.4. Sửa thông tin sinh viên theo mã sinh viên
CREATE PROC sp_SuaSV @masv char(6), @hoten nvarchar(50), @ngaysinh date, @gioitinh nvarchar(5), @diachi nvarchar(50),
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

EXEC sp_SuaSV N'SV12', N'Nguyễn Minh Phong', N'2002-04-21', N'Nam', N'TP HCM', N'Đang học', N'CNTTA'
SELECT * FROM SINHVIEN

--1.5. Hiển thị thông tin toàn bộ sinh viên
CREATE PROC sp_SinhVien
AS
	BEGIN
		SELECT * FROM SINHVIEN
	END

EXEC sp_SinhVien

--2. Function:
--2.1. Viết hàm truyền vào mã sinh viên in ra thông tin sinh viên đó.
CREATE FUNCTION DSSINHVIEN (@masv char(6))
RETURNS TABLE
AS	
	RETURN
	(SELECT * FROM SINHVIEN
	 WHERE MASV = @masv)

SELECT * FROM DSSINHVIEN('SV11')

--3. Trigger:
--3.1. Kiểm tra giới tính (Nam, nữ), tình trạng học (Đang học, đã tốt nghiệp, thôi học) của sinh viên đó. 
--Nếu đúng thì thêm sinh viên khi chưa có mã sinh viên hoặc sửa thông tinh sinh viên khi chưa có mã sinh viên.
--Nếu không đúng thì không thực hiện thêm hoặc sửa.
CREATE TRIGGER tg_KiemTraGT_TTR
ON SINHVIEN
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

INSERT INTO SINHVIEN VALUES
(N'SV12', N'Nguyễn Minh Phong', N'2002-04-21', N'Nam', N'TP HCM', N'Đang học', N'CNTTA')

UPDATE SINHVIEN
SET TINHTRANG = N'Đang học'
WHERE MASV = N'SV12'

SELECT * FROM SINHVIEN

-- ==========================================================================================================================
--Chức năng quản lý giảng viên:
--1. Store proceduce:
--1.1. Thêm giảng viên
CREATE PROC sp_ThemGV @magv char(6), @hoten nvarchar(50), @gioitinh nvarchar(5), @sodienthoai nvarchar(15), @email nvarchar(50),
					  @phanloai nvarchar(50), @taikhoan nvarchar(50), @matkhau nvarchar(30)

AS
BEGIN
    INSERT INTO DANGNHAP VALUES 
	(@taikhoan, @matkhau, 'GV')

    INSERT INTO GIANGVIEN VALUES 
	(@magv, @hoten, @gioitinh, @sodienthoai, @email, @phanloai, @taikhoan)
END


EXEC sp_ThemGV N'GV11', N'Lương Trần Hy Hiến', N'Nam', N'0173345987', N'hienlth@lecture.gmail.com', N'Chính thức', 'gv11@hcmue',
				'123gv11'
SELECT * FROM DANGNHAP
SELECT * FROM GIANGVIEN

--1.2. Xóa giảng viên theo mã giảng viên
CREATE PROC sp_XoaGV @magv char(6)
AS 
	BEGIN
		DELETE FROM GIANGVIEN
		WHERE MAGV = @magv
	END

EXEC sp_XoaGV 'GV11'
SELECT * FROM GIANGVIEN

--1.3. Sửa thông tin giảng viên theo mã giảng viên
CREATE PROC sp_SuaGV @magv char(6), @hoten nvarchar(50), @gioitinh nvarchar(5), @sodienthoai nvarchar(15), @email nvarchar(50),
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

EXEC sp_SuaGV N'GV11', N'Lương Trần Hy Hiến', N'Nam', N'0173345987', N'hienlth@lecture.gmail.com', N'Chính thức', 'gv11@hcmue'
SELECT * FROM GIANGVIEN

--1.4. Hiển thị thông tin toàn bộ giảng viên
CREATE PROC sp_GiangVien
AS
	BEGIN
		SELECT * FROM GIANGVIEN
	END

EXEC sp_GiangVien

--1.5. Lấy thông tin của 1 giảng viên theo mã giảng viên
CREATE PROC sp_ThongTinGV @magv char(6)
AS
	BEGIN
		SELECT * FROM GIANGVIEN
		WHERE MAGV = @magv
	END

EXEC sp_ThongTinGV 'GV01'

--1.6. Lấy thông tin môn học mà giảng viên đó giảng dạy
CREATE PROC sp_ThongTinMH @magv char(6)
AS
	BEGIN
		SELECT GIANGVIEN_DAY_MONHOC.MAGV, GIANGVIEN.HOTEN, GIANGVIEN_DAY_MONHOC.MAMONHOC, MONHOC.TENMONHOC, MONHOC.SOTINCHI
		FROM GIANGVIEN, GIANGVIEN_DAY_MONHOC, MONHOC
		WHERE GIANGVIEN.MAGV = GIANGVIEN_DAY_MONHOC.MAGV
		AND GIANGVIEN_DAY_MONHOC.MAMONHOC = MONHOC.MAMONHOC
		AND GIANGVIEN.MAGV = @magv
	END

EXEC sp_ThongTinMH 'GV04'

--1.7. Thêm 1 môn học mà giảng viên đó giảng dạy 
CREATE PROCEDURE sp_ThemMonHocChoGiangVien @magv char(6), @mamonhoc char(6)
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

EXEC sp_ThemMonHocChoGiangVien 'GV01', 'MH03'
SELECT * FROM GIANGVIEN_DAY_MONHOC

--1.8. Xóa 1 môn học mà giảng viên đó giảng dạy
CREATE PROCEDURE sp_XoaMonHocCuaGiangVien @magv char(6), @mamonhoc char(6)
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

EXEC sp_XoaMonHocCuaGiangVien 'GV01', 'MH03'
SELECT * FROM GIANGVIEN_DAY_MONHOC

--1.9. Nếu giảng viên không có dữ liệu ở bảng LOPHOC thì sẽ xóa thông tin giảng viên đồng thời xóa giảng viên trong bảng GIANGVIEN_DAY_MONHOC,
--xóa giảng viên trong bảng GIANGVIEN, xóa tài khoản giảng viên trong bảng DANGNHAP
CREATE PROC sp_XoaThongTinGV (@MAGV char(6))
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

EXEC sp_XoaThongTinGV 'GV11'

--2. Trigger:
--2.1. Kiểm tra giới tính (Nam, nữ) của giảng viên đó. Nếu đúng thì thêm giảng viên khi chưa có mã giảng viên
--hoặc sửa thông tin giảng viên khi đã có mã giảng viên. Nếu không đúng thì không thực hiện thao tác thêm hoặc sửa
CREATE TRIGGER tg_KiemTraGioiTinhGiangVien
ON GIANGVIEN
FOR INSERT, UPDATE
AS
BEGIN
	IF EXISTS (SELECT 1 FROM INSERTED
			   WHERE GIOITINH NOT IN (N'Nam', N'Nữ'))
    BEGIN
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

INSERT INTO GIANGVIEN VALUES
(N'GV11', N'Lương Trần Hy Hiến', N'Nam', N'0173345987', N'hienlth@lecture.gmail.com', N'Chính thức', 'gv11@hcmue')

UPDATE GIANGVIEN
SET GIOITINH = N'Nam'
WHERE MAGV = 'GV10'
SELECT * FROM GIANGVIEN

-- ==========================================================================================================================
--Chức năng quản lý môn học:
--1. STORE PROCEDUCE:
create proc SP_Retrieve_MonHoc
as
begin
	select * from MONHOC
end
go

-- Hiển thị thông tin môn học 
create proc USP_Query_monhoc
as
begin
	select [MONHOC].MAMONHOC as [Mã môn học], [MONHOC].TENMONHOC as [Tên môn học], 
	[MONHOC].SOTINCHI as [Số tín chỉ], [MONHOC].HOCKY as [Học kỳ]
	from [MONHOC]
end
go

-- Hiển thị thông tin môn học khi truyền vào mã môn học 
-- input: @mamh char(6)
-- output: thông tin của môn học
create proc USP_Query_MH
@mamh char(6) 
as
begin
	select [MONHOC].MAMONHOC as [Mã môn học], [MONHOC].TENMONHOC as [Tên môn học], 
	[MONHOC].SOTINCHI as [Số tín chỉ], [MONHOC].HOCKY as [Học kỳ]
	from [MONHOC]
	where [MONHOC].MAMONHOC = @mamh
end

-- Kiểm tra xem môn học đã tồn tại chưa
-- input: @tenmh nvarchar(200)
go
create proc Check_Exists_MonHoc
@tenmh nvarchar(200)
as
begin
	select m.MAMONHOC
	from MONHOC m
	where m.[TENMONHOC] = N''+@tenmh
end

-- Thêm môn học 
-- input: @mamh char(6), @tenmh nvarchar(50), @sotc int, @hocky int
-- output: thông tin môn học sau khi được thêm
go
create proc USP_Mutation_AddMonHoc
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

-- Cập nhật môn học 
-- input: @mamh char(6),, @tenmh nvarchar(50), @sotc int, @hocky int
-- output: thông tin môn học sau khi được cập nhật
go
create proc USP_Mutation_UpdateMonHoc
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

-- Xóa môn học
-- input: @mamh char(6)
-- ouput: xóa thông tin môn học được chọn
go
create proc [dbo].[USP_Mutation_DeleteMonHoc]
@mamh char(6)
as
begin
	delete from MONHOC where MAMONHOC = @mamh
end

-- ==========================================================================================================================
--Chức năng quản lý lớp học:
--1. STORE PROCEDUCE:
go
create proc SP_Retrieve_LopHoc
as
begin
	select * from LOPHOC
end
go

-- Hiển thị thông tin lớp học 
go
create proc USP_Query_lophoc
as
begin
	select [LOPHOC].MALOP as [Mã lớp], [LOPHOC].TENLOP as [Tên lớp], 
	[LOPHOC].GVQUANLY as [Giảng viên quản lý]
	from [LOPHOC]
end

-- Hiển thị thông tin lớp học khi được truyền vào mã lớp
-- input: @malop char(6)
-- output: thông tin của lớp học
go
create proc USP_Query_LH
@malop char(6) 
as
begin
	select [LOPHOC].MALOP as [Mã lớp], [LOPHOC].TENLOP as [Tên lớp], 
	[LOPHOC].GVQUANLY as [Giảng viên quản lý]
	from [LOPHOC]
	where [LOPHOC].MALOP = @malop
end

-- Kiểm tra xem lớp học đã tồn tại chưa
-- input: @tenlop nvarchar(200)
go
create proc Check_Exists_LopHoc
@tenlop nvarchar(200)
as
begin
	select l.MALOP
	from LOPHOC l
	where l.[TENLOP] = N''+@tenlop
end

-- Thêm lớp học
-- input: @malop char(6), @tenlop nvarchar(50), @gvql char(6)
-- output: thông tin lớp học sau khi được thêm
go
create proc USP_Mutation_AddLopHoc
@malop char(6),
@tenlop nvarchar(50),
@gvql char(6)
as
begin
	insert into [LOPHOC] (MALOP, TENLOP, GVQUANLY)
	values 
	(@malop, @tenlop, @gvql)
end

-- Cập nhật lớp học
-- input: @malop char(6), @tenlop nvarchar(50), @gvql char(6)
-- output: thông tin lớp học sau khi được cập nhật
go
create proc USP_Mutation_UpdateLopHoc
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

-- Xóa lớp học
-- input: @malop char(6)
-- ouput: xóa thông tin lớp học được chọn
go
create proc [dbo].[USP_Mutation_DeleteLopHoc]
@malop char(6)
as
begin
	delete from LOPHOC where MALOP = @malop
end

-- ==========================================================================================================================
--Chức năng tìm kiếm điểm sinh viên:
--1. Store Proceduce:
--1.1. Tìm kiếm điểm theo mã sinh viên
CREATE PROCEDURE TimDiemTheoMaSinhVien
   @MaSV char(6)
AS
BEGIN
   SELECT * FROM KETQUA WHERE MASV = @MaSV 
END
GO

EXEC TimDiemTheoMaSinhVien 'SV01'

--1.2. Tìm kiếm điểm của sinh viên theo môn học
CREATE PROCEDURE TimDiemSinhVienTheoMonHoc
   @MaMonHoc char(6)
AS
BEGIN
   SELECT * FROM KETQUA WHERE MAMONHOC = @MaMonHoc
END
GO

EXEC TimDiemSinhVienTheoMonHoc 'MH01'

--1.3. Tìm kiếm điểm sinh viên theo mã sinh viên và mã môn học
CREATE PROCEDURE TimDiemTheoMaSinhVien_MonHoc
   @MaSV char(6), @MaMonHoc char(6)
AS
BEGIN
   SELECT * FROM KETQUA WHERE MASV = @MaSV AND MAMONHOC = @MaMonHoc
END
GO

EXEC TimDiemTheoMaSinhVien_MonHoc 'SV01', 'MH01'

--1.4. Hiển thị thông tin toàn bộ kết quả sinh viên
CREATE PROC ThongTinKetQuaSinhVien
AS
	BEGIN
		SELECT * FROM KETQUA
	END

EXEC ThongTinKetQuaSinhVien

--2. Function:
--2.1. Viết hàm truyền vào mã môn học và trả về tên môn học đó
CREATE FUNCTION LAYTENMONHOC
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

SELECT dbo.LAYTENMONHOC('MH01') AS TENMONHOC

--3. Trigger:
--3. Viết trigger cập nhật điểm tổng kết dựa vào công thức (điểm quá trình + điểm cuối kỳ) / 2
CREATE TRIGGER CAPNHATDIEMTONGKET
    ON KETQUA
    AFTER UPDATE
AS
BEGIN
    UPDATE KETQUA
    SET DIEMTONGKET = (DIEMQUATRINH + DIEMCUOIKY) / 2
    WHERE MASV IN (SELECT MASV FROM INSERTED)
END

UPDATE KETQUA
SET DIEMTONGKET = (DIEMQUATRINH + DIEMCUOIKY) / 2
WHERE MASV = 'SV01'

SELECT * FROM KETQUA

--4. Cursor:
--4.1. Viết cursor kết hợp với store proceduce để xem thông tin điểm của tất cả sinh viên
CREATE PROCEDURE XEMDIEM
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

EXEC XEMDIEM

-- ==========================================================================================================================
--Chức năng quản lý điểm sinh viên:
--1. Store Proceduce:
--1.1 Thêm điểm sinh viên 
CREATE PROCEDURE ThemDiemSinhVien
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

EXEC ThemDiemSinhVien 'SV10', 'MH02', 10, 8, 1, NULL
select * from KETQUA

--1.2 Xóa thông tin điểm của sinh viên theo mã sinh viên, mã môn học và học kỳ
CREATE PROCEDURE XoaDiemSinhVien
   @MaSV char(6), @MaMonHoc	char(6), @HocKy int
AS
BEGIN
   DELETE FROM KETQUA WHERE MASV = @MaSV AND MAMONHOC = @MaMonHoc AND HOCKY = @HocKy
END
GO

EXEC XoaDiemSinhVien 'SV01', 'MH01', 1

--1.3 Sửa thông tin điểm sinh viên
CREATE PROC SuaDiemSinhVien
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

EXEC SuaDiemSinhVien 'SV01','MH01' ,7 ,7 ,1 , NULL
SELECT * FROM KETQUA

--1.4 Hiển thị toàn bộ thông tin điểm của sinh viên
CREATE PROC HienThiDiemSinhVien
AS
BEGIN
   SELECT KETQUA.MASV, SINHVIEN.HOTEN, SINHVIEN.MALOP, KETQUA.MAMONHOC, KETQUA.DIEMQUATRINH, KETQUA.DIEMCUOIKY, KETQUA.DIEMTONGKET,
		  KETQUA.HOCKY, KETQUA.XEPLOAI, KETQUA.GHICHU
   FROM KETQUA, SINHVIEN
   WHERE KETQUA.MASV = SINHVIEN.MASV
END
GO

EXEC HienThiDiemSinhVien

--2. Funtion
--2.1 Tạo Function InThongTinSinhVien theo điểm
CREATE FUNCTION InThongTinSinhVien (@Diem float)
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

-- Thực thi Function
DECLARE @Diem float
SET @Diem = 8.5 -- Điểm sinh viên cần tìm thông tin
SELECT dbo.InThongTinSinhVien(@Diem)

--2.2 Tạo Function để tính tổng điểm của một sinh viên
CREATE FUNCTION TinhTongDiemSinhVien
    (@MaSV nvarchar(10))
RETURNS float
AS
BEGIN
    DECLARE @TongDiem float
    SELECT @TongDiem = SUM(DIEMTONGKET)
    FROM KETQUA
    WHERE MaSV = @MaSV
    RETURN @TongDiem
END
GO

-- Thực thi Function
DECLARE @MaSV nvarchar(10)
SET @MaSV = 'SV01'
SELECT dbo.TinhTongDiemSinhVien(@MaSV)

--3. Trigger:
--3.1 Viết trigger cập nhật xếp loại mỗi khi thực hiện thêm, sửa điểm tổng kết trong bảng KETQUA
CREATE TRIGGER CAPNHATDIEMTONGKET_XEPLOAI
ON KETQUA
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

-- ==========================================================================================================================
--Chức năng thống kê:
--1. Store Proceduce
--1.1. Lấy danh sách sinh viên
create proc SP_lAYDSHS
as
begin
    select * from SINHVIEN
end
go

EXEC SP_lAYDSHS

--1.2. Lấy danh sách môn học 
create proc SP_DSMonHoc
as
begin
    select * from MONHOC
end

GO

EXEC SP_DSMonHoc

--1.3. Thống kê danh sách sinh viên theo học lực và tên môn học 
create proc sp_DSSV
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

EXEC sp_DSSV N'Cơ sở dữ liệu', N'Giỏi'

-----------------------------------------------------SAO LƯU DỮ LIỆU-----------------------------------------------------
--Thực hiện Full Backup
BACKUP DATABASE QLDSV
TO DISK = 'C:\BACKUP_SQL_QLDSV\FullQLDSV.bak'
WITH INIT, DESCRIPTION = 'Backup Database QLDSV'

--Thực hiện Differential Backup
INSERT INTO SINHVIEN VALUES
(N'SV11', N'Nguyễn Anh Vũ', CAST(N'2001-08-19' AS Date), N'Nam', N'Đồng Nai', N'Đang học', N'CNTTD')
BACKUP DATABASE QLDSV
TO DISK = 'C:\BACKUP_SQL_QLDSV\DiffQLDSV.bak'
WITH DIFFERENTIAL

--Thực hiện Log Backup
INSERT INTO SINHVIEN VALUES
(N'SV12', N'Lâm Thị Kim Ngân', CAST(N'2003-04-04' AS Date), N'Nữ', N'Đồng Nai', N'Đang học', N'SPTB')
BACKUP LOG QLDSV
TO DISK = 'C:\BACKUP_SQL_QLDSV\LogQLDSV.trn'

----------------------------------------------------PHỤC HỒI DỮ LIỆU----------------------------------------------------
USE master

DROP DATABASE QLDSV

--Phục hồi dữ liệu từ Full Backup
RESTORE DATABASE QLDSV 
FROM DISK = 'C:\BACKUP_SQL_QLDSV\FullQLDSV.bak'
WITH NORECOVERY

--Phục hồi dữ liệu từ Differential Backup
RESTORE DATABASE QLDSV 
FROM DISK = 'C:\BACKUP_SQL_QLDSV\DiffQLDSV.bak'
WITH NORECOVERY

--Phục hồi dữ liệu từ Log Backup
RESTORE LOG QLDSV 
FROM DISK = 'C:\BACKUP_SQL_QLDSV\LogQLDSV.trn'
WITH RECOVERY

---------------------------------------------------------PHÂN QUYỀN------------------------------------------------------
--1. Tạo tài khoản đăng nhập:
EXEC sp_addlogin 'ADM', '123456', 'QLDSV'
EXEC sp_addlogin 'GV1', '123', 'QLDSV'
EXEC sp_addlogin 'GV2', '123', 'QLDSV'
EXEC sp_addlogin 'GV3', '123', 'QLDSV'
EXEC sp_addlogin 'GV4', '123', 'QLDSV'
EXEC sp_addlogin 'GV5', '123', 'QLDSV'
EXEC sp_addlogin 'GV6', '123', 'QLDSV'
EXEC sp_addlogin 'GV7', '123', 'QLDSV'
EXEC sp_addlogin 'GV8', '123', 'QLDSV'
EXEC sp_addlogin 'GV9', '123', 'QLDSV'
EXEC sp_addlogin 'GV10', '123', 'QLDSV'

--2. Tạo người dùng:
EXEC sp_adduser 'ADM', 'ad'
EXEC sp_adduser 'GV1', 'gv1'
EXEC sp_adduser 'GV2', 'gv2'
EXEC sp_adduser 'GV3', 'gv3'
EXEC sp_adduser 'GV4', 'gv4'
EXEC sp_adduser 'GV5', 'gv5'
EXEC sp_adduser 'GV6', 'gv6'
EXEC sp_adduser 'GV7', 'gv7'
EXEC sp_adduser 'GV8', 'gv8'
EXEC sp_adduser 'GV9', 'gv9'
EXEC sp_adduser 'GV10', 'gv10'

--3. Tạo nhóm quyền:
EXEC sp_addrole 'ADMIN'
EXEC sp_addrole 'GIANGVIEN'

--4. Gán người dùng với nhóm quyền:
EXEC sp_addrolemember 'ADMIN', 'ad' 
EXEC sp_addrolemember 'GIANGVIEN', 'gv1'
EXEC sp_addrolemember 'GIANGVIEN', 'gv2'
EXEC sp_addrolemember 'GIANGVIEN', 'gv3'
EXEC sp_addrolemember 'GIANGVIEN', 'gv4'
EXEC sp_addrolemember 'GIANGVIEN', 'gv5'
EXEC sp_addrolemember 'GIANGVIEN', 'gv6'
EXEC sp_addrolemember 'GIANGVIEN', 'gv7'
EXEC sp_addrolemember 'GIANGVIEN', 'gv8'
EXEC sp_addrolemember 'GIANGVIEN', 'gv9'
EXEC sp_addrolemember 'GIANGVIEN', 'gv10'

--5. Gán quyền cho các nhóm quyền:
--Nhóm quyền ADMIN có các quyền: Xem, thêm, xóa, cập nhật trên bảng DANGNHAP, PHANQUYEN, GIANGVIEN, KETQUA, LOPHOC, MONHOC, SINHVIEN
--								 Xem, thêm, xóa trên bảng GIANGVIEN_DAY_MONHOC
GRANT SELECT, INSERT, UPDATE, DELETE ON DANGNHAP TO ADMIN
GRANT SELECT, INSERT, UPDATE, DELETE ON PHANQUYEN TO ADMIN
GRANT SELECT, INSERT, UPDATE, DELETE ON GIANGVIEN TO ADMIN
GRANT SELECT, INSERT, UPDATE, DELETE ON KETQUA TO ADMIN
GRANT SELECT, INSERT, UPDATE, DELETE ON LOPHOC TO ADMIN
GRANT SELECT, INSERT, UPDATE, DELETE ON MONHOC TO ADMIN
GRANT SELECT, INSERT, UPDATE, DELETE ON SINHVIEN TO ADMIN
GRANT SELECT, INSERT, DELETE ON GIANGVIEN_DAY_MONHOC TO ADMIN

--Nhóm quyền GIANGVIEN có các quyền: Xem trên bảng SINHVIEN
--									 Xem, thêm, xóa, cập nhật trên bảng KETQUA
GRANT SELECT ON SINHVIEN TO GIANGVIEN
GRANT SELECT, INSERT, UPDATE, DELETE ON KETQUA TO GIANGVIEN