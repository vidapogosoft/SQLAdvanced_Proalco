use master 
go

create login operador_facte with password = '123456'

create login auditor_facte with password = '123456'

use FactE
go

create schema operaciones
go

create user oerador for login operador_facte
WITH DEFAULT_SCHEMA = operaciones
go


CREATE TABLE operaciones.BetaTable1
( codigo int primary key,
nombre varchar(25),
apellido varchar(25)
)


GRANT SELECT
ON SCHEMA :: operacionesTO oerador
WITH GRANT OPTION
GO