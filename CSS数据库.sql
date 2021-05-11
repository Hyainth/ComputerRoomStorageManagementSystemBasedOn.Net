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

Create Table users   --�û���
(
	userID varchar(10) primary key,
	password varchar(100) not null,
	loginInfo varchar(200)
)

Create Table Machine   --�豸��
(
	roomID varchar(10) not null,
	seatID varchar(10) not null,
	device varchar(200) not null,
	state varchar(10) not null,
	useInfo varchar(200),
	constraint pk_name primary key (roomID,seatID)
)

Create Table OrderList   --������
(
	orderID varchar(10) primary key,
	supID varchar(10) not null,
	empID varchar(10) not null,
	partsInfo varchar(200),
	date varchar(30) not null,
	state varchar(10) not null,
	total float
)


Create Table Supplier   --��Ӧ�̱�
(
	supID varchar(10) primary key,
	name varchar(10) not null,
	area varchar(20) not null,
	telephone varchar(20) not null
)

Create Table Employees   --Ա����
(
	empID varchar(10) primary key,
	name varchar(10) not null,
	salary float not null,
	post varchar(10) not null,
	sex varchar(2),
	telephone varchar(20)
)

Create Table Parts    --�����
(
	PartID varchar(10) primary key,
	name varchar(30) not null,
	type varchar(10) not null,
	price float,
	info varchar(200)
)

Create Table Warehouse   --�ֿ��
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

INSERT INTO Machine VALUES ('0001','0001','0001|0002|0004','����','inforoom1')
INSERT INTO Machine VALUES ('0001','0002','0001|0002|0004','�ػ�','inforoom1')
INSERT INTO Machine VALUES ('0001','0003','0001|0002|0004','����','inforoom1')
INSERT INTO Machine VALUES ('0001','0004','0001|0002|0004','ά��','inforoom1')
INSERT INTO Machine VALUES ('0001','0005','0001|0002|0004','����','inforoom1')
INSERT INTO Machine VALUES ('0001','0006','0001|0002|0004','�ػ�','inforoom1')
INSERT INTO Machine VALUES ('0001','0007','0001|0002|0004','ά��','inforoom1')
INSERT INTO Machine VALUES ('0001','0008','0001|0002|0004','�ػ�','inforoom1')
INSERT INTO Machine VALUES ('0001','0009','0001|0002|0004','����','inforoom1')
INSERT INTO Machine VALUES ('0001','0010','0001|0002|0004','�ػ�','inforoom1')
INSERT INTO Machine VALUES ('0001','0011','0001|0002|0004','����','inforoom1')
INSERT INTO Machine VALUES ('0001','0012','0001|0002|0004','�ػ�','inforoom1')
INSERT INTO Machine VALUES ('0001','0013','0001|0002|0004','�ػ�','inforoom1')
INSERT INTO Machine VALUES ('0001','0014','0001|0002|0004','�ػ�','inforoom1')
INSERT INTO Machine VALUES ('0001','0015','0001|0002|0004','����','inforoom1')
INSERT INTO Machine VALUES ('0001','0016','0001|0002|0004','����','inforoom1')
INSERT INTO Machine VALUES ('0001','0017','0001|0002|0004','����','inforoom1')
INSERT INTO Machine VALUES ('0001','0018','0001|0002|0004','����','inforoom1')
INSERT INTO Machine VALUES ('0001','0019','0001|0002|0004','�ػ�','inforoom1')
INSERT INTO Machine VALUES ('0001','0020','0001|0002|0004','����','inforoom1')
INSERT INTO Machine VALUES ('0001','0021','0001|0002|0004','�ػ�','inforoom1')
INSERT INTO Machine VALUES ('0001','0022','0001|0002|0004','�ػ�','inforoom1')
INSERT INTO Machine VALUES ('0001','0023','0001|0002|0004','�ػ�','inforoom1')
INSERT INTO Machine VALUES ('0001','0024','0001|0002|0004','����','inforoom1')
INSERT INTO Machine VALUES ('0001','0025','0001|0002|0004','�ػ�','inforoom1')
INSERT INTO Machine VALUES ('0001','0026','0001|0002|0004','�ػ�','inforoom1')

