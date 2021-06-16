

--CREATE TABLE SPELERS
	 CREATE TABLE spelers 
	(spnr     int			CONSTRAINT sp_pk           PRIMARY KEY 
	,naam     varchar(20)	CONSTRAINT sp_naam_nn      NOT NULL 
	,voorl    char(3) 
	,gesl     char(1)		default 'M'
							CONSTRAINT sp_gesl_nn      NOT NULL
	,gebdatum  datetime		CONSTRAINT sp_gebdatum_nn  NOT NULL
	,ploegnr   int
	)


-- CREATE TABLE TEAMS with IDENTITY
	CREATE TABLE teams
	(tnr      INT			CONSTRAINT tm_pk           PRIMARY KEY
	,naam     varchar(20)	CONSTRAINT tm_naam_chk     CHECK(naam = upper(naam))
	,kapitein int			CONSTRAINT tm_kap_nn       NOT NULL
							CONSTRAINT tm_kap_fk       REFERENCES spelers
	)


-- CREATE REFERENCE SPELERS.ploegnr --> TEAMS.tnr
	ALTER TABLE spelers 
	add constraint sp_ploegnr_fk foreign key(ploegnr)references teams


-- CREATE TABLE BOETES
	CREATE TABLE boetes
	(bnr        INT			identity(1,1)	CONSTRAINT bo_PK		PRIMARY KEY
	,spnr       int							CONSTRAINT bo_spnr_fk	REFERENCES spelers
	,datum      datetime					CONSTRAINT bo_datum_nn  NOT NULL
	,bedrag     decimal(7,2)				CONSTRAINT bo_bedrag_nn NOT NULL
	)


PRINT 'Tabellen aangemaakt'