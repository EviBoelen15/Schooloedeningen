REM ======================================================================
REM SQL*Plus script crecaseDML.sql: maakt de casustabellen (met constraints)
REM ======================================================================

-- ----------------------------------------------------------------------
-- Opstarten    : @ "C:\SCHOOL\DATA ESSENTIALS\5 DDL\crecaseDML.sql"

-- ----------------------------------------------------------------------


drop   table  medewerkersDML cascade constraints;


create table  medewerkersDML
(mnr          NUMBER(4)    constraint M3_PK        primary key
                           constraint M3_MNR_CHK   check (mnr > 7000)
,naam         VARCHAR2(15) constraint M3_NAAM_NN   not null
,voorn        VARCHAR2(12)  constraint M3_VOORL_NN  not null
,functie      VARCHAR2(10)
,chef         NUMBER(4)    constraint M3_CHEF_FK   references medewerkersDML
,gbdatum      DATE        constraint M3_GEBDAT_NN not null
,maandsal     NUMBER(6,2)  constraint M3_MNDSAL_NN not null
,comm         NUMBER(6,2)
,afd          NUMBER(2)    default 10
,constraint   M3_VERK_CHK   check (decode(functie,'VERKOPER',0,1) +
				  decode(comm   , NULL     ,0,1) = 1)
);

REM ====================================================================
drop   table afdelingenDML cascade constraints;

create table afdelingenDML
(anr     NUMBER(2)    constraint A3_PK       primary key
                      constraint A3_ANR_CHK  check ( mod(anr,10) = 0 )
,naam    VARCHAR2(20) constraint A3_NAAM_NN  not null
                      constraint A3_NAAM_UN  unique
                      constraint A3_NAAM_CHK check (naam    = upper(naam)   )
,locatie VARCHAR2(20) constraint A3_LOC_NN   not null
                      constraint A3_LOC_CHK  check (locatie = upper(locatie))
,hoofd   NUMBER(4)    constraint A3_HOOFD_FK references medewerkersDML
);

REM ====================================================================
alter table medewerkersDML
add   (constraint M3_AFD_FK foreign key (afd) references afdelingenDML);

REM ====================================================================
drop   table schalenDML cascade constraints;

create table schalenDML
(snr          NUMBER(2)    constraint S3_PK         primary key
,ondergrens   NUMBER(6,2)  constraint S3_ONDER_NN   not null
                           constraint S3_ONDER_CHK  check (ondergrens >= 0)
,bovengrens   NUMBER(6,2)  constraint S3_BOVEN_NN   not null
,toelage      NUMBER(6,2)  constraint S3_TOELG_NN   not null
,constraint   S3_OND_BOV    check ( ondergrens  <=  bovengrens )
);

REM ====================================================================
drop   table  cursussenDML cascade constraints;

create table  cursussenDML
(code         VARCHAR2(4)  constraint C3_PK        primary key
,omschrijving VARCHAR2(50) constraint C3_OMSCHR_NN not null
,type         CHAR(3)      constraint C3_TYPE_NN   not null
,lengte       NUMBER(2)    constraint C3_LENGTE_NN not null
,constraint   C3_CODE_CHK   check (code  =  upper(code)       )
,constraint   C3_TYPE_CHK   check (type in ('ALG','BLD','DSG'))
);

REM ====================================================================
drop   table  uitvoeringenDML cascade constraints;

create table  uitvoeringenDML
(cursus       VARCHAR2(4)  constraint U3_CURSUS_NN not null
                           constraint U3_CURSUS_FK references cursussenDML
,begindatum   DATE         constraint U3_BEGIN_NN  not null
,docent       NUMBER(4)    constraint U3_DOCENT_FK references medewerkersDML
,locatie      VARCHAR2(20)
,constraint   U3_PK         primary key (cursus,begindatum)
);

REM ====================================================================
drop   table  inschrijvingenDML cascade constraints;

create table  inschrijvingenDML
(cursist      NUMBER(4)    constraint  I3_CURSIST_NN not null
                           constraint  I3_CURSIST_FK references medewerkersDML
,cursus       VARCHAR2(4)  constraint  I3_CURSUS_NN  not null
,begindatum   DATE         constraint  I3_BEGIN_NN   not null
,evaluatie    NUMBER(1)    constraint  I3_EVAL_CHK
                           check       (evaluatie in (1,2,3,4,5) )
,constraint   I3_PK         primary key (cursist,cursus,begindatum)
,constraint   I3_UITV_FK    foreign key (cursus,begindatum)
                            references  uitvoeringenDML
);

REM ====================================================================
drop   table  historieDML cascade constraints;

create table historieDML
( mnr	number(4)	constraint h3_mnr_nn  not null
        constraint h3_mnr_fk  references medewerkersDML on delete cascade
, beginjaar 	number(4) 	constraint h3_bgjaar_nn not null
, begindatum 	date     	constraint h3_gbdtum_nn not null
, einddatum 	date
, afd	number(2) 	constraint h3_afd_nn not null
, maandsal  	number(6,2)	constraint h3_sal_nn   not null
, opmerkingen 	varchar2(60)
, constraint h3_pk    	primary key (mnr,begindatum)
, constraint h3_bgdat_einddat   	check (begindatum < einddatum)
)


Prompt TABELLEN WORDEN EERST VERWIJDERD EN NADIEN OPNIEUW GEMAAKT!
