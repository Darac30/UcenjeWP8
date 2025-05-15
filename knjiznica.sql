use master;
go
drop database if exists knjiznica;
go
create database knjiznica;
go
use knjiznica;

create table osobe(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
adresa varchar(50),
email varchar(50)
);

create table clanovi (
sifra int not null primary key identity(1,1),
clbroj int
);
