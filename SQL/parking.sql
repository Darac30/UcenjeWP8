use master;
go
drop database if exists parking;
go
create database parking collate Croatian_CI_AS;
go
use parking;

-- kreiranje tablica

create table razine (
sifra int not null primary key identity (1,1),
brojrazine int not null,
dnevnacijena decimal(18,2) not null,
nocnacijena decimal(18,2) not null
);

create table parkirnamjesta (
sifra int not null primary key identity (1,1),
oznaka varchar (10) not null,
cjenik decimal(18,2) not null,
razina int not null references razine(sifra)
);

create table parkiranja (
sifra int not null primary key identity (1,1),
datumulaska datetime,
datumizlaska datetime,
parkirnomjesto int not null references parkirnamjesta(sifra),
registarskaoznaka varchar(10),
ukupnacijena decimal(18,2)
);

-- insert sekcija

insert into razine (brojrazine, dnevnacijena, nocnacijena) values
(-1, 0.50, 0.30),
(0, 1.00, 0.50),
(1, 0.50, 0.30),
(2, 0.30, 0.20);

insert into parkirnamjesta (oznaka, cjenik, razina) values






