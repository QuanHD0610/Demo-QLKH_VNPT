use master 
CREATE DATABASE QUANLYKHACHHANG
USE QUANLYKHACHHANG

GO
--1 Thực thể: KHACHHANG
CREATE TABLE KHACHHANG (
    MaKhachHang CHAR(5) PRIMARY KEY,
    TenKhachHang NVARCHAR(50),
	NGAYSINH	DATETIME,
	GIOITINH	NCHAR(10),
    DiaChi NVARCHAR(100),
    SoDienThoai CHAR(10),
    Email NVARCHAR(100)
);
select*from khachhang
GO
--2 Thực thể: QUYENQUANTRI
CREATE TABLE QUYENQUANTRI (
    MaQuyenQuanTri CHAR(5) PRIMARY KEY,
    TenQuyenQuanTri NVARCHAR(100)
);
--3 Thực thể: NGUOIDUNG
CREATE TABLE NGUOIDUNG (
    MaNguoiDung CHAR(5) PRIMARY KEY,
    TenDangNhap NVARCHAR(50),
    MatKhau NVARCHAR(30),
    QuyenTruyCap INT,
    MaKhachHang CHAR(5),
	MaQuyenQuanTri CHAR(5),
    CONSTRAINT FK_NGUOIDUNG_KHACHHANG FOREIGN KEY (MaKhachHang) REFERENCES KHACHHANG(MaKhachHang),
	CONSTRAINT FK_NGUOIDUNG_QUYENQUANTRI FOREIGN KEY (MaQuyenQuanTri) REFERENCES QUYENQUANTRI(MaQuyenQuanTri)
);
--4 Thực thể: KHUYENMAI
CREATE TABLE KHUYENMAI (
    MaKhuyenMai CHAR(5) PRIMARY KEY,
    NoiDung NVARCHAR(200),
    ThoiGianApDung DATE,
    ThoiGianKetThuc DATE,
	GiamGia FLOAT
);
--5 Thực thể: DICHVU
CREATE TABLE DICHVU (
    MaDichVu CHAR(5) PRIMARY KEY,
    TenDichVu NVARCHAR(100),
    MoTa NVARCHAR(200),
    DonGia FLOAT,
    ThoiHan INT,
    TocDo NVARCHAR(10),
    DungLuong FLOAT ,
	MaKhuyenMai CHAR(5),
	CONSTRAINT FK_DICHVU_KHUYENMAI FOREIGN KEY (MaKhuyenMai) REFERENCES KHUYENMAI(MaKhuyenMai)
);

--6 Thực thể: HOADON
CREATE TABLE HOADON (
    MaHoaDon CHAR(5) PRIMARY KEY,
    MaKhachHang CHAR(5),
    NgayLap DATE,
    TongTien FLOAT,
    CONSTRAINT FK_HOADON_KHACHHANG FOREIGN KEY (MaKhachHang) REFERENCES KHACHHANG(MaKhachHang)
);

--7 Thực thể: CHITIETHOADON
CREATE TABLE CHITIETHOADON (
    MaChiTietHoaDon CHAR(5) PRIMARY KEY,
    MaHoaDon CHAR(5),
    MaDichVu CHAR(5),
    SoLuong INT,
    DonGia FLOAT,
    CONSTRAINT FK_CHITIETHOADON_HOADON FOREIGN KEY (MaHoaDon) REFERENCES HOADON(MaHoaDon),
    CONSTRAINT FK_CHITIETHOADON_DICHVU FOREIGN KEY (MaDichVu) REFERENCES DICHVU(MaDichVu)
);

--8 Thực thể: BAOTRI
CREATE TABLE BAOTRI (
    MaBaoTri CHAR(5) PRIMARY KEY,
    MaKhachHang CHAR(5),
    NgayBaoTri DATE,
    MoTa NVARCHAR(200),
    CONSTRAINT FK_BAOTRI_KHACHHANG FOREIGN KEY (MaKhachHang) REFERENCES KHACHHANG(MaKhachHang)
);


--9 Thực thể: THANHTOAN
CREATE TABLE THANHTOAN (
    MaGiaoDich CHAR(5) PRIMARY KEY,
    MaKhachHang CHAR(5),
    NgayThanhToan DATE,
    SoTien FLOAT,
    PhuongThucThanhToan NVARCHAR(100),
    CONSTRAINT FK_THANHTOAN_KHACHHANG FOREIGN KEY (MaKhachHang) REFERENCES KHACHHANG(MaKhachHang)
);

