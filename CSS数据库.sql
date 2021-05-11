USE master
GO
IF EXISTS(SELECT * FROM sysdatabases WHERE name='CSS')
   DROP DATABASE CSS
GO
create database CSS
on 
(
	name=CSS_data,
	filename='D:\DB\CSS_data.mdf',
	size=5MB,
	maxsize=15MB,
	filegrowth=1MB
)
log on
(
	name='CSS_log',
	filename='D:\DB\CSS_log.ldf',
	size=5MB,
	maxsize=10,
	filegrowth=10%
)
GO

Use CSS
go

Create Table users   --用户表
(
	userID varchar(10) primary key,
	password varchar(100) not null,
	loginInfo varchar(200)
)

Create Table Machine   --设备表
(
	roomID varchar(10) not null,
	seatID varchar(10) not null,
	device varchar(200) not null,
	state varchar(10) not null,
	useInfo varchar(200),
	constraint pk_name primary key (roomID,seatID)
)

Create Table OrderList   --订单表
(
	orderID varchar(10) primary key,
	supID varchar(10) not null,
	empID varchar(10) not null,
	partsInfo varchar(200),
	date varchar(30) not null,
	state varchar(10) not null,
	total float
)


Create Table Supplier   --供应商表
(
	supID varchar(10) primary key,
	name varchar(10) not null,
	area varchar(20) not null,
	telephone varchar(20) not null
)

Create Table Employees   --员工表
(
	empID varchar(10) primary key,
	name varchar(10) not null,
	salary float not null,
	post varchar(10) not null,
	sex varchar(2),
	telephone varchar(20)
)

Create Table Parts    --货物表
(
	PartID varchar(10) primary key,
	name varchar(30) not null,
	type varchar(10) not null,
	price float,
	info varchar(200)
)

Create Table Warehouse   --仓库表
(
	houseID varchar(10) primary key,
	name varchar(10) not null,
	position varchar(50) not null,
	size varchar(5) not null,
	storageInfo varchar(200)
)



INSERT INTO users VALUES ('0001','e10adc3949ba59abbe56e057f20f883e','2018-12-20  15:04:16|\images\A0001.jpg')
INSERT INTO users VALUES ('0002','e10adc3949ba59abbe56e057f20f883e','2018-12-20  15:04:16|\images\A0002.jpg')
INSERT INTO users VALUES ('0003','e10adc3949ba59abbe56e057f20f883e','2018-12-20  15:04:16|\images\A0003.jpg')
INSERT INTO users VALUES ('0004','e10adc3949ba59abbe56e057f20f883e','2018-12-20  15:04:16|\images\A0004.jpg')
INSERT INTO users VALUES ('0005','e10adc3949ba59abbe56e057f20f883e','2018-12-20  15:04:16|\images\A0005.jpg')

INSERT INTO Machine VALUES ('0001','0001','0001|0002|0004','开机','inforoom1')
INSERT INTO Machine VALUES ('0001','0002','0001|0002|0004','关机','inforoom1')
INSERT INTO Machine VALUES ('0001','0003','0001|0002|0004','开机','inforoom1')
INSERT INTO Machine VALUES ('0001','0004','0001|0002|0004','维修','inforoom1')
INSERT INTO Machine VALUES ('0001','0005','0001|0002|0004','待机','inforoom1')
INSERT INTO Machine VALUES ('0001','0006','0001|0002|0004','关机','inforoom1')
INSERT INTO Machine VALUES ('0001','0007','0001|0002|0004','维修','inforoom1')
INSERT INTO Machine VALUES ('0001','0008','0001|0002|0004','关机','inforoom1')
INSERT INTO Machine VALUES ('0001','0009','0001|0002|0004','待机','inforoom1')
INSERT INTO Machine VALUES ('0001','0010','0001|0002|0004','关机','inforoom1')
INSERT INTO Machine VALUES ('0001','0011','0001|0002|0004','待机','inforoom1')
INSERT INTO Machine VALUES ('0001','0012','0001|0002|0004','关机','inforoom1')
INSERT INTO Machine VALUES ('0001','0013','0001|0002|0004','关机','inforoom1')
INSERT INTO Machine VALUES ('0001','0014','0001|0002|0004','关机','inforoom1')
INSERT INTO Machine VALUES ('0001','0015','0001|0002|0004','开机','inforoom1')
INSERT INTO Machine VALUES ('0001','0016','0001|0002|0004','待机','inforoom1')
INSERT INTO Machine VALUES ('0001','0017','0001|0002|0004','开机','inforoom1')
INSERT INTO Machine VALUES ('0001','0018','0001|0002|0004','待机','inforoom1')
INSERT INTO Machine VALUES ('0001','0019','0001|0002|0004','关机','inforoom1')
INSERT INTO Machine VALUES ('0001','0020','0001|0002|0004','开机','inforoom1')
INSERT INTO Machine VALUES ('0001','0021','0001|0002|0004','关机','inforoom1')
INSERT INTO Machine VALUES ('0001','0022','0001|0002|0004','关机','inforoom1')
INSERT INTO Machine VALUES ('0001','0023','0001|0002|0004','关机','inforoom1')
INSERT INTO Machine VALUES ('0001','0024','0001|0002|0004','待机','inforoom1')
INSERT INTO Machine VALUES ('0001','0025','0001|0002|0004','关机','inforoom1')
INSERT INTO Machine VALUES ('0001','0026','0001|0002|0004','关机','inforoom1')