INSERT INTO Machine VALUES ('0002','0001','0001|0002|0005','����','inforoom2')
INSERT INTO Machine VALUES ('0002','0002','0001|0002|0005','����','inforoom2')
INSERT INTO Machine VALUES ('0002','0003','0003|0005','�ػ�','inforoom3')
INSERT INTO Machine VALUES ('0002','0004','0003|0005','�ػ�','inforoom3')
INSERT INTO Machine VALUES ('0002','0005','0003|0005','�ػ�','inforoom3')
INSERT INTO Machine VALUES ('0002','0006','0003|0005','�ػ�','inforoom3')
INSERT INTO Machine VALUES ('0002','0007','0003|0005','�ػ�','inforoom3')
INSERT INTO Machine VALUES ('0002','0008','0003|0005','ά��','inforoom3')
INSERT INTO Machine VALUES ('0002','0009','0008|0007','�ػ�','inforoom3')

INSERT INTO Machine VALUES ('0003','0001','0003|0005','�ػ�','inforoom3')
INSERT INTO Machine VALUES ('0003','0002','0003|0005','����','inforoom3')
INSERT INTO Machine VALUES ('0003','0003','0003|0005','�ػ�','inforoom3')
INSERT INTO Machine VALUES ('0003','0004','0003|0005','�ػ�','inforoom3')
INSERT INTO Machine VALUES ('0003','0005','0003|0005','�ػ�','inforoom3')
INSERT INTO Machine VALUES ('0003','0006','0003|0005','�ػ�','inforoom3')
INSERT INTO Machine VALUES ('0003','0007','0003|0005','�ػ�','inforoom3')
INSERT INTO Machine VALUES ('0003','0008','0003|0005','ά��','inforoom3')
INSERT INTO Machine VALUES ('0003','0009','0008|0007','�ػ�','inforoom3')
INSERT INTO Machine VALUES ('0003','0010','0003|0005','�ػ�','inforoom3')
INSERT INTO Machine VALUES ('0003','0011','0003|0005','�ػ�','inforoom3')
INSERT INTO Machine VALUES ('0003','0012','0003|0005','�ػ�','inforoom3')
INSERT INTO Machine VALUES ('0003','0013','0003|0005','�ػ�','inforoom3')
INSERT INTO Machine VALUES ('0003','0014','0003|0005','�ػ�','inforoom3')
INSERT INTO Machine VALUES ('0003','0015','0003|0005','�ػ�','inforoom3')
INSERT INTO Machine VALUES ('0003','0016','0003|0005','�ػ�','inforoom3')
INSERT INTO Machine VALUES ('0003','0017','0003|0005','ά��','inforoom3')
INSERT INTO Machine VALUES ('0003','0018','0008|0007','�ػ�','inforoom3')

INSERT INTO Supplier VALUES ('0001','����','JD location','137XXXXXXXX')
INSERT INTO Supplier VALUES ('0002','�Ա�','taobao location','135XXXXXXXX')
INSERT INTO Supplier VALUES ('0003','����Ͱ�','1688 location','173XXXXXXXX')
INSERT INTO Supplier VALUES ('0004','����ѷ','Amazon location','152XXXXXXXX')

INSERT INTO Employees VALUES ('0001','Admin',5000,'�ܹ���Ա','��','152XXXXXXXX')
INSERT INTO Employees VALUES ('0002','��һ',2000,'�ֿ����Ա','Ů','172XXXXXXXX')
INSERT INTO Employees VALUES ('0003','��С��',10000,'�ֿ����Ա','Ů','186XXXXXXXX')
INSERT INTO Employees VALUES ('0004','�����',5000,'�ɹ�����Ա','��','185XXXXXXXX')
INSERT INTO Employees VALUES ('0005','������',5500,'�ɹ�����Ա','Ů','135XXXXXXXX')


