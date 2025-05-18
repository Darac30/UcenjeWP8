use master;
go
drop database if exists novine;
go
create database novine collate Croatian_CI_AS;
go
use novine;

create table autor (
sifra int not null primary key identity (1,1),
ime varchar(20) not null,
prezime varchar(30) not null,
datumrodjenja datetime
);