INSERT INTO Machine VALUES ('0002','0001','0001|0002|0005','待机','inforoom2')
INSERT INTO Machine VALUES ('0002','0002','0001|0002|0005','待机','inforoom2')
INSERT INTO Machine VALUES ('0002','0003','0003|0005','关机','inforoom3')
INSERT INTO Machine VALUES ('0002','0004','0003|0005','关机','inforoom3')
INSERT INTO Machine VALUES ('0002','0005','0003|0005','关机','inforoom3')
INSERT INTO Machine VALUES ('0002','0006','0003|0005','关机','inforoom3')
INSERT INTO Machine VALUES ('0002','0007','0003|0005','关机','inforoom3')
INSERT INTO Machine VALUES ('0002','0008','0003|0005','维修','inforoom3')
INSERT INTO Machine VALUES ('0002','0009','0008|0007','关机','inforoom3')

INSERT INTO Machine VALUES ('0003','0001','0003|0005','关机','inforoom3')
INSERT INTO Machine VALUES ('0003','0002','0003|0005','开机','inforoom3')
INSERT INTO Machine VALUES ('0003','0003','0003|0005','关机','inforoom3')
INSERT INTO Machine VALUES ('0003','0004','0003|0005','关机','inforoom3')
INSERT INTO Machine VALUES ('0003','0005','0003|0005','关机','inforoom3')
INSERT INTO Machine VALUES ('0003','0006','0003|0005','关机','inforoom3')
INSERT INTO Machine VALUES ('0003','0007','0003|0005','关机','inforoom3')
INSERT INTO Machine VALUES ('0003','0008','0003|0005','维修','inforoom3')
INSERT INTO Machine VALUES ('0003','0009','0008|0007','关机','inforoom3')
INSERT INTO Machine VALUES ('0003','0010','0003|0005','关机','inforoom3')
INSERT INTO Machine VALUES ('0003','0011','0003|0005','关机','inforoom3')
INSERT INTO Machine VALUES ('0003','0012','0003|0005','关机','inforoom3')
INSERT INTO Machine VALUES ('0003','0013','0003|0005','关机','inforoom3')
INSERT INTO Machine VALUES ('0003','0014','0003|0005','关机','inforoom3')
INSERT INTO Machine VALUES ('0003','0015','0003|0005','关机','inforoom3')
INSERT INTO Machine VALUES ('0003','0016','0003|0005','关机','inforoom3')
INSERT INTO Machine VALUES ('0003','0017','0003|0005','维修','inforoom3')
INSERT INTO Machine VALUES ('0003','0018','0008|0007','关机','inforoom3')

INSERT INTO Supplier VALUES ('0001','京东','JD location','137XXXXXXXX')
INSERT INTO Supplier VALUES ('0002','淘宝','taobao location','135XXXXXXXX')
INSERT INTO Supplier VALUES ('0003','阿里巴巴','1688 location','173XXXXXXXX')
INSERT INTO Supplier VALUES ('0004','亚马逊','Amazon location','152XXXXXXXX')

