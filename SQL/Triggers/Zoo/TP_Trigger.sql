delimiter !
drop trigger if exists before_insert_animal;
create trigger before_insert_animal
BEFORE INSERT
ON animal FOR EACH ROW
BEGIN
	if new.sexe is not null
		and new.sexe <> 'F'
		and new.sexe <> 'M'
	then
		set new.sexe = null;
	end if;
END !
delimiter ;

create table Erreur
(
	id tinyint unsigned auto_increment primary key,
	libErreur varchar(255) UNIQUE
);

delimiter !
drop trigger if exists before_insert_animal;
create trigger before_insert_animal
BEFORE INSERT
ON animal FOR EACH ROW
BEGIN
	if new.sexe is not null
		and new.sexe <> 'F'
		and new.sexe <> 'M'
	then
		INSERT INTO Erreur(libErreur) values('Erreur : Le sexe de l\'animal ne peut prendre que les valeurs null, F ou M');
	end if;
END !
delimiter ;

delimiter !
drop trigger if exists before_insert_adoption;
create trigger before_insert_adoption
BEFORE INSERT
ON adoption FOR EACH ROW
BEGIN
	if new.paye <> '0'
		and new.paye <> '1'
	then
		INSERT INTO Erreur(libErreur) values('Erreur : Le booléen du paiement de l\'adoption ne peut prendre que les valeurs 0 ou 1');
	else if date_reservation > date_adoption
	then
		INSERT INTO Erreur(libErreur) values('Erreur : La date de réservation ne peut pas être postérieure à la date d\'adoption');
	end if;
END !
delimiter ;

delimiter !
drop trigger if exists before_update_adoption;
create trigger before_update_adoption
BEFORE UPDATE
ON adoption FOR EACH ROW
BEGIN
	if new.paye <> '0'
		and new.paye <> '1'
	then
		INSERT INTO Erreur(libErreur) values('Erreur : Le booléen du paiement de l\'adoption ne peut prendre que les valeurs 0 ou 1');
	else if new.date_reservation > new.date_adoption
	then
		INSERT INTO Erreur(libErreur) values('Erreur : La date de réservation ne peut pas être postérieure à la date d\'adoption');
	end if;
END !
delimiter ;

delimiter !
drop trigger if exists 