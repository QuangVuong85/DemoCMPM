USE CNPM_QLPhongKham
GO

INSERT INTO dbo.DichVuCLS
(MaDichVu, TenDichVu, DonGia)
VALUES
('CLS1', N'Đo khúc xạ giác mạc Javal', 34000),
('CLS2', N'HIV Ab test nhanh', 52000),
('CLS3', N'Điện tim thường', 45000),
('CLS4', N'Nội soi thực quản - Dạ dày - Tá tràng cấp cứu', 231000),
('CLS5', N'Chụp Xquang', 234000),
('CLS6', N'Đo thị giác 2 mắt', 60000),
('CLS7', N'Siêu âm các tuyến nước bọt', 49000),
('CLS8', N'Siêu âm tuyến giáp', 59000),
('CLS9', N'Siêu âm ổ bụng', 434000)
GO

INSERT INTO dbo.Thuoc
(MaThuoc, TenThuoc, DuongDung, DVT, DonGia
)
VALUES
('1', N'Meloxicam', N'Uống', N'Viên', 2000),
('2', N'Diclofenac', N'Uống', N'Viên', 3000),
('3', N'Loratadin', N'Uống', N'Viên', 5000),
('4', N'Prednisolon', N'Uống', N'Viên', 7000),
('5', N'Viabiovit', N'Tiêm', N'Ống', 12000)
GO

INSERT INTO dbo.NhanVien
(MaNhanVien, TenNhanVien, NgaySinh, GioiTinh, DiaChi, SDT, HocHam, HocVi)
VALUES
('',        -- MaNhanVien - varchar(10)
    N'',       -- TenNhanVien - nvarchar(100)
    GETDATE(), -- NgaySinh - date
    N'',       -- GioiTinh - nvarchar(20)
    N'',       -- DiaChi - nvarchar(100)
    '',        -- SDT - varchar(20)
    N'',       -- HocHam - nvarchar(50)
    N''        -- HocVi - nvarchar(50)
)
GO

INSERT INTO dbo.TaiKhoan
(MaTaiKhoan, TenDangNhap, MatKhau, VaiTro, MaNhanVien)
VALUES
(0,    -- MaTaiKhoan - int
    N'',  -- TenDangNhap - nvarchar(50)
    N'',  -- MatKhau - nvarchar(50)
    NULL, -- VaiTro - bit
    ''    -- MaNhanVien - varchar(10)
)
GO

INSERT INTO	dbo.ThanNhan
(MaThanNhan,TenThanNhan,CMND,SDT)
VALUES
('1', N'Trần Văn A', '164618311', '096415888'),
('2', N'Nguyễn Thị B', '164618322', '096888668')
GO

INSERT dbo.BenhNhan
(MaBenhNhan,TenBenhNhan,NgaySinh,DiaChi,GioiTinh,CMND,MaThanNhan)
VALUES
('1', N'Đào Thị An', '11-12-1990', N'Hòa Bình', N'Nam', '161235489', '1'),
('2', N'Nguyễn Văn Minh', '01-01-1992', N'Hà Nội', N'Nữ', '151503669', '2')
GO

