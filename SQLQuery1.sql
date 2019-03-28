create database Staff



create table Specialties
(
	Id int primary key identity,
	SpecName varchar(30)
);

insert into Specialties values ('Programmer'), ('Designer'), ('System administrator')

create table Workers
(
	Id int primary key identity,
	Surname varchar(20),
	FirsnName varchar(20),
	Lastlame varchar(20),
	Gender bit,
	[Address] varchar(30),
	Phone varchar(15),
	BirthDate date,
	SpecialtyId int foreign key references Specialties(Id),
	Salary varchar(10),
	ImgFile varchar(100),
	IsDeleted bit default 0
);

insert into Workers values ('Skorichenko', 'Daniel', 'Genadievich', 1, 'Lermontova 105', '+380503040328', '19991001', 1, '14000', 'Skorichenko.jpg', 0)
insert into Workers values ('Kumaransky', 'Maxim', 'Urievich', 1, 'Geroiv ATO 1488', '+380501289411', '20000427', 3, '12000', 'Kumaransky.jpg', 0)
insert into Workers values ('Ogur', 'Arina', 'Vladimirovna', 0, 'Unaya 13', '+380994050598', '20020612', 2, '9000', 'Ogur.jpg', 0)


create table Users 
(
	Id int primary key identity,
	Lgn varchar(20),
	Pwd varchar(20)
);

insert into Users values ('director', 'qwerty123') -- read only
insert into Users values ('admin', 'volodya_hlebov15') -- read and write

create table [Certificates]
(
	Id int primary key identity,
	CompanyName varchar(60),
	[Description] varchar(60)
);



insert into [Certificates] values ('html academy', 'Design web-interfaces via html è css')
insert into [Certificates] values ('html academy', 'Server-side part of web-application php')
insert into [Certificates] values ('Photoshop master', 'Intermediate web-designer')
insert into [Certificates] values ('Design for everyone', 'Awesome skills (Adobe Il)')
insert into [Certificates] values ('CISCO', 'Professional Routing and Switching')
insert into [Certificates] values ('Retratech', 'Linux system administrator')

create table StaffandCertificates
(
	Id int primary key identity,
	WorkerId int foreign key references Workers(Id),
	CertificateId int foreign key references [Certificates](Id)
);

create LOGIN Director WITH PASSWORD = '123'
USE Staff
CREATE USER Daniel FOR LOGIN Director

ALTER ROLE db_datareader ADD MEMBER Daniel

drop LOGIN [Admin] WITH PASSWORD = '123'

drop USER Ivan FOR LOGIN [Admin]

ALTER ROLE db_owner ADD MEMBER Ivan

ALTER LOGIN [Admin] ENABLE

uSE MASTER

GO

CREATE LOGIN Admin WITH PASSWORD='123', DEFAULT_DATABASE = MASTER

GO

ALTER LOGIN Admin ENABLE

GO


USE Staff

GO

CREATE USER Ivan FOR LOGIN Admin WITH DEFAULT_SCHEMA = [DBO]

GO