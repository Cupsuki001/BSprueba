create database formulario

use formulario

create table Dato
(
NEst int identity (1,1) primary key not null,
CAR int not null,
NOM nvarchar (15) not null,
APD nvarchar (15) not null,
ACU int not null,
EXA int not null,
FIN int not null
)

select *from Dato

insert into Dato (NEst,CAR,NOM,APD,ACU,EXA,FIN) values (0880 , 'jose' , 'lopez' , 65 , 25 , 90)