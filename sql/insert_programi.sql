CREATE OR REPLACE FUNCTION add_kraj (imek VARCHAR (100), postak VARCHAR (5), dodatnok VARCHAR (100))
RETURNS void AS
$$
DECLARE

BEGIN
	INSERT INTO kraji (ime, posta, dodatno) VALUES (imek, postak, dodatnok);
END
$$LANGUAGE 'plpgsql';

CREATE OR REPLACE FUNCTION add_lokacija2 (imek VARCHAR (100), imel VARCHAR (50), naslovl VARCHAR (50))
RETURNS void AS
$$
DECLARE
k_id INTEGER;
BEGIN
	SELECT INTO k_id id FROM kraji WHERE (ime = imek);
	INSERT INTO lokacije (ime, naslov, kraj_id) VALUES (imel, naslovl, k_id);
END
$$LANGUAGE 'plpgsql';

CREATE OR REPLACE FUNCTION add_lokacija (imek VARCHAR (100), postak VARCHAR (5), imel VARCHAR (50), naslovl VARCHAR (50))
RETURNS void AS
$$
DECLARE
k_id INTEGER;
BEGIN
	SELECT INTO k_id id FROM kraji WHERE (posta = postak);
	IF (k_id = NULL) THEN
	INSERT INTO kraji (ime, posta) VALUES (imek, postak);
	SELECT INTO k_id id FROM kraji WHERE (posta = postak);
	INSERT INTO lokacije (ime, naslov, kraj_id) VALUES (imel, naslovl, k_id);
	
	ELSE
	INSERT INTO lokacije (ime, naslov, kraj_id) VALUES (imel, naslovl, k_id);
	END IF;
END
$$LANGUAGE 'plpgsql';

CREATE OR REPLACE FUNCTION add_uporabnik (imeu VARCHAR (100), priimeku VARCHAR (100), datum_roju TIMESTAMP, 
										  naslovu VARCHAR (100), emailu VARCHAR (100), geslou VARCHAR (256))
RETURNS void AS
$$
DECLARE
emailU VARCHAR(100);
BEGIN
	SELECT INTO emailU email FROM uporabniki WHERE email = emailu;
	IF emailU IS NULL THEN
	INSERT INTO uporabniki (ime, priimek, datum_roj, naslov, email, geslo) VALUES (imeu, priimeku, datum_roju, naslovu, emailu, geslou);
	END IF;
END
$$LANGUAGE 'plpgsql';


CREATE OR REPLACE FUNCTION add_poraba_denarja (idu INTEGER, imel VARCHAR (100), 
										  znesekp REAL, datump TIMESTAMP)
RETURNS void AS
$$
DECLARE

BEGIN
	INSERT INTO porabe_denarja(znesek, datum, uporabnik_id, lokacija_id) VALUES (znesekp, datump, idu, (SELECT id FROM lokacije WHERE (ime = imel)));
END
$$LANGUAGE 'plpgsql';