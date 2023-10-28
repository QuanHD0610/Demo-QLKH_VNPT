USE master;
CREATE DATABASE QUANLYKHACHHANG;
USE QUANLYKHACHHANG;

-- Thực thể: KHACHHANG
CREATE TABLE KHACHHANG (
    MaKhachHang NCHAR(10) PRIMARY KEY,
    TenKhachHang NVARCHAR(50),
    NGAYSINH DATETIME,
    GIOITINH NCHAR(10),
    DiaChi NVARCHAR(100),
    SoDienThoai NCHAR(10),
    Email NVARCHAR(100)
);

-- Thực thể: QUYENQUANTRI
CREATE TABLE QUYENQUANTRI (
    MaQuyenQuanTri NCHAR(10) PRIMARY KEY,
    TenQuyenQuanTri NVARCHAR(100)
);

-- Thực thể: NGUOIDUNG
CREATE TABLE NGUOIDUNG (
    MaNguoiDung NCHAR(10) PRIMARY KEY,
    TenDangNhap NVARCHAR(50),
    MatKhau NVARCHAR(30),
    QuyenTruyCap INT,
    MaKhachHang NCHAR(10),
    MaQuyenQuanTri NCHAR(10),
    CONSTRAINT FK_NGUOIDUNG_KHACHHANG FOREIGN KEY (MaKhachHang) REFERENCES KHACHHANG(MaKhachHang),
    CONSTRAINT FK_NGUOIDUNG_QUYENQUANTRI FOREIGN KEY (MaQuyenQuanTri) REFERENCES QUYENQUANTRI(MaQuyenQuanTri)
);

-- Thực thể: KHUYENMAI
CREATE TABLE KHUYENMAI (
    MaKhuyenMai NCHAR(10) PRIMARY KEY,
    NoiDung NVARCHAR(200),
    ThoiGianApDung DATE,
    ThoiGianKetThuc DATE,
    GiamGia FLOAT
);

-- Thực thể: DICHVU
CREATE TABLE DICHVU (
    MaDichVu NCHAR(10) PRIMARY KEY,
    TenDichVu NVARCHAR(100),
    MoTa NVARCHAR(200),
    DonGia FLOAT,
    ThoiHan INT,
    TocDo NVARCHAR(10),
    DungLuong FLOAT,
    MaKhuyenMai NCHAR(10),
    CONSTRAINT FK_DICHVU_KHUYENMAI FOREIGN KEY (MaKhuyenMai) REFERENCES KHUYENMAI(MaKhuyenMai)
);

-- Thực thể: HOADON
CREATE TABLE HOADON (
    MaHoaDon NCHAR(10) PRIMARY KEY,
    MaKhachHang NCHAR(10),
    NgayLap DATETIME,
    NgayHetHan DATETIME,
    TongTien FLOAT,
    CONSTRAINT FK_HOADON_KHACHHANG FOREIGN KEY (MaKhachHang) REFERENCES KHACHHANG(MaKhachHang)
);

-- Thực thể: CHITIETHOADON
CREATE TABLE CHITIETHOADON (
    MaChiTietHoaDon NCHAR(10) PRIMARY KEY,
    MaHoaDon NCHAR(10),
    MaDichVu NCHAR(10),
    SoLuong INT,
    DonGia FLOAT,
    CONSTRAINT FK_CHITIETHOADON_HOADON FOREIGN KEY (MaHoaDon) REFERENCES HOADON(MaHoaDon),
    CONSTRAINT FK_CHITIETHOADON_DICHVU FOREIGN KEY (MaDichVu) REFERENCES DICHVU(MaDichVu)
);

-- Thực thể: BAOTRI
CREATE TABLE BAOTRI (
    MaBaoTri NCHAR(10) PRIMARY KEY,
    MaKhachHang NCHAR(10),
    TieuDe NVARCHAR(200),
    NgayBaoTri DATE,
    MoTa NVARCHAR(200),
    TinhTrang NVARCHAR(50),
    CONSTRAINT FK_BAOTRI_KHACHHANG FOREIGN KEY (MaKhachHang) REFERENCES KHACHHANG(MaKhachHang)
);

