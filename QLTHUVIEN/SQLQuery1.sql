ALTER TABLE chitietmuon
ADD PRIMARY KEY (maphieu, masach);
ALTER TABLE chitietmuon
ADD FOREIGN KEY (maphieu) REFERENCES phieumuon(maphieu);
ALTER TABLE chitietmuon
ADD FOREIGN KEY (masach) REFERENCES sach(masach);
ALTER TABLE sach
ADD FOREIGN KEY (matheloai) REFERENCES theloai(matheloai);
ALTER TABLE sach
ADD FOREIGN KEY (matg) REFERENCES tacgia(matg);
ALTER TABLE sach
ADD FOREIGN KEY (manxb) REFERENCES nhaxb(manxb);
ALTER TABLE phieumuon
ADD FOREIGN KEY (madg) REFERENCES docgia(madg);
ALTER TABLE phieumuon
ADD FOREIGN KEY (manv) REFERENCES nhanvien(manv);
INSERT INTO docgia (madg, hoten, ngaysinh, gioitinh, lop)
VALUES 
(N'DG001', N'Nguyễn Văn A', '1990-01-01', N'Nam', N'12A1'),
(N'DG002', N'Trần Thị B', '1992-05-15', N'Nữ', N'12A2'),
(N'DG003', N'Hoàng Văn C', '1988-09-20', N'Nam', N'11A3'),
(N'DG004', N'Lê Thị D', '1991-11-30', N'Nữ', N'11A1'),
(N'DG005', N'Phạm Văn E', '1993-07-08', N'Nam', N'12A4');
INSERT INTO nhanvien (manv, hoten, ngaysinh, gioitinh, diachi, dienthoai)
VALUES 
(N'NV001', N'Nguyễn Văn X', '1985-03-20', N'Nam', N'Huế', N'0123456789'),
(N'NV002', N'Trần Thị Y', '1990-06-25', N'Nữ', N'Đà Nẵng', N'0987654321'),
(N'NV003', N'Hoàng Văn Z', '1987-12-10', N'Nam', N'Quảng Nam', N'0369871245'),
(N'NV004', N'Lê Thị T', '1995-02-15', N'Nữ', N'Huế', N'0369871245'),
(N'NV005', N'Phạm Văn K', '1989-08-05', N'Nam', N'Đà Nẵng', N'0369871245');
INSERT INTO nhaxb (manxb, tennxb, diachi, dienthoai)
VALUES 
(N'NXB001', N'Nhà Xuất Bản Trẻ', N'Huế', N'0123456789'),
(N'NXB002', N'Nhà Xuất Bản Kim Đồng', N'Đà Nẵng', N'0987654321'),
(N'NXB003', N'Nhà Xuất Bản Hồng Đức', N'Quảng Nam', N'0369871245'),
(N'NXB004', N'Nhà Xuất Bản Giáo Dục', N'Huế', N'0369871245'),
(N'NXB005', N'Nhà Xuất Bản Trẻ', N'Đà Nẵng', N'0369871245');
INSERT INTO phieumuon (maphieu, madg, manv)
VALUES 
(N'PM001', N'DG001', N'NV001'),
(N'PM002', N'DG002', N'NV002'),
(N'PM003', N'DG003', N'NV003'),
(N'PM004', N'DG004', N'NV004'),
(N'PM005', N'DG005', N'NV005');
INSERT INTO sach (masach, tensach, matheloai, matg, manxb, namxb)
VALUES 
(N'S001', N'Cấu Trúc Dữ Liệu Giải Thuật', N'TL001', N'TG001', N'NXB001', N'2010'),
(N'S002', N'Doraemon', N'TL003', N'TG002', N'NXB002', N'2012'),
(N'S003', N'Hai Số Phận', N'TL001', N'TG003', N'NXB003', N'2015'),
(N'S004', N'Toán Cao Cấp A3', N'TL002', N'TG004', N'NXB004', N'2018'),
(N'S005', N'Bố Già(1972)', N'TL001', N'TG005', N'NXB005', N'2020');
INSERT INTO tacgia (matg, tentacgia)
VALUES 
(N'TG001', N'Nguyễn Trung Dũng'),
(N'TG002', N'Nguyễn Gia Bảo'),
(N'TG003', N'Trần Quốc Hưng'),
(N'TG004', N'Phạm Phú Hoà'),
(N'TG005', N'Nguyễn An Khang');
INSERT INTO theloai (matheloai, tentheloai)
VALUES 
(N'TL001', N'Tiểu Thuyết'),
(N'TL002', N'Giáo Trình'),
(N'TL003', N'Truyện Tranh');
INSERT INTO chitietmuon (maphieu, masach, ngaymuon, ngaytra, ghichu)
VALUES 
(N'PM001', N'S001', '2024-03-01', '2024-03-15', N'Ghi chú 1'),
(N'PM002', N'S002', '2024-03-02', '2024-03-16', N'Ghi chú 2'),
(N'PM003', N'S003', '2024-03-03', '2024-03-17', N'Ghi chú 3'),
(N'PM004', N'S004', '2024-03-04', '2024-03-18', N'Ghi chú 4'),
(N'PM005', N'S005', '2024-03-05', '2024-03-19', N'Ghi chú 5');

