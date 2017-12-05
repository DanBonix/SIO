use mysql;
drop database if exists dbCinema;
create database dbCinema;
use dbCinema;

create table Film
(
	id int auto_increment not null,
	titre varchar(255) not null,
	directeur varchar(60),
	primary key(id)
)engine=innodb;

create table Salle
(
	id int auto_increment not null,
	nom varchar(60) not null,
	adresse varchar(100),
	telephone varchar(10),
	primary key(id)
)engine=innodb;

create table Acteur
(
	id int auto_increment not null,
	nom varchar(60) not null,
	prenom varchar(50) not null,
	primary key(id)
)engine=innodb;

create table Jouer
(
	idActeur int not null,
	idFilm int not null
)engine=innodb;

create table Seance
(
	idFilm int not null,
	idSalle int not null,
	horaire varchar(5) not null
)engine=innodb;

alter table Jouer
add constraint pk_jouer
primary key (idActeur, idFilm);

alter table Seance
add constraint pk_seance
primary key (idFilm, idSalle);

alter table Jouer
add constraint fk_jouer_acteur
foreign key (idActeur)
references Acteur (id);

alter table Jouer
add constraint fk_jouer_film
foreign key (idFilm)
references Film (id);

alter table Seance
add constraint fk_seance_film
foreign key (idFilm)
references Film (id);

alter table Seance
add constraint fk_seance_salle
foreign key (idSalle)
references Salle (id);

insert into Film (titre, directeur) values  ('Mais qui a tué Harry ?', 'Hitchcock');
insert into Film (titre, directeur) values  ('Cris et chuchotements', 'Bergman');
insert into Film (titre, directeur) values ('Chiens de paille', 'Rod Lurie');
insert into Film (titre, directeur) values ('Annie Hall', 'Woody Allen');
insert into Film (titre, directeur) values ('Manhattan', 'Woody Allen');
insert into Film (titre, directeur) values ('Match Point', 'Woody Allen');
insert into Film (titre, directeur) values ('Pirates des Caraïbes 5 : La vengeance de Salazar', 'Espen Sandberg');

insert into Salle (nom, adresse, telephone) values ('Gaumont Opéra', '31 Bd des Italiens', '0147426033');
insert into Salle (nom, adresse, telephone) values ('Saint André des Arts', '30, Rue Saint André des Arts', '043264818');
insert into Salle (nom, adresse, telephone) values ('Le Champo', '51, rue des Ecoles', '0143545160');
insert into Salle (nom, adresse, telephone) values ('George V', '144, Av des Champs Elysées', '0145624146');
insert into Salle (nom, adresse, telephone) values ('Les 7 Parnassiens', '98, Bd du Montparnasse', '0143203220');
insert into Salle (nom, adresse, telephone) values ('Le Studio', '2, Rue Edouard Poisson', '0961216825');
insert into Salle (nom, adresse, telephone) values ('Megarama', '1, Place Chamblyrama', null);

insert into Acteur (nom, prenom) values ('Gwenn', 'Edmund');
insert into Acteur (nom, prenom) values ('Forsythe', 'John');
insert into Acteur (nom, prenom) values ('MacLaine', 'Shirley');
insert into Acteur (nom, prenom) values ('Hitchcock', 'Alfred');
insert into Acteur (nom, prenom) values ('Anderson', 'Harriet');
insert into Acteur (nom, prenom) values ('Sylwan', 'Kari');
insert into Acteur (nom, prenom) values ('Thulin', 'Ingrid');
insert into Acteur (nom, prenom) values ('Ullman', 'Liv');
insert into Acteur (nom, prenom) values ('Marsden', 'James');
insert into Acteur (nom, prenom) values ('Bosworth', 'Kate');
insert into Acteur (nom, prenom) values ('Allen', 'Woody');
insert into Acteur (nom, prenom) values ('Keaton', 'Diane');
insert into Acteur (nom, prenom) values ('Murphy', 'Michael');
insert into Acteur (nom, prenom) values ('Hemingway', 'Mariel');
insert into Acteur (nom, prenom) values ('Rhys-Meyers', 'Jonathan');
insert into Acteur (nom, prenom) values ('Johansson', 'Scarlett');
insert into Acteur (nom, prenom) values ('Depp', 'Johnny');
insert into Acteur (nom, prenom) values ('Bardem', 'Javier');

