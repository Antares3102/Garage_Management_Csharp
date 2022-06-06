﻿use QUANLIGARA
go
insert into HIEUXE(HieuXe) values
('Innova'),
('Honda'),
('Hyundai'),
('Lamborghini'),
('Toyota'),
('Ferrari'),
('Wolkswagen')

USE QUANLIGARA
GO
INSERT INTO PHUTUNG(MaVTPT, TenVTPT, SoLuongTon, DonGia) VALUES
('0',N'Phuộc trước','97','780000'),
('1',N'Phuộc sau','80','530000'),
('2',N'Mâm ép','42','2000000'),
('3',N'Bố ly hợp','85','1950000'),
('4',N'Bố thắng trước','84','1300000'),
('5',N'Bố thắng sau','48','1050000'),
('6',N'Cao su chân máy','0','750000'),
('7',N'Rotuyn lái trong','76','700000'),
('8',N'Máy phát điện','23','7300000'),
('9',N'Đồng hồ taplo innova G','76','240000'),
('10',N'Đồng hồ taplo innova J','26','8500000'),
('11',N'Cảm biến ABS','30','2800000'),
('12',N'Lốc lạnh','50','4500000'),
('13',N'Quạt dàn lạnh','63','1250000'),
('14',N'Dàn lạnh','10','2500000'),
('15',N'Dàn lạnh sau','68','2200000'),
('16',N'Dàn nóng','52','4500000'),
('17',N'Van tiết lưu','62','400000'),
('18',N'Đèn pha','85','4100000'),
('19',N'Đèn lái','89','1100000'),
('20',N'Đèn cản','71','1200000'),
('21',N'Cản trước','25','1200000'),
('22',N'Cửa xe','5','7100000'),
('23',N'Kính chiếu hậu','8','3200000'),
('24',N'Đuôi cá Honda Civic','53','2200000'),
('25',N'Sét gạt mưa Honda Civic','97','460000'),
('26',N'Lọc gió động cơ Honda Civic','78','260000'),
('27',N'Lọc gió','80','1200000'),
('28',N'Lọc nhiên liệu','34','170000'),
('29',N'Láp ngang cầu sau','20','7100000'),
('30',N'Láp dọc đồng bộ','34','20500000'),
('31',N'Cao su chân máy trước','54','900000'),
('32',N'Mâm ép','33','6900000'),
('33',N'Búp sen thắng sau','25','700000'),
('34',N'Ắc quy','57','1970000'),
('35',N'Ba đờ sốc trước','63','1170000'),
('36',N'Lọc nhớt động cơ','34','120000'),
('37',N'Lọc nhớt nhiên liệu','73','170000'),
('38',N'Bộ giảm chấn','8','3750000'),
('39',N'Bạc đạn bánh xe','62','160000'),
('40',N'Bạc đạn trong trục','10','130000'),
('41',N'Gương chiếu hậu','80','320000'),
('42',N'Đèn pha trước','34','1320000'),
('43',N'Đèn hậu','61','480000'),
('44',N'Dây đai trợ lực lái','20','350000'),
('45',N'Bộ bạc đạn ly hợp','94','220000'),
('46',N'Đĩa bộ ly hợp','0','760000'),
('47',N'Bạc thanh truyền dưới','19','370000'),
('48',N'Kính chắn gió','50','1200000'),
('49',N'Kính chắn gió (loại bảo mật)','15','1600000')
insert into TIENCONG(MaTienCong, NoiDung, TienCong) values
('PRE0',N'Công thay dầu máy xe ô tô','50000'),
('PRE1',N'Công thay lọc dầu xe ô tô','50000'),
('PRE2',N'Công thay dầu máy, lọc dầu xe ô tô','80000'),
('PRE3',N'Thay lọc xăng xe ô tô','100000'),
('PRE4',N'Thay lọc xăng thả thùng','200000'),
('PRE5',N'Thay lọc nhiên liệu xe ô tô','50000'),
('PRE6',N'Thay dầu hộp số MT','100000'),
('PRE7',N'Thay dầu hộp số AT (trường hợp đặc biệt tăng không quá 50%)','200000'),
('PRE8',N'Thay chế hòa khí, chỉnh máy','350000'),
('PRE9',N'Thay lọc gió xe ô tô','20000'),
('PRE10',N'Thay bugi xe ô tô','100000'),
('PRE11',N'Công bảo dưỡng mỗi 10.000đ km xe Sedan (không bao gồm vật tư)','200000'),
('PRE12',N'Công bảo dưỡng mỗi 10.000đ km xe SUV (không bao gồm vật tư)','250000'),
('PRE13',N'Công bảo dưỡng mỗi 20.000km xe Sedan (không bao gồm vật tư)','300000'),
('PRE14',N'Công bảo dưỡng mỗi 20.000km xe SUV (không bao gồm vật tư)','450000'),
('PRE15',N'Bảo dưỡng chế hoà khí, chỉnh máy (bao gồm vật liệu bảo dưỡng)','350000'),
('PRE16',N'Bảo dưỡng cụm bướm ga, chỉnh máy (bao gồm vật liệu bảo dưỡng)','300000'),
('PRE17',N'Bảo dưỡng cụm bướm ga, thông súc tu bô, chỉnh máy (bao gồm vật liệu bảo dưỡng)','500000'),
('PRE18',N'Kiểm tra, vệ sinh bugi (trường hợp tháo bugi phức tạp thêm công 100%)','50000'),
('PRE19',N'Bảo dưỡng Delco xe ô tô','100000'),
('PRE20',N'Bảo dưỡng máy phát điện xe ô tô','200000'),
('PRE21',N'Bảo dưỡng máy đề xe ô tô','200000'),
('PRE22',N'Thay nước mát xe ô tô','20000'),
('PRE23',N'Thông súc két nước (không tháo) (bao gồm dung dịch làm sạch)','300000'),
('PRE24',N'Thông súc két nước (tháo két nước ra ngoài)','350000'),
('PRE25',N'Tháo hàn két nước, thông súc','450000'),
('PRE26',N'Tháo lắp kiểm tra kim phun, bơm cao áp (loại bơm không cân)','400000'),
('PRE27',N'Tháo lắp cân kim phun','600000'),
('PRE28',N'Cân bơm cao áp xe ô tô','500000'),
('PRE29',N'Thông súc bình xăng hoặc thùng dầu xe ô tô','350000'),
('PRE30',N'Tăng chỉnh dây curoa ngoài /1 dây','50000'),
('PRE31',N'Tăng chỉnh dây curoa ngoài (3 dây)','100000'),
('PRE32',N'Thay phớt chân bugi (bộ) bao gồm keo gioăng – xe 4 máy chạy chế hoà khí','200000'),
('PRE33',N'Thay phớt chân bugi (bộ) bao gồm keo gioăng – xe 4 máy phun xăng','300000'),
('PRE34',N'Hiệu chỉnh máy V6','1000000'),
('PRE35',N'Thay gioăng nắp supap bao gồm keo gioăng (4 máy)','200000'),
('PRE36',N'Thay gioăng nắp supap bao gồm keo gioăng (máy V), thay cả 2 bên tăng thêm 80%','250000'),
('PRE37',N'Kiểm tra thay dây cao áp','100000'),
('PRE38',N'Bảo dưỡng láp trong (1 bên)','150000'),
('PRE39',N'Bảo dưỡng phanh trước hoặc sau','150000'),
('PRE40',N'Bảo dưỡng moay ơ trước / 1 bánh (xe Sedan)','150000'),
('PRE41',N'Bảo dưỡng moay ơ trước / 1 bánh (xe SUV)','200000'),
('PRE42',N'Bảo dưỡng phanh moay ơ 4 bánh (xe Sedan)','500000'),
('PRE43',N'Bảo dưỡng phanh moay ơ 4 bánh (xe SUV)','600000'),
('PRE44',N'Chỉnh độ chụm, góc đặt bánh xe','150000'),
('PRE45',N'Cân bằng động 1 bánh xe (bao gồm cả kẹp chì)','100000'),
('PRE46',N'Tháo lắp bảo dưỡng hệ thống trục vô lăng lái, căn chỉnh lái','600000'),
('PRE47',N'Tháo lắp hộp số thay bánh răng','1500000'),
('PRE48',N'Tháo lắp thay lá côn hộp số tự động','3000000'),
('PRE49',N'Thay hộp số tự động','800000'),
('FIX0',N'Công thay dầu máy xe ô tô','50000'),
('FIX1',N'Công thay lọc dầu xe ô tô','50000'),
('FIX2',N'Công thay dầu máy, lọc dầu xe ô tô','80000'),
('FIX3',N'Thay lọc xăng xe ô tô','100000'),
('FIX4',N'Thay lọc xăng thả thùng','200000'),
('FIX5',N'Thay lọc nhiên liệu xe ô tô','50000'),
('FIX6',N'Thay dầu hộp số MT','100000'),
('FIX7',N'Thay dầu hộp số AT (trường hợp đặc biệt tăng không quá 50%)','200000'),
('FIX8',N'Thay chế hòa khí, chỉnh máy','350000'),
('FIX9',N'Thay lọc gió xe ô tô','20000'),
('FIX10',N'Thay bugi xe ô tô','100000'),
('FIX11',N'Công bảo dưỡng mỗi 10.000đ km xe Sedan (không bao gồm vật tư)','200000'),
('FIX12',N'Công bảo dưỡng mỗi 10.000đ km xe SUV (không bao gồm vật tư)','250000'),
('FIX13',N'Công bảo dưỡng mỗi 20.000km xe Sedan (không bao gồm vật tư)','300000'),
('FIX14',N'Công bảo dưỡng mỗi 20.000km xe SUV (không bao gồm vật tư)','450000'),
('FIX15',N'Bảo dưỡng chế hoà khí, chỉnh máy (bao gồm vật liệu bảo dưỡng)','350000'),
('FIX16',N'Bảo dưỡng cụm bướm ga, chỉnh máy (bao gồm vật liệu bảo dưỡng)','300000'),
('FIX17',N'Bảo dưỡng cụm bướm ga, thông súc tu bô, chỉnh máy (bao gồm vật liệu bảo dưỡng)','500000'),
('FIX18',N'Kiểm tra, vệ sinh bugi (trường hợp tháo bugi phức tạp thêm công 100%)','50000'),
('FIX19',N'Bảo dưỡng Delco xe ô tô','100000'),
('FIX20',N'Bảo dưỡng máy phát điện xe ô tô','200000'),
('FIX21',N'Bảo dưỡng máy đề xe ô tô','200000'),
('FIX22',N'Thay nước mát xe ô tô','20000'),
('FIX23',N'Thông súc két nước (không tháo) (bao gồm dung dịch làm sạch)','300000'),
('FIX24',N'Thông súc két nước (tháo két nước ra ngoài)','350000'),
('FIX25',N'Tháo hàn két nước, thông súc','450000'),
('FIX26',N'Tháo lắp kiểm tra kim phun, bơm cao áp (loại bơm không cân)','400000'),
('FIX27',N'Tháo lắp cân kim phun','600000'),
('FIX28',N'Cân bơm cao áp xe ô tô','500000'),
('FIX29',N'Thông súc bình xăng hoặc thùng dầu xe ô tô','350000'),
('FIX30',N'Tăng chỉnh dây curoa ngoài /1 dây','50000'),
('FIX31',N'Tăng chỉnh dây curoa ngoài (3 dây)','100000'),
('FIX32',N'Thay phớt chân bugi (bộ) bao gồm keo gioăng – xe 4 máy chạy chế hoà khí','200000'),
('FIX33',N'Thay phớt chân bugi (bộ) bao gồm keo gioăng – xe 4 máy phun xăng','300000'),
('FIX34',N'Hiệu chỉnh máy V6','1000000'),
('FIX35',N'Thay gioăng nắp supap bao gồm keo gioăng (4 máy)','200000'),
('FIX36',N'Thay gioăng nắp supap bao gồm keo gioăng (máy V), thay cả 2 bên tăng thêm 80%','250000'),
('FIX37',N'Kiểm tra thay dây cao áp','100000'),
('FIX38',N'Bảo dưỡng láp trong (1 bên)','150000'),
('FIX39',N'Bảo dưỡng phanh trước hoặc sau','150000'),
('FIX40',N'Bảo dưỡng moay ơ trước / 1 bánh (xe Sedan)','150000'),
('FIX41',N'Bảo dưỡng moay ơ trước / 1 bánh (xe SUV)','200000'),
('FIX42',N'Bảo dưỡng phanh moay ơ 4 bánh (xe Sedan)','500000'),
('FIX43',N'Bảo dưỡng phanh moay ơ 4 bánh (xe SUV)','600000'),
('FIX44',N'Chỉnh độ chụm, góc đặt bánh xe','150000'),
('FIX45',N'Cân bằng động 1 bánh xe (bao gồm cả kẹp chì)','100000'),
('FIX46',N'Tháo lắp bảo dưỡng hệ thống trục vô lăng lái, căn chỉnh lái','600000'),
('FIX47',N'Tháo lắp hộp số thay bánh răng','1500000'),
('FIX48',N'Tháo lắp thay lá côn hộp số tự động','3000000'),
('FIX49',N'Thay hộp số tự động','800000'),
('CT0',N'Công thay dầu máy xe ô tô','50000'),
('CT1',N'Công thay lọc dầu xe ô tô','50000'),
('CT2',N'Công thay dầu máy, lọc dầu xe ô tô','80000'),
('CT3',N'Thay lọc xăng xe ô tô','100000'),
('CT4',N'Thay lọc xăng thả thùng','200000'),
('CT5',N'Thay lọc nhiên liệu xe ô tô','50000'),
('CT6',N'Thay dầu hộp số MT','100000'),
('CT7',N'Thay dầu hộp số AT (trường hợp đặc biệt tăng không quá 50%)','200000'),
('CT8',N'Thay chế hòa khí, chỉnh máy','350000'),
('CT9',N'Thay lọc gió xe ô tô','20000'),
('CT10',N'Thay bugi xe ô tô','100000'),
('CT11',N'Công bảo dưỡng mỗi 10.000đ km xe Sedan (không bao gồm vật tư)','200000'),
('CT12',N'Công bảo dưỡng mỗi 10.000đ km xe SUV (không bao gồm vật tư)','250000'),
('CT13',N'Công bảo dưỡng mỗi 20.000km xe Sedan (không bao gồm vật tư)','300000'),
('CT14',N'Công bảo dưỡng mỗi 20.000km xe SUV (không bao gồm vật tư)','450000'),
('CT15',N'Bảo dưỡng chế hoà khí, chỉnh máy (bao gồm vật liệu bảo dưỡng)','350000'),
('CT16',N'Bảo dưỡng cụm bướm ga, chỉnh máy (bao gồm vật liệu bảo dưỡng)','300000'),
('CT17',N'Bảo dưỡng cụm bướm ga, thông súc tu bô, chỉnh máy (bao gồm vật liệu bảo dưỡng)','500000'),
('CT18',N'Kiểm tra, vệ sinh bugi (trường hợp tháo bugi phức tạp thêm công 100%)','50000'),
('CT19',N'Bảo dưỡng Delco xe ô tô','100000'),
('CT20',N'Bảo dưỡng máy phát điện xe ô tô','200000'),
('CT21',N'Bảo dưỡng máy đề xe ô tô','200000'),
('CT22',N'Thay nước mát xe ô tô','20000'),
('CT23',N'Thông súc két nước (không tháo) (bao gồm dung dịch làm sạch)','300000'),
('CT24',N'Thông súc két nước (tháo két nước ra ngoài)','350000'),
('CT25',N'Tháo hàn két nước, thông súc','450000'),
('CT26',N'Tháo lắp kiểm tra kim phun, bơm cao áp (loại bơm không cân)','400000'),
('CT27',N'Tháo lắp cân kim phun','600000'),
('CT28',N'Cân bơm cao áp xe ô tô','500000'),
('CT29',N'Thông súc bình xăng hoặc thùng dầu xe ô tô','350000'),
('CT30',N'Tăng chỉnh dây curoa ngoài /1 dây','50000'),
('CT31',N'Tăng chỉnh dây curoa ngoài (3 dây)','100000'),
('CT32',N'Thay phớt chân bugi (bộ) bao gồm keo gioăng – xe 4 máy chạy chế hoà khí','200000'),
('CT33',N'Thay phớt chân bugi (bộ) bao gồm keo gioăng – xe 4 máy phun xăng','300000'),
('CT34',N'Hiệu chỉnh máy V6','1000000'),
('CT35',N'Thay gioăng nắp supap bao gồm keo gioăng (4 máy)','200000'),
('CT36',N'Thay gioăng nắp supap bao gồm keo gioăng (máy V), thay cả 2 bên tăng thêm 80%','250000'),
('CT37',N'Kiểm tra thay dây cao áp','100000'),
('CT38',N'Bảo dưỡng láp trong (1 bên)','150000'),
('CT39',N'Bảo dưỡng phanh trước hoặc sau','150000'),
('CT40',N'Bảo dưỡng moay ơ trước / 1 bánh (xe Sedan)','150000'),
('CT41',N'Bảo dưỡng moay ơ trước / 1 bánh (xe SUV)','200000'),
('CT42',N'Bảo dưỡng phanh moay ơ 4 bánh (xe Sedan)','500000'),
('CT43',N'Bảo dưỡng phanh moay ơ 4 bánh (xe SUV)','600000'),
('CT44',N'Chỉnh độ chụm, góc đặt bánh xe','150000'),
('CT45',N'Cân bằng động 1 bánh xe (bao gồm cả kẹp chì)','100000'),
('CT46',N'Tháo lắp bảo dưỡng hệ thống trục vô lăng lái, căn chỉnh lái','600000'),
('CT47',N'Tháo lắp hộp số thay bánh răng','1500000'),
('CT48',N'Tháo lắp thay lá côn hộp số tự động','3000000'),
('CT49',N'Thay hộp số tự động','800000'),
('CT50',N'Thay bi hộp số hoặc ruột hộp số','2000000'),
('CT51',N'Thay láp ngoài / 1 bên','200000'),
('CT52',N'Thay láp trong / 1 bên','200000'),
('CT53',N'Thay láp cả cây','200000'),
('CT54',N'Thay phớt láp','100000'),
('CT55',N'Thay bi moay ơ trước hoặc cụm bi /1 bên','150000'),
('CT56',N'Thay bi moay ơ sau hoặc cụm bi /1 bên','150000')

