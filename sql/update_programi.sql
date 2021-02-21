CREATE OR REPLACE FUNCTION update_kraj (imek VARCHAR (100), postanovo VARCHAR(5), imekstaro VARCHAR(100), postastaro VARCHAR(5))
RETURNS void AS 
$$
DECLARE
id_kraja INTEGER;
BEGIN
	SELECT INTO id_kraja id FROM kraji WHERE (posta = postastaro) AND (ime = imekstaro);
	UPDATE kraji SET ime = imek, posta = postanovo WHERE id = id_kraja;
END
$$LANGUAGE 'plpgsql';


CREATE OR REPLACE FUNCTION update_nastavitve (barvaN VARCHAR (100), fontN VARCHAR(100), velikostN INTEGER, idU INTEGER)
RETURNS void AS 
$$
DECLARE
BEGIN
	UPDATE nastavitve SET barva = barvaN, font = fontN, velikost = velikostN WHERE uporabnik_id = idU;
END
$$LANGUAGE 'plpgsql';

CREATE OR REPLACE FUNCTION update_lokacijo (imel VARCHAR (100), naslovl VARCHAR(50), imek VARCHAR(50), imelstaro VARCHAR (100), 
											naslovlstaro VARCHAR(50))
RETURNS void AS 
$$
DECLARE
id_kraja INTEGER;
id_lokacije INTEGER;
BEGIN
	SELECT INTO id_kraja id FROM kraji WHERE ime = imek;
	SELECT INTO id_lokacije id FROM lokacije WHERE (ime = imelstaro) AND (naslov = naslovlstaro);
	UPDATE lokacije SET ime = imel, naslov = naslovl, kraj_id = id_kraja WHERE id = id_lokacije;
END
$$LANGUAGE 'plpgsql';

CREATE OR REPLACE FUNCTION update_porabe_denarja(idP INTEGER, znesekZ REAL, datumD TIMESTAMP)
RETURNS void AS
$$
DECLARE
BEGIN
	UPDATE porabe_denarja SET znesek = znesekZ, datum = datumD
	WHERE (id = idP);
END
$$LANGUAGE 'plpgsql';

CREATE OR REPLACE FUNCTION update_porabe_denarja2(idP INTEGER, znesekZ REAL, datumD TIMESTAMP, krajI VARCHAR(100), lokacijaI VARCHAR(100))
RETURNS void AS
$$
DECLARE
id_lokacija INTEGER;
BEGIN
SELECT INTO id_lokacija l.id FROM lokacije l INNER JOIN kraji k ON k.id=l.kraj_id WHERE ((k.ime = krajI)AND(l.ime = lokacijaI));
	UPDATE porabe_denarja SET znesek = znesekZ, datum = datumD, lokacija_id = id_lokacija
	WHERE (id = idP);
END
$$LANGUAGE 'plpgsql';

CREATE OR REPLACE FUNCTION update_podatke_uporabnika(idU INTEGER, imeU VARCHAR(100), priimekU VARCHAR(100), datumU TIMESTAMP, naslovU VARCHAR (100))
RETURNS void AS
$$
DECLARE
BEGIN
	UPDATE uporabniki SET ime = imeU, priimek = priimekU, datum_roj = datumU, naslov = naslovU
	WHERE (id = idU);
END
$$LANGUAGE 'plpgsql';

CREATE OR REPLACE FUNCTION update_email_uporabnika(idU INTEGER, emailU VARCHAR(100))
RETURNS void AS
$$
DECLARE
U_id INTEGER;
BEGIN
	SELECT INTO U_id id FROM uporabniki WHERE email = emailU;
	IF U_id IS NULL THEN
	UPDATE uporabniki SET email = emailU WHERE (id = idU);
	END IF;
END
$$LANGUAGE 'plpgsql';

CREATE OR REPLACE FUNCTION update_geslo_uporabnika(idU INTEGER, gesloU VARCHAR (256))
RETURNS void AS
$$
DECLARE
BEGIN
	UPDATE uporabniki SET geslo = gesloU WHERE id = idU;
END
$$LANGUAGE 'plpgsql';

CREATE OR REPLACE FUNCTION update_pozabljeno_geslo_uporabnika(emailU VARCHAR(100), gesloU VARCHAR (256))
RETURNS void AS
$$
DECLARE
BEGIN
	UPDATE uporabniki SET geslo = gesloU WHERE email = emailU;
END
$$LANGUAGE 'plpgsql';