INSERT INTO Parts(PartID,name,type,price,info) VALUES ('0001','Corsair K95RGB�����','����',1749,'���̺����� (USCORSAIR) K95 RGB PLATINUM ��е���� �òʱ��� ��ɫ����')
INSERT INTO Parts(PartID,name,type,price,info) VALUES ('0002','�޼�G-pro Wireless','����',899,'�޼� (G) PRO LIGHTSPEED ����/������Ϸ��� ������� RGB��')
INSERT INTO Parts(PartID,name,type,price,info) VALUES ('0003','ATH-MSR7SE','����',2880,'Audio Technica������ATH-MSR7��Яͷ��ʽHIFI�������� ATH-MSR7SE')
INSERT INTO Parts(PartID,name,type,price,info) VALUES ('0004','ROG PG27UQ��ʾ��','��ʾ��',19999,'��˶��ASUS��PG27UQ ROG��ҹ��� 27Ӣ��4K��ʾ�� HDR���ӵ�144Hz G-SYNC IPS �羺Һ����ʾ����DP/HDMI��')
INSERT INTO Parts(PartID,name,type,price,info) VALUES ('0005','Acer�Ӷ���X34P','��ʾ��',7499,'�곞��Acer���Ӷ���X34P 34Ӣ��120Hzˢ��G-Sync����IPS���ӽ�100%sRGB����羺��ʾ����DP+HDMI+�������䣩')
INSERT INTO Parts(PartID,name,type,price,info) VALUES ('0006','�߲ʺ�RTX2080TI����','�Կ�',11999,'�߲ʺ磨Colorful��iGame GeForce RTX 2080Ti Vulcan X OC GDDR6 11G�羺��Ϸ�Կ�')
INSERT INTO Parts(PartID,name,type,price,info) VALUES ('0007','Intel I7-9700K','CPU',3499,'Ӣ�ض���Intel�� i7-9700K ��˺� ��װCPU������')
INSERT INTO Parts(PartID,name,type,price,info) VALUES ('0008','AMD ���� 7 2700X','CPU',2599,'AMD ���� 7 2700X ������ (r7) 8��16�߳� AM4 �ӿ� 3.7GHz ��װCPU')
INSERT INTO Parts(PartID,name,type,price,info) VALUES ('0009','MSI Z370 GAMING PRO CARBON','����',1599,'΢�ǣ�MSI��Z370 GAMING PRO CARBON AC����WIFI ���壨Intel Z370/LGA 1151��')
INSERT INTO Parts(PartID,name,type,price,info) VALUES ('0010','Corsair RM650x','��Դ',899,'���̺�������USCorsair���650W RM650x ȫģ����Ե�Դ��80PLUS����/������ /ʮ���ʱ�/ȫ��ϵ���ݣ�')

INSERT INTO Warehouse VALUES ('0001','�����','�㽭ʡ������걺���XXX·XX��','XXL','0001|200,0002|3,0003|3')
INSERT INTO Warehouse VALUES ('0002','��ʾ����','�㽭ʡ������¹����XXX·XX��','XL','0001|1,0004|2,0005|10')
INSERT INTO Warehouse VALUES ('0003','оƬ��','�㽭ʡ������������XXX·XX��','L','0006|2,0007|5,0008|4')
INSERT INTO Warehouse VALUES ('0004','�����','�㽭ʡ�����ж�ͷ��XXX·XX��','L','0009|5,0010|5')

INSERT INTO OrderList VALUES ('0001','0001','0004','0001|2|1699,0002|3|849,0003|3|2799','2018/5/5','δ���',14342)
INSERT INTO OrderList VALUES ('0002','0002','0004','0004|15|22222,0005|6|12220','2018/6/1','δ���',105998)
INSERT INTO OrderList VALUES ('0003','0003','0005','0006|2|11999,0007|5|3399,0008|4|2299','2018/11/11','�����',50189)
INSERT INTO OrderList VALUES ('0004','0004','0005','0009|5|1399,0010|5|899','2018/11/11','�����',11490)

select * from Warehouse

select * from users

select * from OrderList

select * from Machine