-- Thực thể: THANHTOAN
CREATE TABLE THANHTOAN (
    MaGiaoDich NCHAR(10) PRIMARY KEY,
    MaKhachHang NCHAR(10),
    NgayThanhToan DATE,
    SoTien FLOAT,
    PhuongThucThanhToan NVARCHAR(100),
    TinhTrang NVARCHAR(50),
    CONSTRAINT FK_THANHTOAN_KHACHHANG FOREIGN KEY (MaKhachHang) REFERENCES KHACHHANG(MaKhachHang)
);

-- Thực thể: PHANHOI
CREATE TABLE PHANHOI (
    MaPhanHoi NCHAR(10) PRIMARY KEY,
    MaKhachHang NCHAR(10),
    NoiDung NVARCHAR(200),
    NgayGui DATE,
    NoiDungPhanHoi NVARCHAR(200),
    TinhTrang NVARCHAR(50),
    CONSTRAINT FK_PHANHOI_KHACHHANG FOREIGN KEY (MaKhachHang) REFERENCES KHACHHANG(MaKhachHang)
);

--1 Thêm dữ liệu vào bảng KHACHHANG
INSERT INTO KHACHHANG (MaKhachHang, TenKhachHang, NGAYSINH, GIOITINH, DiaChi, SoDienThoai, Email) VALUES
(N'KH001', N'Nguyễn Văn A', '1990-01-15', N'Nam', N'123 Đường ABC, Quận 1, TP.HCM', N'0901234561', N'nguyenvana@email.com'),
(N'KH002', N'Phạm Thị B', '1988-05-20', N'Nữ', N'456 Đường XYZ, Quận 2, TP.HCM', N'0901234562', N'phamthib@email.com'),
(N'KH003', N'Lê Văn C', '1995-09-10', N'Nam', N'789 Đường MNO, Quận 3, TP.HCM', N'0901234563', N'levanc@email.com'),
(N'KH004', N'Hồ Thị D', '1993-02-25', N'Nữ', N'101 Đường PQR, Quận 4, TP.HCM', N'0901234564', N'hothid@email.com'),
(N'KH005', N'Trần Văn E', '1987-07-12', N'Nam', N'202 Đường UVW, Quận 5, TP.HCM', N'0901234565', N'tranvane@email.com'),
(N'KH006', N'Vũ Thị F', '1992-11-30', N'Nữ', N'303 Đường DEF, Quận 6, TP.HCM', N'0901234566', N'vuthif@email.com'),
(N'KH007', N'Hoàng Văn G', '1991-03-18', N'Nam', N'404 Đường GHI, Quận 7, TP.HCM', N'0901234567', N'hoangvang@email.com'),
(N'KH008', N'Nguyễn Thị H', '1997-06-09', N'Nữ', N'505 Đường JKLM, Quận 8, TP.HCM', N'0901234568', N'nguyenthih@email.com'),
(N'KH009', N'Trương Văn I', '1998-12-14', N'Nam', N'606 Đường STU, Quận 9, TP.HCM', N'0901234569', N'truongvani@email.com'),
(N'KH010', N'Bùi Thị K', '1996-08-22', N'Nữ', N'707 Đường XYZ, Quận 10, TP.HCM', N'0901234570', N'buithik@email.com'),
(N'KH011', N'Đặng Văn L', '1994-04-07', N'Nam', N'808 Đường UVW, Quận 11, TP.HCM', N'0901234571', N'dangvanl@email.com'),
(N'KH012', N'Ngô Thị M', '1999-10-28', N'Nữ', N'909 Đường MNO, Quận 12, TP.HCM', N'0901234572', N'gothim@email.com'),
(N'KH013', N'Phan Văn N', '1986-06-14', N'Nam', N'111 Đường PQR, Quận Gò Vấp, TP.HCM', N'0901234573', N'phanvann@email.com'),
(N'KH014', N'Tran Thị P', '1989-12-31', N'Nữ', N'222 Đường DEF, Quận Bình Thạnh, TP.HCM', N'0901234574', N'tranthip@email.com'),
(N'KH015', N'Võ Văn Q', '1984-08-03', N'Nam', N'333 Đường GHI, Quận Tân Phú, TP.HCM', N'0901234575', N'vovanq@email.com'),
(N'KH016', N'Nguyễn Thị R', '1983-11-11', N'Nữ', N'444 Đường JKLM, Quận Tân Bình, TP.HCM', N'0901234576', N'nguyenthir@email.com'),
(N'KH017', N'Lê Văn S', '1982-02-01', N'Nam', N'555 Đường STU, Quận Thủ Đức, TP.HCM', N'0901234577', N'levans@email.com'),
(N'KH018', N'Phạm Thị T', '1981-05-19', N'Nữ', N'666 Đường MNO, Quận 7, TP.HCM', N'0901234578', N'phamthit@email.com'),
(N'KH019', N'Trần Văn U', '1980-09-21', N'Nam', N'777 Đường GHI, Quận 8, TP.HCM', N'0901234579', N'tranvanu@email.com'),
(N'KH020', N'Vũ Thị V', '1979-03-10', N'Nữ', N'888 Đường PQR, Quận 9, TP.HCM', N'0901234580', N'vuthiv@email.com');

