create database RecursosHumanos
go
use RecursosHumanos
go

create table Empleados(
Id int identity primary key,
CodigoEmpleado int,
Nombre varchar(30),
Apellido varchar(30),
Telefono varchar(20),
Departamento varchar(20),
Cargo varchar(30),
FechaIngreso varchar(20),
Salario varchar(30),
Estatus varchar(10)
)

create table Departamentos(
Id int identity foreign key(Id) references Empleados(Id),
CodigoDepartamento int,
Nombre varchar(30)
)

create table Cargos(
Id int identity foreign key(Id) references Empleados(Id),
Cargo varchar(30))


select * from Empleados

drop database RecursosHumanos