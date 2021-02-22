/*ALTER TABLE arhivi
ADD CONSTRAINT fk_arhivi FOREIGN KEY (poraba_denarja_id) REFERENCES porabe_denarja(id)
ON UPDATE CASCADE ON DELETE RESTRICT;*/
CREATE OR REPLACE FUNCTION update_arhiv()
RETURNS trigger AS
$$
DECLARE
BEGIN
	UPDATE arhivi SET datum_spremembe = NOW() WHERE (poraba_denarja_id = (SELECT id FROM porabe_denarja WHERE id = OLD.id));
	RETURN NULL;
END
$$LANGUAGE 'plpgsql';

CREATE TRIGGER update_porabe_denarja_v_arhiv
AFTER UPDATE
ON porabe_denarja FOR EACH ROW EXECUTE PROCEDURE update_arhiv();
--drop function return_arhiv(idu INTEGER);

CREATE OR REPLACE FUNCTION delete_arhiv()
RETURNS trigger AS
$$
DECLARE
BEGIN
	DELETE FROM arhivi WHERE (poraba_denarja_id = (SELECT id FROM porabe_denarja WHERE id = OLD.id));
	RETURN NULL;
END
$$LANGUAGE 'plpgsql';

CREATE TRIGGER insert_u
AFTER INSERT
ON uporabniki FOR EACH ROW EXECUTE PROCEDURE insert_upo();
CREATE OR REPLACE FUNCTION insert_upo()
RETURNS trigger AS
$$
DECLARE
BEGIN
	UPDATE uporabniki SET datum_nastanka = NOW(), naslov = 'x', datum_roj = ' 01-01-2000' WHERE id=new.id;
	INSERT INTO nastavitve (barva, font, velikost, uporabnik_id) VALUES ('x','x','1',new.id);
	RETURN NULL;
END
$$LANGUAGE 'plpgsql';



CREATE OR REPLACE FUNCTION insert_arhiv()
RETURNS trigger AS
$$
DECLARE
id_porabe_denarja INTEGER;
BEGIN
	INSERT INTO arhivi (datum_placila, poraba_denarja_id) VALUES (NOW(), new.id);
	return NULL;
END
$$LANGUAGE 'plpgsql';

/*DROP TRIGGER insert_porabe_denarja_v_arhiv;
CREATE TRIGGER insert_porabe_denarja_v_arhiv
AFTER INSERT
ON porabe_denarja FOR EACH ROW EXECUTE PROCEDURE insert_arhiv();*/
--drop function return_arhiv(idu INTEGER);
CREATE OR REPLACE FUNCTION return_arhiv(idu INTEGER)
RETURNS TABLE (
   	datum DATE,
	znesek REAL
) AS $$
BEGIN
  RETURN QUERY
    SELECT a.datum_placila, p.znesek
    FROM arhivi a INNER JOIN porabe_denarja p ON p.id=a.poraba_denarja_id INNER JOIN uporabniki u ON u.id= p.uporabnik_id 
	WHERE u.id = idu;
END
$$LANGUAGE 'plpgsql';
--drop function return_podrobno_arhiv (idu INTEGER, datumZ VARCHAR(100), znesekZ REAL);
CREATE OR REPLACE FUNCTION return_podrobno_arhiv(idu INTEGER, datumZ VARCHAR(100), znesekZ REAL)
RETURNS TABLE (
   	datum DATE,
	znesek REAL,
	lokacija VARCHAR(100),
	kraj VARCHAR(100)
) AS $$
BEGIN
  RETURN QUERY
    SELECT a.datum_placila, p.znesek, l.ime, k.ime
    FROM arhivi a INNER JOIN porabe_denarja p ON p.id=a.poraba_denarja_id INNER JOIN uporabniki u ON u.id= p.uporabnik_id
	INNER JOIN lokacije l ON l.id=p.lokacija_id INNER JOIN kraji k ON k.id=l.kraj_id
	WHERE (u.id = idu) AND (a.datum_placila = TO_DATE(datumZ,'yyyy-MM-dd')) AND (p.znesek = znesekZ);
END
$$LANGUAGE 'plpgsql';

CREATE OR REPLACE FUNCTION return_arhiv_dolocen_datum(dtOD DATE, dtDo DATE, idU INTEGER)
RETURNS TABLE (
   	datum DATE,
	znesek REAL
) AS $$
BEGIN
  RETURN QUERY
    SELECT a.datum_placila, p.znesek
    FROM arhivi a INNER JOIN porabe_denarja p ON p.id=a.poraba_denarja_id INNER JOIN uporabniki u ON u.id= p.uporabnik_id 
	WHERE (u.id = idu) AND (a.datum_placila BETWEEN dtOD AND dtDO);
END
$$LANGUAGE 'plpgsql';