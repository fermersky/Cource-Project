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
    [ImgFile] [varchar](100) nu