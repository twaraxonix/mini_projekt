CREATE OR REPLACE FUNCTION return_vsi_kraji()
RETURNS TABLE (
   	ime VARCHAR (100),
	posta VARCHAR (5)
) AS $$
BEGIN
  RETURN QUERY
    SELECT k.ime, k.posta
    FROM kraji AS k;
END
$$LANGUAGE 'plpgsql';

CREATE OR REPLACE FUNCTION return_sum(idU INTEGER, datumz TIMESTAMP, datumk TIMESTAMP)
RETURNS REAL
AS $$
DECLARE
sumP REAL;
BEGIN
	SELECT INTO sumP SUM(p.znesek) FROM lokacije l INNER JOIN porabe_denarja p ON l.id = p.lokacija_id
	INNER JOIN uporabniki u ON u.id = p.uporabnik_id WHERE (u.id = idU) AND (p.datum BETWEEN datumz AND datumk);
	RETURN sumP;
END
$$LANGUAGE 'plpgsql';

CREATE OR REPLACE FUNCTION return_vse_porabe_denarja(idU INTEGER, datumz TIMESTAMP, datumk TIMESTAMP)
RETURNS TABLE (
   	datum TIMESTAMP,
	lokacija VARCHAR (100),
	znesek REAL
) AS $$
BEGIN
  RETURN QUERY
    SELECT p.datum, l.ime, p.znesek
    FROM lokacije l INNER JOIN porabe_denarja p ON l.id = p.lokacija_id
	INNER JOIN uporabniki u ON u.id = p.uporabnik_id WHERE (u.id = idU) AND (p.datum BETWEEN datumz AND datumk);
END
$$LANGUAGE 'plpgsql';

CREATE OR REPLACE FUNCTION return_posto_krajev(imek VARCHAR(100))
RETURNS TABLE (
	posta VARCHAR (5)
) AS $$
BEGIN
  RETURN QUERY
    SELECT k.posta
    FROM kraji AS k WHERE k.ime = imek;
END
$$LANGUAGE 'plpgsql';

CREATE OR REPLACE FUNCTION return_vse_lokacije(imek VARCHAR(100))
RETURNS TABLE (
   	ime VARCHAR (100),
	naslo VARCHAR (100)
) AS $$
BEGIN
  RETURN QUERY
    SELECT l.ime, l.naslov
    FROM lokacije l INNER JOIN kraji k ON k.id=l.kraj_id WHERE k.ime = imek;
END
$$LANGUAGE 'plpgsql';

CREATE OR REPLACE FUNCTION return_id_porabe_denarja(idU INTEGER, znesekZ REAL, datumZ VARCHAR(100), lokacijaL VARCHAR(100))
RETURNS INTEGER AS
$$
DECLARE
idP INTEGER;
BEGIN
	SELECT INTO idP p.id FROM porabe_denarja p INNER JOIN uporabniki u ON u.id=p.uporabnik_id INNER JOIN lokacije l ON l.id=
	p.lokacija_id
	WHERE (u.id = idU) AND (p.znesek = znesekZ) AND (l.ime = lokacijaL) AND (p.datum = TO_DATE(datumZ,'yyyy-MM-dd'));
	RETURN idP;
END
$$LANGUAGE 'plpgsql';

CREATE OR REPLACE FUNCTION return_podatke_uporabnika(idU INTEGER)
RETURNS TABLE (
   	ime VARCHAR (100),
	priimek VARCHAR (100),
	naslov VARCHAR (100),
	datum_roj TIMESTAMP,
	email VARCHAR(100)
) AS $$
BEGIN
  RETURN QUERY
    SELECT u.ime, u.priimek, u.naslov, u.datum_roj, u.email
    FROM uporabniki u WHERE u.id = idU;
END
$$LANGUAGE 'plpgsql';
