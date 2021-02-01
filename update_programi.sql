CREATE OR REPLACE FUNCTION update_kraj (imek VARCHAR (100), postanovo VARCHAR(5), postastaro VARCHAR(5))
RETURNS void AS 
$$
DECLARE
id_kraja INTEGER;
BEGIN
	SELECT INTO id_kraja id FROM kraji WHERE posta = postastaro;
	UPDATE kraji SET ime = imek, posta = postanovo WHERE id = id_kraja;
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