create database Staff

create table [dbo].[Certificates] (
    [Id] [int] not null identity,
    [CompanyName] [varchar](60) null,
    [Description] [varchar](60) null,
    primary key ([Id])
);
create table [dbo].[Specialties] (
    [Id] [int] not null identity,
    [SpecName] [varchar](30) null,
    primary key ([Id])
);
create table [dbo].[StaffandCertificates] (
    [Id] [int] not null identity,
    [WorkerId] [int] null,
    [CertificateId] [int] null,
    primary key ([Id])
);
create table [dbo].[Users] (
    [Id] [int] not null identity,
    [Lgn] [varchar](20) null,
    [Pwd] [varchar](20) null,
    primary key ([Id])
);
create table [dbo].[Workers] (
    [Id] [int] not null identity,
    [Surname] [varchar](20) null,
    [Firstname] [varchar](20) null,
    [Lastname] [varchar](20) null,
    [Gender] [bit] null,
    [Address] [varchar](30) null,
    [Phone] [varchar](15) null,
    [BirthDate] [date] null,
    [SpecialtyId] [int] null,
    [Salary] [int] null,
    [ImgFile] [varchar](100) null,
    [IsDeleted] [bit] null,
    primary key ([Id])
);
alter table [dbo].[StaffandCertificates] add constraint [FK__StaffandC__Certi__1CF15040] foreign key ([CertificateId]) references [dbo].[Certificates]([Id]);
alter table [dbo].[StaffandCertificates] add constraint [FK__StaffandC__Worke__1BFD2C07] foreign key ([WorkerId]) references [dbo].[Workers]([Id]);
alter table [dbo].[Workers] add constraint [FK__Workers__Special__1273C1CD] foreign key ([SpecialtyId]) references [dbo].[Specialties]([Id]);

insert into Users values ('director', '123') 
insert into Users values ('admin', '123') 

insert into Specialties values ('Programmer'), ('Designer'), ('System administrator')

insert into [Certificates] values ('html academy', 'Design web-interfaces via html è css')
insert into [Certificates] values ('html academy', 'Server-side part of web-application php')
insert into [Certificates] values ('Photoshop master', 'Intermediate web-designer')
insert into [Certificates] values ('Design for everyone', 'Awesome skills (Adobe Il)')
insert into [Certificates] values ('CISCO', 'Professional Routing and Switching')
insert into [Certificates] values ('Retratech', 'Linux system administrator')

insert into Workers values ('Skorichenko', 'Daniel', 'Genadievich', 1, 'Lermontova 105', '503040328', '19991001', 1, '14000', 'Skorichenko.jpg', 0)
insert into Workers values ('Kumaransky', 'Maxim', 'Urievich', 1, 'Geroiv ATO 1488', '501289411', '20000427', 3, '12000', 'Kumaransky.jpg', 0)
insert into Workers values ('Ogur', 'Arina', 'Vladimirovna', 0, 'Unaya 13', '994050598', '20020612', 2, '9000', 'Ogur.jpg', 0)
insert into Workers values ('Presnyakov', 'Adnreii', 'Anatolievich', 1, 'Meleshkina 148', '501289411', '20000427', 2, '13000', 'Presnyakov.jpg', 0)
insert into Workers values ('Burtovoi', 'Yaroslav', 'Igorevich', 1, 'Vsebratskoe 18', '501289411', '19990427', 3, '18000', 'man.jpg', 0)



insert into StaffandCertificates values (1, 5)
insert into StaffandCertificates values (2, 5)
insert into StaffandCertificates values (2, 6)
insert into StaffandCertificates values (3, 1)
insert into StaffandCertificates values (3, 3)
insert into StaffandCertificates values (3, 4)