--2 Thêm dữ liệu vào bảng QUYENQUANTRI 
INSERT INTO QUYENQUANTRI (MaQuyenQuanTri, TenQuyenQuanTri) VALUES
(N'QQT001', N'Quản lý hệ thống'),
(N'QQT002', N'Quản lý dịch vụ');

--3. Thêm dữ liệu vào bảng NGUOIDUNG:
INSERT INTO NGUOIDUNG (MaNguoiDung, TenDangNhap, MatKhau, QuyenTruyCap, MaKhachHang, MaQuyenQuanTri) VALUES
('ND001', 'admin', 'admin123', 1, 'KH001', 'QQ001'),
('ND002', 'user1', 'pass123', 2, 'KH002', 'QQ002'),
('ND003', 'user2', 'pass123', 2, 'KH003', 'QQ002'),
('ND004', 'user3', 'pass123', 2, 'KH004', 'QQ002'),
('ND005', 'user4', 'pass123', 2, 'KH005', 'QQ002'),
('ND006', 'user5', 'pass123', 2, 'KH006', 'QQ002'),
('ND007', 'user6', 'pass123', 2, 'KH007', 'QQ002'),
('ND008', 'user7', 'pass123', 2, 'KH008', 'QQ002'),
('ND009', 'user8', 'pass123', 2, 'KH009', 'QQ002'),
('ND010', 'user9', 'pass123', 2, 'KH010', 'QQ002'),
('ND011', 'user10', 'pass123', 1, 'KH011', 'QQ002'),
('ND022', 'user11', 'pass123', 2, 'KH012', 'QQ002'),
('ND013', 'user12', 'pass123', 2, 'KH013', 'QQ002'),
('ND014', 'user13', 'pass123', 2, 'KH014', 'QQ002'),
('ND015', 'user14', 'pass123', 2, 'KH015', 'QQ002'),
('ND016', 'user15', 'pass123', 2, 'KH016', 'QQ002'),
('ND017', 'user16', 'pass123', 2, 'KH017', 'QQ002'),
('ND018', 'user17', 'pass123', 2, 'KH018', 'QQ002'),
('ND019', 'user18', 'pass123', 2, 'KH019', 'QQ002'),
('ND020', 'user19', 'pass123', 2, 'KH020', 'QQ002');

--4. Thêm dữ liệu vào bảng KHUYENMAI
INSERT INTO KHUYENMAI (MaKhuyenMai, NoiDung, ThoiGianApDung, ThoiGianKetThuc, GiamGia) VALUES
('KM001', N'Ưu đãi 10% cho gói Internet', '2023-01-01', '2023-12-31', 10),
('KM002', N'Ưu đãi 15% cho gói email doanh nghiệp', '2023-01-01', '2023-12-31', 15),
('KM003', N'Ưu đãi 5% cho gói truyền hình cáp', '2023-01-01', '2023-12-31', 5),
('KM004', N'Khuyến mãi 20% cho gói điện thoại di động', '2023-01-01', '2023-12-31', 20),
('KM005', N'Khuyến mãi 15% cho gói điện thoại cố định', '2023-01-01', '2023-12-31', 15),
('KM006', N'Khuyến mãi 5% cho gói tổng đài tự động', '2023-01-01', '2023-12-31', 5),
('KM007', N'Ưu đãi 10% cho gói truyền hình cáp', '2023-01-01', '2023-12-31', 10),
('KM008', N'Khuyến mãi 20% cho gói lưu trữ dữ liệu', '2023-01-01', '2023-12-31', 20),
('KM009', N'Ưu đãi 10% cho gói lưu trữ dữ liệu', '2023-01-01', '2023-12-31', 10),
('KM010', N'Khuyến mãi 20% cho gói VPN', '2023-01-01', '2023-12-31', 20);

