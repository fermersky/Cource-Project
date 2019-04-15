select * from Certificates

select Surname + ' ' + Firstname as 'Worker', CompanyName, Description from StaffandCertificates
join Workers on (StaffandCertificates.WorkerId = Workers.Id)
join Certificates on (StaffandCertificates.CertificateId = Certificates.Id)

insert into StaffandCertificates values (2, 5)
insert into StaffandCertificates values (1, 6)
insert into StaffandCertificates values (3, 1)
insert into StaffandCertificates values (4, 2)