insert into XE(Bienso, Hieuxe, TenChuXe, DiaChi, DienThoai, NgayTiepNhan, TienNo) values
('72F-48539','Innova',N'Lày A Cẩu',N'Quận Bình Thạnh, TP.HCM','982527982','2022-05-05 00:00:00','7800000'),
('88G-91668','Innova',N'Bùi Mạnh Quốc Huy',N'Quận Bình Thạnh, TP.HCM','973776072','2022-05-05 00:00:00','530000'),
('21A-22382','Innova',N'Lê Thị Mai',N'Quận Bình Thạnh, TP.HCM','917749254','2022-05-05 00:00:00','2000000'),
('77H-86543','Innova',N'Trần Kim Ngọc',N'Quận Gò Vấp, TP.HCM','904770053','2022-05-05 00:00:00','1950000'),
('41A-61395','Innova',N'Lai Như Quỳnh',N'Quận 2, TP.HCM','974880788','2022-05-05 00:00:00','1300000'),
('74E-31587','Innova',N'Đặng Ngọc Thanh Loan',N'Quận 2, TP.HCM','983888611','2022-05-05 00:00:00','1050000'),
('27B-81356','Innova',N'Đặng Ngọc Thanh Loan',N'Phường Thắng Tam, TP. Vũng Tàu','984603663','2022-05-05 00:00:00','750000')

INSERT INTO NHANVIEN VALUES('Tuan', '123', N'Tuấn', '123', '@', 'TPHCM', N'Quản lý')