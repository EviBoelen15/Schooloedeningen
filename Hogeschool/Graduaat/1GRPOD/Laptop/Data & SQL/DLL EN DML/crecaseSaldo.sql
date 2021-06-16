create table saldo
( id number(2) constraint s_pk primary key
, voornaam varchar2(20) constraint s_vn_nn not null
, naam varchar2(30) constraint s_nm_nn not null
, saldo number(6) constraint s_sal_nn not null
                  Constraint s_sal_chk check(saldo>0)
)
