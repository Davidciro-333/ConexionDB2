create database ConexionDB2
use ConexionDB2

create table Login1(
NomUser varchar(50) not null,
Pass varchar(50) not null,
primary key(NomUser))

create table Personas(
Id int not null,
Nombre varchar(50) not null,
Apellido varchar(50) not null,
Correo varchar(50) not null,
Direccion varchar(50) not null,
primary key(Id))

insert into Login1 values('Dciro333', '200303')
insert into Login1 values('Ortiz2003', '200303')

insert into Personas values(1, 'David', 'Ciro', 'david.ciro591@pascualbravo.edu.co', 'Medellin')
insert into Personas values(2, 'Alejandro', 'Ortiz', 'davidcirortiz06@gmail.com', 'San Luis')

select NomUser, Pass from Login1
select Id, Nombre, Apellido, Correo, Direccion from Personas