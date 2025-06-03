use novine;

select * from autor;

insert into autor (ime, prezime, datumrodjenja) 
values ('Ivo', 'Andric', '1933-04-15');

select * from izdavac;

insert into izdavac (naziv, aktivan)
values ('Hermann', 1);

select * from mjesto;

insert into mjesto (naziv, drzava) values 
('Osijek', 'Hrvatska'),
('Ljubljana', 'Slovenija'),
('Skoplje', 'Makedonija');

update mjesto set 
naziv='Kranj' where sifra=2;




