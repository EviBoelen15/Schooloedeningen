

alter table spelers
drop constraint sp_ploegnr_fk


	insert into spelers values(10000,'Haesen'	, 'JK'	,'M','17-FEB-1989', 3);
	insert into spelers values(90030,'Eerdekens', 'DMV'	,'M','25-APR-1991', 1);
	insert into spelers values(10010,'Lahon'	, 'G'	,'M','01-JAN-1995', 2);
	insert into spelers values(10020,'Kusters'	, 'P'	,'M','15-MAR-1990', 5);
	insert into spelers values(10030,'Max'		, 'BR'	,'M','04-MAY-1989', 5);
	insert into spelers values(90020,'Noten'	, 'AP'	,'M','23-JUN-1991', 3);
	insert into spelers values(90050,'Peels'	, 'V'	,'M','05-AUG-1987', 2);
	insert into spelers values(10040,'Colijn'	, 'AB'	,'M','11-JUL-1990', 2);
	insert into spelers values(90010,'Slingers'	, 'L'	,'M','27-SEP-1983', 2);
	insert into spelers values(90005,'Pauwels'	, 'JK'	,'M','17-NOV-1992', 2);
	insert into spelers values(10045,'Knevels'	, 'T'	,'M','26-OCT-1986', 2);
	insert into spelers values(10050,'Vossen'	, 'CG'	,'M','07-MAY-1984', 2);


	insert into teams values (1,'TEAM SPIRIT'	,90020);
	insert into teams values (2,'DUCAMPS'		,90030);
	insert into teams values (3,'A.A.C SANA'	,90050);
	insert into teams values (4,'TEAM APOLLO'	,90010);
	insert into teams values (5,'A.M.P. BRITEL'	,90005);


alter table spelers 
add	constraint sp_ploegnr_fk foreign key(ploegnr)references teams


	insert into boetes values (10020,'15-JAN-2020',5000);
	insert into boetes values (10045,'29-MAR-2020',13500.5);
	insert into boetes values (10020,'07-NOV-2020',4550);