insert into Jouer (idActeur, idFilm) values (1,1);
insert into Jouer (idActeur, idFilm) values (2,1);
insert into Jouer (idActeur, idFilm) values (3,1);
insert into Jouer (idActeur, idFilm) values (4,1);
insert into Jouer (idActeur, idFilm) values (5,2);
insert into Jouer (idActeur, idFilm) values (6,2);
insert into Jouer (idActeur, idFilm) values (7,2);
insert into Jouer (idActeur, idFilm) values (8,2);
insert into Jouer (idActeur, idFilm) values (9,3);
insert into Jouer (idActeur, idFilm) values (10,3);
insert into Jouer (idActeur, idFilm) values (11,4);
insert into Jouer (idActeur, idFilm) values (12,4);
insert into Jouer (idActeur, idFilm) values (13,5);
insert into Jouer (idActeur, idFilm) values (14,5);
insert into Jouer (idActeur, idFilm) values (15,6);
insert into Jouer (idActeur, idFilm) values (16,6);
insert into Jouer (idActeur, idFilm) values (17,7);
insert into Jouer (idActeur, idFilm) values (18,7);

insert into Seance (idFilm, idSalle, horaire) values (2,1,'20:30');
insert into Seance (idFilm, idSalle, horaire) values (1,2,'20:15');
insert into Seance (idFilm, idSalle, horaire) values (2,4,'22:15');
insert into Seance (idFilm, idSalle, horaire) values (2,5,'20:45');
insert into Seance (idFilm, idSalle, horaire) values (3,3,'21:45');
insert into Seance (idFilm, idSalle, horaire) values (4,3,'20:00');
insert into Seance (idFilm, idSalle, horaire) values (5,6,'14:30');
insert into Seance (idFilm, idSalle, horaire) values (6,2,'19h10');
insert into Seance (idFilm, idSalle, horaire) values (7,7,'12h25');

/*

-- QUESTIONS --

-- 1 --
R1 = Selection(Film, titre = "Cris et chuchotements")
R2 = Projection(R1, directeur)

select distinct directeur
from film
where titre = "Cris et chuchotements";
+-----------+
| directeur |
+-----------+
| Bergman   |
+-----------+

-- 2 --
R1 = Selection(Film, titre = "Chiens de paille")
R2 = Jointure(R1, Seance, )

select nom
from salle
inner join seance
on salle.id = seance.idSalle
inner join film
on seance.idFilm = film.id
where titre = "Chiens de paille";
+-----------+
| nom       |
+-----------+
| Le Champo |
+-----------+

-- 3 --
R1 = Selection(Salle, nomSalle = "Le Studio")
R2 = Projection(R1, adresse, telephone)

select adresse, telephone
from salle
where nom = "Le Studio";
+------------------------+------------+
| adresse                | telephone  |
+------------------------+------------+
| 2, Rue Edouard Poisson | 0961216825 |
+------------------------+------------+

-- 4 --
R1 = Selection(Film, directeur = "Bergman")
R2 = Jointure(R1, Seance, R1.idFilm = Seance.idFilm)
R3 = Jointure(R2, Salle, R2.idSalle = Salle.idSalle)
R4 = Projection(R3, nomSalle, adresse)

select nom, adresse
from salle
inner join seance
on salle.id = seance.idSalle
inner join film
on seance.idFilm = film.id
where directeur = "Bergman";

+-------------------+-----------------------------+
| nom               | adresse                     |
+-------------------+-----------------------------+
| Gaumont Opéra     | 31 Bd des Italiens          |
| George V          | 144, Av des Champs Elysées  |
| Les 7 Parnassiens | 98, Bd du Montparnasse      |
+-------------------+-----------------------------+

-- 5 --
R1 = Jointure(Film, Jouer, Film.idFilm = Jouer.idFilm)
R2 = Jointure(R1, Acteur, R1.idActeur = Acteur.idActeur)
R3 = Projection(R2, directeur, nom)
R4 = Classement(R3, directeur)

select directeur, nom
from Film
inner join Jouer
on Film.id = Jouer.idFilm
inner join Acteur
on Jouer.idActeur = Acteur.idActeur
order by directeur;

-- 6 --
R1 = Selection(Salle, nomSalle = "Gaumont Opéra")
R2 = Selection(Film, directeur = "Bergman")
R3 = Jointure(R2, Seance, R2.idFilm = Seance.idFilm)
R4 = Jointure(R3, R1, R3.idSalle = R1.idSalle)
R5 = Projection(R4, horaire)

-- 7 --
R1 = Selection(Film, titre = "Annie Hall" OU titre = "Manhattan")
R2 = Jointure(R1, Seance, R1.idFilm = Seace.idFilm)
R3 = Jointure(R2, Salle, R2.idSalle = Salle.idSalle)
R4 = Projection(R3, nomSalle)

R1 = Selection(Film, titre = "Annie Hall")
R2 = Jointure(R1, Seance, R1.idFilm = Seance.idFilm)
R3 = Jointure(R2, Salle, R2.idSalle = Salle.idSalle)
R4 = Selection(Film, titre = "Manhattan")
R5 = Jointure(R4, Seance, R4.idFilm = Seance.idFilm)
R6 = Jointure(R5, Salle, R5.idSalle = Salle.idSalle)
R7 = Projection(R3, nomSalle)
R8 = Projection(R6, nomSalle)
R9 = Union(R7, R8)

-- 8--
