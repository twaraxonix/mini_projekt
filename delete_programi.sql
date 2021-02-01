CREATE OR REPLACE FUNCTION delete_kraj (imek VARCHAR (100), postak VARCHAR (5))
RETURNS void AS 
$$
DECLARE
id_kraja INTEGER;
kraj_id_s INTEGER;
lokacije_id_s INTEGER;
BEGIN
 	SELECT INTO id_kraja id FROM kraji WHERE ((ime = imek) AND (posta = postak));
	FOR kraj_id_s IN SELECT l.kraj_id FROM lokacije l INNER JOIN kraji k ON k.id=l.kraj_id WHERE (k.id=id_kraja)
	LOOP
		FOR lokacije_id_s IN SELECT l.kraj_id FROM lokacije l INNER JOIN kraji k ON k.id=l.kraj_id 
		INNER JOIN porabe_denarja pd ON l.id=pd.lokacija_id WHERE (k.id=id_kraja)
		LOOP
			UPDATE porabe_denarja SET lokacija_id = 0 WHERE lokacija_id = lokacija_id_s;
		END LOOP;
		DELETE FROM lokacije WHERE id = id_kraja;
	END LOOP;
	DELETE FROM kraji WHERE (id = id_kraja);
END
$$LANGUAGE 'plpgsql';

CREATE OR REPLACE FUNCTION delete_lokacija (imen VARCHAR (100), naslovn VARCHAR(100))
RETURNS void AS
$$
DECLARE
lokacije_id_s INTEGER;
id_lokacije INTEGER;
BEGIN
	SELECT INTO id_lokacije id FROM lokacije WHERE ((ime = imen) AND (naslov = naslovn));
	FOR lokacije_id_s IN SELECT pd.lokacija_id FROM lokacije l
		INNER JOIN porabe_denarja pd ON l.id=pd.lokacija_id WHERE (l.ime = id_lokacije)
	LOOP
			UPDATE porabe_denarja SET lokacija_id = 0 WHERE lokacija_id = lokacija_id_s;
	END LOOP;
	DELETE FROM lokacije WHERE (id = id_lokacije);
END
$$LANGUAGE 'plpgsql';

CREATE OR REPLACE FUNCTION delete_poraba_denarja(idP INTEGER)
RETURNS void AS
$$
DECLARE
id_a INTEGER;
BEGIN
	SELECT INTO id_a id FROM arhivi WHERE (poraba_denarja_id = idP);
	IF(id_a IS NOT NULL) THEN
	DELETE FROM arhivi WHERE id = id_a;
	END IF;
	DELETE FROM porabe_denarja
	WHERE (id = idP);
END
$$LANGUAGE 'plpgsql';

CREATE OR REPLACE FUNCTION delete_uporabnik (emailU VARCHAR(100), gesloU VARCHAR(256))
RETURNS void AS
$$
DECLARE
uporabnik_id_s INTEGER;
id_uporabnik INTEGER;
BEGIN
	SELECT INTO id_uporabnik id FROM uporabniki WHERE (email =emailU) AND (geslo = gesloU);
	FOR uporabnik_id_s IN SELECT pd.id FROM uporabniki u INNER JOIN porabe_denarja pd ON u.id = pd.uporabnik_id
	WHERE (pd.uporabnik_id = id_uporabnik)
	LOOP
		DELETE FROM porabe_denarja WHERE id = uporabnik_id_s;
	END LOOP;
	DELETE FROM uporabniki WHERE id = id_uporabnika;
END
$$LANGUAGE 'plpgsql';