INSERT INTO Employees VALUES ('0001','Admin',5000,'总管理员','男','152XXXXXXXX')
INSERT INTO Employees VALUES ('0002','郁一',2000,'仓库管理员','女','172XXXXXXXX')
INSERT INTO Employees VALUES ('0003','郁小杰',10000,'仓库管理员','女','186XXXXXXXX')
INSERT INTO Employees VALUES ('0004','郁大杰',5000,'采购管理员','男','185XXXXXXXX')
INSERT INTO Employees VALUES ('0005','郁三杰',5500,'采购管理员','女','135XXXXXXXX')


INSERT INTO Parts(PartID,name,type,price,info) VALUES ('0001','Corsair K95RGB铂金版','外设',1749,'美商海盗船 (USCORSAIR) K95 RGB PLATINUM 机械键盘 幻彩背光 黑色茶轴')
INSERT INTO Parts(PartID,name,type,price,info) VALUES ('0002','罗技G-pro Wireless','外设',899,'罗技 (G) PRO LIGHTSPEED 有线/无线游戏鼠标 无线鼠标 RGB鼠')
INSERT INTO Parts(PartID,name,type,price,info) VALUES ('0003','ATH-MSR7SE','外设',2880,'Audio Technica铁三角ATH-MSR7便携头戴式HIFI耳机耳麦 ATH-MSR7SE')
INSERT INTO Parts(PartID,name,type,price,info) VALUES ('0004','ROG PG27UQ显示器','显示器',19999,'华硕（ASUS）PG27UQ ROG玩家国度 27英寸4K显示屏 HDR量子点144Hz G-SYNC IPS 电竞液晶显示器（DP/HDMI）')
INSERT INTO Parts(PartID,name,type,price,info) VALUES ('0005','Acer掠夺者X34P','显示器',7499,'宏碁（Acer）掠夺者X34P 34英寸120Hz刷新G-Sync技术IPS广视角100%sRGB曲面电竞显示器（DP+HDMI+内置音箱）')
INSERT INTO Parts(PartID,name,type,price,info) VALUES ('0006','七彩虹RTX2080TI火神','显卡',11999,'七彩虹（Colorful）iGame GeForce RTX 2080Ti Vulcan X OC GDDR6 11G电竞游戏显卡')
INSERT INTO Parts(PartID,name,type,price,info) VALUES ('0007','Intel I7-9700K','CPU',3499,'英特尔（Intel） i7-9700K 酷睿八核 盒装CPU处理器')
INSERT INTO Parts(PartID,name,type,price,info) VALUES ('0008','AMD 锐龙 7 2700X','CPU',2599,'AMD 锐龙 7 2700X 处理器 (r7) 8核16线程 AM4 接口 3.7GHz 盒装CPU')
INSERT INTO Parts(PartID,name,type,price,info) VALUES ('0009','MSI Z370 GAMING PRO CARBON','主板',1599,'微星（MSI）Z370 GAMING PRO CARBON AC暗黑WIFI 主板（Intel Z370/LGA 1151）')
INSERT INTO Parts(PartID,name,type,price,info) VALUES ('0010','Corsair RM650x','电源',899,'美商海盗船（USCorsair）额定650W RM650x 全模组电脑电源（80PLUS金牌/低噪音 /十年质保/全日系电容）')

INSERT INTO Warehouse VALUES ('0001','外设仓','浙江省温州市瓯海区XXX路XX号','XXL','0001|200,0002|3,0003|3')
INSERT INTO Warehouse VALUES ('0002','显示器仓','浙江省温州市鹿城区XXX路XX号','XL','0001|1,0004|2,0005|10')
INSERT INTO Warehouse VALUES ('0003','芯片仓','浙江省温州市龙湾区XXX路XX号','L','0006|2,0007|5,0008|4')
INSERT INTO Warehouse VALUES ('0004','配件仓','浙江省温州市洞头区XXX路XX号','L','0009|5,0010|5')

INSERT INTO OrderList VALUES ('0001','0001','0004','0001|2|1699,0002|3|849,0003|3|2799','2018/5/5','未入库',14342)
INSERT INTO OrderList VALUES ('0002','0002','0004','0004|15|22222,0005|6|12220','2018/6/1','未入库',105998)
INSERT INTO OrderList VALUES ('0003','0003','0005','0006|2|11999,0007|5|3399,0008|4|2299','2018/11/11','已入库',50189)
INSERT INTO OrderList VALUES ('0004','0004','0005','0009|5|1399,0010|5|899','2018/11/11','已入库',11490)

select * from Warehouse

select * from users

select * from OrderList

select * from Machine



