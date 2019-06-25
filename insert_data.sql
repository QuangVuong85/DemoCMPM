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