--10 Thực thể: PHANHOI
CREATE TABLE PHANHOI (
    MaPhanHoi CHAR(5) PRIMARY KEY,
    MaKhachHang CHAR(5),
    NoiDung NVARCHAR(200),
    NgayGui DATE,
    TrangThai INT,
    CONSTRAINT FK_PHANHOI_KHACHHANG FOREIGN KEY (MaKhachHang) REFERENCES KHACHHANG(MaKhachHang)
);




--1. Thêm dữ liệu vào bảng KHACHHANG:
INSERT INTO KHACHHANG (MaKhachHang, TenKhachHang, DiaChi, SoDienThoai, Email) VALUES
(N'KH001', N'Nguyễn Văn A', N'Hà Nội', N'0123456789', N'nguyenvana@gmail.com'),
(N'KH002', N'Trần Thị B', N'Hồ Chí Minh', N'0987654321', N'tranthib@gmail.com'),
(N'KH003', N'Lê Văn C', N'Đà Nẵng', N'0369852147', N'levanc@gmail.com'),
(N'KH004', N'Phạm Thị D', N'Hải Phòng', N'0912345678', N'phamthid@gmail.com'),
(N'KH005', N'Nguyễn Thị E', N'Cần Thơ', N'0987654321', N'nguyenthe@gmail.com'),
(N'KH006', N'Trần Văn F', N'Hà Nội', N'0369852147', N'tranvanf@gmail.com'),
(N'KH007', N'Lê Thị G', N'Hồ Chí Minh', N'0912345678', N'lethig@gmail.com'),
(N'KH008', N'Phạm Văn H', N'Đà Nẵng', N'0123456789', N'phamvanh@gmail.com'),
(N'KH009', N'Nguyễn Thị I', N'Hải Phòng', N'0987654321', N'nguyenthii@gmail.com'),
(N'KH010', N'Trần Văn J', N'Cần Thơ', N'0369852147', N'tranvanj@gmail.com');

--2. Thêm dữ liệu vào bảng QUYENQUANTRI:
INSERT INTO QUYENQUANTRI (MaQuyenQuanTri, TenQuyenQuanTri) VALUES
(N'QQ001', N'Quản trị viên'),
(N'QQ002', N'Người dùng'),
(N'QQ003', N'Nhân viên bảo trì'),
(N'QQ004', N'Nhân viên kinh doanh'),
(N'QQ005', N'Nhân viên hỗ trợ khách hàng'),
(N'QQ006', N'Nhân viên tài chính'),
(N'QQ007', N'Nhân viên marketing'),
(N'QQ008', N'Nhân viên phát triển sản phẩm'),
(N'QQ009', N'Nhân viên dịch vụ khách hàng'),
(N'QQ010', N'Nhân viên chăm sóc khách hàng');

--3. Thêm dữ liệu vào bảng DICHVU:
INSERT INTO DICHVU (MaDichVu, TenDichVu, MoTa, DonGia, ThoiHan, TocDo, DungLuong,MaKhuyenMai) VALUES
('DV001', N'Gói Internet cá nhân', N'Gói cung cấp dịch vụ Internet cho cá nhân', 200000, 30, N'100Mbps', 100,'KM001'),
('DV002', N'Gói Internet doanh nghiệp', N'Gói cung cấp dịch vụ Internet cho doanh nghiệp', 500000, 30, N'200Mbps', 200,'KM001'),
('DV003', N'Gói truyền hình cáp', N'Gói cung cấp dịch vụ truyền hình cáp', 300000, 30, '', 0,'KM007'),
('DV004', N'Gói điện thoại cố định', N'Gói cung cấp dịch vụ điện thoại cố định', 100000, 30, '', 0,'KM005'),
('DV005', N'Gói điện thoại di động', N'Gói cung cấp dịch vụ điện thoại di động', 150000, 30, '', 0,'KM005'),
('DV006', N'Gói tổng đài tự động', N'Gói cung cấp dịch vụ tổng đài tự động', 400000, 30, '', 0,'KM007'),
('DV007', N'Gói lưu trữ dữ liệu', N'Gói cung cấp dịch vụ lưu trữ dữ liệu', 250000, 30, '', 500,'KM009'),
('DV008', N'Gói email doanh nghiệp', N'Gói cung cấp dịch vụ email doanh nghiệp', 200000, 30, '', 0,'KM002'),
('DV009', N'Gói VPN', N'Gói cung cấp dịch vụ mạng riêng ảo', 300000, 30, '', 0,'KM010'),
('DV010', N'Gói dịch vụ khác', N'Gói cung cấp các dịch vụ khác', 0, 30, '', 0,'KM001');