--5. Thêm dữ liệu vào bảng DICHVU
INSERT INTO DICHVU (MaDichVu, TenDichVu, MoTa, DonGia, ThoiHan, TocDo, DungLuong, MaKhuyenMai) VALUES
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

--6. Thêm dữ liệu vào bảng HOADON
INSERT INTO HOADON (MaHoaDon, MaKhachHang, NgayLap, NgayHetHan, TongTien) VALUES
('HD001', 'KH001', '2023-01-01', '2023-01-31', 500000),
('HD002', 'KH002', '2023-02-01', '2023-02-28', 400000),
('HD003', 'KH003', '2023-03-01', '2023-03-31', 300000),
('HD004', 'KH004', '2023-04-01', '2023-04-30', 200000),
('HD005', 'KH005', '2023-05-01', '2023-05-31', 100000),
('HD006', 'KH006', '2023-06-01', '2023-06-30', 600000),
('HD007', 'KH007', '2023-07-01', '2023-07-31', 700000),
('HD008', 'KH008', '2023-08-01', '2023-08-31', 800000),
('HD009', 'KH009', '2023-09-01', '2023-09-30', 900000),
('HD010', 'KH010', '2023-10-01', '2023-10-31', 1000000);

--7. Thêm dữ liệu vào bảng CHITIETHOADON
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

--8. Thêm dữ liệu vào bảng BAOTRI
INSERT INTO BAOTRI (MaBaoTri, MaKhachHang, TieuDe, NgayBaoTri, MoTa, TinhTrang) VALUES
('BT001', 'KH001', N'Kiểm tra và bảo trì hệ thống', '2023-01-15', N'Kiểm tra và bảo trì hệ thống máy chủ', N'Đã xử lý'),
('BT002', 'KH002', N'Kiểm tra và bảo trì thiết bị', '2023-02-10', N'Kiểm tra và bảo trì các thiết bị mạng', N'Chưa xử lý'),
('BT003', 'KH003', N'Kiểm tra và bảo trì mạng', '2023-03-20', N'Kiểm tra và bảo trì mạng dịch vụ', N'Đã xử lý'),
('BT004', 'KH004', N'Kiểm tra và bảo trì dịch vụ', '2023-04-25', N'Kiểm tra và bảo trì các dịch vụ', N'Chưa xử lý'),
('BT005', 'KH005', N'Kiểm tra và bảo trì hệ thống', '2023-05-15', N'Kiểm tra và bảo trì hệ thống máy chủ', N'Đã xử lý'),
('BT006', 'KH006', N'Kiểm tra và bảo trì thiết bị', '2023-06-10', N'Kiểm tra và bảo trì các thiết bị mạng', N'Chưa xử lý'),
('BT007', 'KH007', N'Kiểm tra và bảo trì mạng', '2023-07-20', N'Kiểm tra và bảo trì mạng dịch vụ', N'Đã xử lý'),
('BT008', 'KH008', N'Kiểm tra và bảo trì dịch vụ', '2023-08-25', N'Kiểm tra và bảo trì các dịch vụ', N'Chưa xử lý'),
('BT009', 'KH009', N'Kiểm tra và bảo trì hệ thống', '2023-09-15', N'Kiểm tra và bảo trì hệ thống máy chủ', N'Đã xử lý'),
('BT010', 'KH010', N'Kiểm tra và bảo trì thiết bị', '2023-10-10', N'Kiểm tra và bảo trì các thiết bị mạng', N'Chưa xử lý');


