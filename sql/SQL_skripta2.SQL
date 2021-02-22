/*
Created: 22. 12. 2020
Modified: 22. 12. 2020
Model: PostgreSQL 10
Database: PostgreSQL 10
*/


-- Create tables section -------------------------------------------------

-- Table kraji

CREATE TABLE "kraji"(
 "id" Serial NOT NULL,
 "ime" Character varying(70) NOT NULL,
 "posta" Character varying(4)
)
WITH (
 autovacuum_enabled=true)
;

-- Add keys for table kraji

ALTER TABLE "kraji" ADD CONSTRAINT "PK_kraji" PRIMARY KEY ("id")
;

-- Table lokacije

CREATE TABLE "lokacije"(
 "id" Serial NOT NULL,
 "ime" Character varying(50) NOT NULL,
 "naslov" Character varying(50),
 "kraj_id" Integer NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

-- Create indexes for table lokacije

CREATE INDEX "IX_Relationship1" ON "lokacije" ("kraj_id")
;

-- Add keys for table lokacije

ALTER TABLE "lokacije" ADD CONSTRAINT "PK_lokacije" PRIMARY KEY ("id")
;

-- Table uporabniki

CREATE TABLE "uporabniki"(
 "id" Serial NOT NULL,
 "ime" Character varying(50) NOT NULL,
 "priimek" Character varying(50) NOT NULL,
 "datum_roj" Timestamp,
 "naslov" Character varying(50),
 "email" Character varying(50) NOT NULL,
 "geslo" Character varying(256) NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

-- Add keys for table uporabniki

ALTER TABLE "uporabniki" ADD CONSTRAINT "PK_uporabniki" PRIMARY KEY ("id")
;

-- Table porabe_denarja

CREATE TABLE "porabe_denarja"(
 "id" Serial NOT NULL,
 "znesek" Real NOT NULL,
 "datum" Timestamp NOT NULL,
 "lokacija_id" Integer NOT NULL,
 "uporabnik_id" Integer
)
WITH (
 autovacuum_enabled=true)
;

-- Create indexes for table porabe_denarja

CREATE INDEX "IX_Relationship2" ON "porabe_denarja" ("lokacija_id")
;

CREATE INDEX "IX_Relationship4" ON "porabe_denarja" ("uporabnik_id")
;

-- Add keys for table porabe_denarja

ALTER TABLE "porabe_denarja" ADD CONSTRAINT "PK_porabe_denarja" PRIMARY KEY ("id")
;
-- Create foreign keys (relationships) section ------------------------------------------------- 

ALTER TABLE "lokacije" ADD CONSTRAINT "Relationship1" FOREIGN KEY ("kraj_id") REFERENCES "kraji" ("id") ON DELETE NO ACTION ON UPDATE NO ACTION
;

ALTER TABLE "porabe_denarja" ADD CONSTRAINT "Relationship2" FOREIGN KEY ("lokacija_id") REFERENCES "lokacije" ("id") ON DELETE NO ACTION ON UPDATE NO ACTION
;

ALTER TABLE "porabe_denarja" ADD CONSTRAINT "Relationship4" FOREIGN KEY ("uporabnik_id") REFERENCES "uporabniki" ("id") ON DELETE NO ACTION ON UPDATE NO ACTION
;