--4. Thêm dữ liệu vào bảng HOADON:
INSERT INTO HOADON (MaHoaDon, MaKhachHang, NgayLap, TongTien) VALUES
('HD001', 'KH001', '2021-01-01', 500000),
('HD002', 'KH002', '2021-02-01', 400000),
('HD003', 'KH003', '2021-03-01', 300000),
('HD004', 'KH004', '2021-04-01', 200000),
('HD005', 'KH005', '2021-05-01', 100000),
('HD006', 'KH006', '2021-06-01', 600000),
('HD007', 'KH007', '2021-07-01', 700000),
('HD008', 'KH008', '2021-08-01', 800000),
('HD009', 'KH009', '2021-09-01', 900000),
('HD010', 'KH010', '2021-10-01', 1000000);

--5. Thêm dữ liệu vào bảng CHITIETHOADON:
INSERT INTO CHITIETHOADON (MaChiTietHoaDon, MaHoaDon, MaDichVu, SoLuong, DonGia) VALUES
('CT001', 'HD001', 'DV001', 1, 200000),
('CT002', 'HD002', 'DV002', 1, 500000),
('CT003', 'HD003', 'DV003', 1, 300000),
('CT004', 'HD004', 'DV004', 1, 100000),
('CT005', 'HD005', 'DV005', 1, 150000),
('CT006', 'HD006', 'DV006', 1, 400000),
('CT007', 'HD007', 'DV007', 1, 250000),
('CT008', 'HD008', 'DV008', 1, 200000),
('CT009', 'HD009', 'DV009', 1, 300000),
('CT010', 'HD010', 'DV010', 1, 0);

--6. Thêm dữ liệu vào bảng BAOTRI:
INSERT INTO BAOTRI (MaBaoTri, MaKhachHang, NgayBaoTri, MoTa) VALUES
('BT001', N'KH001', '2021-01-01', N'Kiểm tra và bảo trì hệ thống'),
('BT002', N'KH002', '2021-02-01', N'Kiểm tra và bảo trì thiết bị'),
('BT003', N'KH003', '2021-03-01', N'Kiểm tra và bảo trì mạng'),
('BT004', N'KH004', '2021-04-01', N'Kiểm tra và bảo trì dịch vụ'),
('BT005', N'KH005', '2021-05-01', N'Kiểm tra và bảo trì hệ thống'),
('BT006', N'KH006', '2021-06-01', N'Kiểm tra và bảo trì thiết bị'),
('BT007', N'KH007', '2021-07-01', N'Kiểm tra và bảo trì mạng'),
('BT008', N'KH008', '2021-08-01', N'Kiểm tra và bảo trì dịch vụ'),
('BT009', N'KH009', '2021-09-01', N'Kiểm tra và bảo trì hệ thống'),
('BT010', N'KH010', '2021-10-01', N'Kiểm tra và bảo trì thiết bị');

--7. Thêm dữ liệu vào bảng NGUOIDUNG:
INSERT INTO NGUOIDUNG (MaNguoiDung, TenDangNhap, MatKhau, QuyenTruyCap, MaKhachHang,MaQuyenQuanTri) VALUES
('ND001', 'admin', 'admin123', 1, 'KH001','QQ001'),
('ND002', 'user1', 'pass123', 2, 'KH002','QQ002'),
('ND003', 'user2', 'pass123', 2, 'KH003','QQ002'),
('ND004', 'user3', 'pass123', 2, 'KH004','QQ002'),
('ND005', 'user4', 'pass123', 2, 'KH005','QQ002'),
('ND006', 'user5', 'pass123', 2, 'KH006','QQ002'),
('ND007', 'user6', 'pass123', 2, 'KH007','QQ002'),
('ND008', 'user7', 'pass123', 2, 'KH008','QQ002'),
('ND009', 'user8', 'pass123', 2, 'KH009','QQ002'),
('ND010', 'user9', 'pass123', 2, 'KH010','QQ002');

--8. Thêm dữ liệu vào bảng THANHTOAN:
INSERT INTO THANHTOAN (MaGiaoDich, MaKhachHang, NgayThanhToan, SoTien) VALUES
('TT001', 'KH001', '2021-01-01', 1000000),
('TT002', 'KH002', '2021-02-01', 1500000),
('TT003', 'KH003', '2021-03-01', 800000),
('TT004', 'KH004', '2021-04-01', 1200000),
('TT005', 'KH005', '2021-05-01', 900000),
('TT006', 'KH006', '2021-06-01', 1100000),
('TT007', 'KH007', '2021-07-01', 1300000),
('TT008', 'KH008', '2021-08-01', 950000),
('TT009', 'KH009', '2021-09-01', 750000),
('TT010', 'KH010', '2021-10-01', 1400000);