--9. Thêm dữ liệu vào bảng THANHTOAN
INSERT INTO THANHTOAN (MaGiaoDich, MaKhachHang, NgayThanhToan, SoTien, PhuongThucThanhToan, TinhTrang) VALUES
('TT001', 'KH001', '2023-01-05', 500000, N'Thanh toán trực tiếp', N'Đã thanh toán'),
('TT002', 'KH002', '2023-02-05', 400000, N'Thanh toán trực tiếp', N'Đã thanh toán'),
('TT003', 'KH003', '2023-03-05', 300000, N'Thanh toán trực tiếp', N'Đã thanh toán'),
('TT004', 'KH004', '2023-04-05', 200000, N'Thanh toán trực tiếp', N'Đã thanh toán'),
('TT005', 'KH005', '2023-05-05', 100000, N'Thanh toán trực tiếp', N'Đã thanh toán'),
('TT006', 'KH006', '2023-06-05', 600000, N'Thanh toán trực tiếp', N'Đã thanh toán'),
('TT007', 'KH007', '2023-07-05', 700000, N'Thanh toán trực tiếp', N'Đã thanh toán'),
('TT008', 'KH008', '2023-08-05', 800000, N'Thanh toán trực tiếp', N'Đã thanh toán'),
('TT009', 'KH009', '2023-09-05', 900000, N'Thanh toán trực tiếp', N'Đã thanh toán'),
('TT010', 'KH010', '2023-10-05', 1000000, N'Thanh toán trực tiếp', N'Đã thanh toán');

--10. Thêm dữ liệu vào bảng PHANHOI
INSERT INTO PHANHOI (MaPhanHoi, MaKhachHang, NoiDung, NgayGui, NoiDungPhanHoi, TinhTrang) VALUES
('PH001', 'KH001', N'Tôi có một vấn đề về dịch vụ Internet của bạn. Mong bạn giúp đỡ.', '2023-01-05', N'Chúng tôi sẽ kiểm tra và giải quyết vấn đề sớm nhất có thể.', N'Đã xử lý'),
('PH002', 'KH002', N'Tôi muốn biết thêm thông tin về gói truyền hình cáp của bạn.', '2023-02-10', N'Vui lòng gọi số hotline để biết thêm chi tiết.', N'Chưa xử lý'),
('PH003', 'KH003', N'Tôi đang gặp sự cố với dịch vụ điện thoại cố định. Xin hãy kiểm tra và khắc phục.', '2023-03-20', N'Chúng tôi sẽ gửi kỹ thuật viên tới để xử lý sự cố.', N'Chưa xử lý'),
('PH004', 'KH004', N'Tôi muốn thay đổi dịch vụ lưu trữ dữ liệu của mình.', '2023-04-15', N'Vui lòng liên hệ hotline để được hỗ trợ thay đổi dịch vụ.', N'Đã xử lý'),
('PH005', 'KH005', N'Tôi cần hỗ trợ về dịch vụ tổng đài tự động.', '2023-05-18', N'Chúng tôi sẽ hỗ trợ bạn về dịch vụ tổng đài tự động.', N'Đã xử lý'),
('PH006', 'KH006', N'Tôi có vấn đề về tài khoản email doanh nghiệp.', '2023-06-25', N'Vui lòng cung cấp thêm thông tin để chúng tôi hỗ trợ bạn.', N'Chưa xử lý'),
('PH007', 'KH007', N'Tôi muốn biết thêm chi tiết về dịch vụ VPN.', '2023-07-30', N'Chúng tôi sẽ gửi thông tin chi tiết về dịch vụ VPN đến bạn.', N'Đã xử lý'),
('PH008', 'KH008', N'Tôi đang gặp sự cố với gói truyền hình cáp của mình.', '2023-08-12', N'Chúng tôi sẽ gửi kỹ thuật viên tới để kiểm tra sự cố.', N'Chưa xử lý'),
('PH009', 'KH009', N'Tôi cần hỗ trợ về gói điện thoại di động.', '2023-09-25', N'Vui lòng liên hệ hotline để được hỗ trợ về gói điện thoại di động.', N'Đã xử lý'),
('PH010', 'KH010', N'Tôi muốn thay đổi dịch vụ tổng đài tự động của mình.', '2023-10-28', N'Vui lòng cung cấp chi tiết thay đổi dịch vụ.', N'Chưa xử lý');

SELECT * FROM KHACHHANG;
SELECT * FROM QUYENQUANTRI;
SELECT * FROM NGUOIDUNG;
SELECT * FROM KHUYENMAI;
SELECT * FROM DICHVU;
SELECT * FROM HOADON;
SELECT * FROM CHITIETHOADON;
SELECT * FROM BAOTRI;
SELECT * FROM THANHTOAN;
SELECT * FROM PHANHOI;
