create database BTL_QuanLyCuaHangDoAnNhanh
on primary
(
	Name = BTL_QLDAN_DATA,
	Filename = 'D:\C#_Clone\BTL_QLDAN_data.mdf',
	Size = 10MB,
	MaxSize = UNLIMITED,
	Filegrowth = 5MB
)
Log on
(
	Name = BTL_QLDAN_LOG,
	Filename = 'D:\C#_Clone\BTL_QLDAN_log.ldf',
	Size = 5MB,
	MaxSize = UNLIMITED,
	FileGrowth=1MB
)
go
use BTL_QuanLyCuaHangDoAnNhanh
create table nhanvien(
manv varchar(10) not null primary key,    --mã nhân viên
hoten Nvarchar(30),              --họ tên
ngaysinh date,                   --ngày sinh
diachi Nvarchar(30),             --địa chỉ
gioitinh Nvarchar(10),           --giới tính
sodienthoai int)                 --số điện thoại

create table sanpham(
masp varchar(10) not null primary key,    --mã sản phẩm
tensp Nvarchar(30),              --tên sản phẩm
giaban int)                      --giá bán

create table hoadonra(
mahdr varchar(10) not null primary key,   --mã hóa đơn
masp varchar(10),                --mã sản phẩm
soluong int,                     --số lượng
thanhtien int,                   --thành tiền
ngayban date,                    --ngày bán
manv varchar(10) foreign key (manv) references nhanvien(manv))     --mã nhân viên

create table khachhang(
makh varchar(10) primary key not null,                             --mã khách hàng
tenkh Nvarchar(30),                                                --tên khách hàng
diachi Nvarchar(30),                                               --địa chỉ
sdt varchar(10),                                                           --số điện thoại
mahdr varchar(10) foreign key (mahdr) references hoadonra(mahdr))  --mã hóa đơn

create table taikhoan
(
	tentk nvarchar(50) primary key,
	mk nvarchar(50),
	quyen nvarchar(50),
	manv varchar(10) foreign key (manv) references nhanvien(manv)
)

insert into nhanvien values ('NV01',N'vũ mạnh dũng','12/12/1999',N'hà nội','Nam','0123456789')
insert into nhanvien values ('NV02',N'dương thanh khiên','09/01/1998',N'hà nội','Nam','0123456788')
insert into nhanvien values ('NV03',N'nguyễn minh chiều','09/09/1999',N'hải phòng','Nam','012345677')
insert into nhanvien values ('NV04',N'nguyễn tuấn anh','04/30/1997',N'nam định','Nam','0123434367')
insert into nhanvien values ('NV05',N'quế ngọc hải','03/21/1996',N'tuyên quang','Nam','015445677')
insert into nhanvien values ('NV06',N'ngô kim hảo','11/22/1998',N'hà nội',N'Nữ','015445677')
insert into nhanvien values ('NV07',N'đặng thị trang','02/09/1995',N'bắc ninh',N'Nữ','012345457')
insert into nhanvien values ('NV08',N'lê hữu độ','10/14/1993',N'hà nam','Nam','0123457677')
insert into nhanvien values ('NV09',N'nguyễn quỳnh trang','09/23/1999',N'ninh bình',N'Nữ','012345657')
insert into nhanvien values ('NV10',N'ngô văn hải','05/15/1999',N'hòa bình','Nam','012345327')
insert into nhanvien values ('NV11',N'lương xuân trường','08/13/1998',N'hà nội','Nam','012875377')
insert into nhanvien values ('NV12',N'nguyễn ngọc trinh','07/27/1999',N'hải dương',N'Nữ','013958677')
insert into nhanvien values ('NV13',N'mai hồng ngọc','06/11/1996',N'thái nguyên',N'Nữ','012059477')
insert into nhanvien values ('NV14',N'trịnh diệu linh','12/17/1995',N'thanh hóa',N'Nữ','012341538')
insert into nhanvien values ('NV15',N'ngất văn đại','10/19/1997',N'hải phòng','Nam','012384057')
insert into nhanvien values ('NV16',N'đặng văn lâm','11/12/1998',N'thanh hóa','Nam','012874077')
insert into nhanvien values ('NV17',N'nguyễn tiến linh','08/02/1993',N'hà tĩnh','Nam','012003577')
insert into nhanvien values ('NV18',N'hà đức chinh','02/06/1992',N'hà nội','Nam','012346643')
insert into nhanvien values ('NV19',N'nguyễn anh đức','02/09/1994',N'bắc ninh','Nam','012341121')
insert into nhanvien values ('NV20',N'bùi thị hoa','01/08/1993',N'bắc giang',N'Nữ','012399783')
insert into nhanvien values ('NV21',N'chu việt hoàng','06/30/1997',N'hưng yên','Nam','012354287')
insert into nhanvien values ('NV22',N'nguyễn thị ánh viên','05/27/1996',N'hà nội',N'Nữ','012300437')
insert into nhanvien values ('admin',N'lê tú vi','12/03/1999',N'hưng yên',N'Nữ','012874377')

insert into sanpham values ('sp01',N'gà chiên','20000')
insert into sanpham values ('sp02',N'xúc xích rán','10000')
insert into sanpham values ('sp03',N'nem chua','5000')
insert into sanpham values ('sp04',N'bánh mì pate','20000')
insert into sanpham values ('sp05',N'cá viên chiên','30000')
insert into sanpham values ('sp06',N'bánh xèo','10000')
insert into sanpham values ('sp07',N'bánh tráng trộn','15000')
insert into sanpham values ('sp08',N'pizza','40000')
insert into sanpham values ('sp09',N'humberger','50000')
insert into sanpham values ('sp10',N'ốc vặn hấp','20000')
insert into sanpham values ('sp11',N'thịt xiên nướng','19000')
insert into sanpham values ('sp12',N'phở cuốn','10000')
insert into sanpham values ('sp13',N'trứng cút lôn','5000')
insert into sanpham values ('sp14',N'chân gà xả ớt','25000')
insert into sanpham values ('sp15',N'khoai lang kén','9000')
insert into sanpham values ('sp16',N'hotdog','22000')
insert into sanpham values ('sp17',N'chè thập cẩm','12000')
insert into sanpham values ('sp18',N'tào phớ','7000')
insert into sanpham values ('sp19',N'sữa chua mít','15000')
insert into sanpham values ('sp20',N'sữa chua đánh đá','10000')
insert into sanpham values ('sp21',N'coca','6000')
insert into sanpham values ('sp22',N'weakup 247','9000')
insert into sanpham values ('sp23',N'nutri','8000')
insert into sanpham values ('sp24',N'pepsi','7000')
insert into sanpham values ('sp25',N'bia hà nội','12000')
insert into sanpham values ('sp26',N'gà nướng susan','30000')



--------------------------------------------------------------------------------------------------------------
-- hàm tính tổng tiền hóa đơn