--9. Thêm dữ liệu vào bảng PHANHOI:
INSERT INTO PHANHOI (MaPhanHoi, MaKhachHang, NoiDung, NgayGui, TrangThai) VALUES
('PH001', N'KH001', N'Tôi có một vấn đề về dịch vụ Internet của bạn. Mong bạn giúp đỡ.', '2021-01-01', N''),
('PH002', N'KH002', N'Tôi muốn biết thêm thông tin về gói truyền hình cáp của bạn.', '2021-02-01', N''),
('PH003', N'KH003', N'Tôi đang gặp sự cố với dịch vụ điện thoại cố định. Xin hãy kiểm tra và khắc phục.', '2021-03-01', N''),
('PH004', N'KH004', N'Tôi cần hỗ trợ về việc gia hạn dịch vụ của mình.', '2021-04-01', N''),
('PH005', N'KH005', N'Tôi muốn biết thêm thông tin về gói tổng đài tự động của bạn.', '2021-05-01', N''),
('PH006', N'KH006', N'Tôi gặp sự cố với truyền hình cáp. Xin hãy kiểm tra và khắc phục.', '2021-06-01', N''),
('PH007', N'KH007', N'Tôi cần hỗ trợ về việc đăng ký gói Internet cao cấp.', '2021-07-01', N''),
('PH008', N'KH008', N'Tôi muốn biết thêm thông tin về dịch vụ điện thoại cố định.', '2021-08-01', N''),
('PH009', N'KH009', N'Tôi cần hỗ trợ về việc thanh toán hóa đơn.', '2021-09-01', N''),
('PH010', N'KH010', N'Tôi muốn biết thêm chính sách khuyến mãi hiện có.', '2021-10-01', N'');

--10. Thêm dữ liệu vào bảng KHUYENMAI:
INSERT INTO KHUYENMAI (MaKhuyenMai, NoiDung, ThoiGianApDung,ThoiGianKetThuc,GiamGia) VALUES
('KM001', N'Giảm giá 20% cho gói Internet cao cấp', '2021-01-01', '2021-02-01',0.2),
('KM002', N'Miễn phí lắp đặt truyền hình cáp', '2021-02-01', '2021-03-01',0.2),
('KM003', N'Giảm giá 10% cho dịch vụ điện thoại cố định', '2021-03-01', '2021-04-01',0.10),
('KM004', N'Tặng thêm 1 tháng sử dụng khi gia hạn dịch vụ', '2021-04-01', '2021-05-01',1),
('KM005', N'Giảm giá 15% cho gói tổng đài tự động', '2021-05-01', '2021-06-01',0.15),
('KM006', N'Miễn phí cài đặt dịch vụ Internet', '2021-06-01', '2021-07-01',0),
('KM007', N'Giảm giá 30% cho dịch vụ truyền hình cáp', '2021-07-01', '2021-08-01',0.30),
('KM008', N'Tặng thêm 2 tháng sử dụng khi gia hạn dịch vụ', '2021-08-01', '2021-09-01',2),
('KM009', N'Giảm giá 25% cho gói tổng đài tự động', '2021-09-01', '2021-10-01',0.25),
('KM010', N'Miễn phí cài đặt dịch vụ truyền hình cáp', '2021-10-01', '2021-11-01',0);

--1. Lệnh SELECT cho bảng KHACHHANG:
SELECT * FROM KHACHHANG;

--2. Lệnh SELECT cho bảng QUYENQUANTRI:
SELECT * FROM QUYENQUANTRI;

--3. Lệnh SELECT cho bảng DICHVU:
SELECT * FROM DICHVU;

--4. Lệnh SELECT cho bảng HOADON:
SELECT * FROM HOADON;

--5. Lệnh SELECT cho bảng CHITIETHOADON:
SELECT * FROM CHITIETHOADON;

--6. Lệnh SELECT cho bảng BAOTRI:
SELECT * FROM BAOTRI;

--7. Lệnh SELECT cho bảng NGUOIDUNG:
SELECT * FROM NGUOIDUNG;

--8. Lệnh SELECT cho bảng THANHTOAN:
SELECT * FROM THANHTOAN;

--9. Lệnh SELECT cho bảng PHANHOI:
SELECT * FROM PHANHOI;

--10. Lệnh SELECT cho bảng KHUYENMAI:
SELECT * FROM KHUYENMAI;