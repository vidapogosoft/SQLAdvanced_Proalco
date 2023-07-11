use master
go

create database dbpartitiontable

/********************************************/

alter database dbpartitiontable add filegroup dbpartitiontable_data2

alter database dbpartitiontable
add file(

	name = dbpartitiontable_2,
	filename = 'D:\SqlData2\dbpartitiontable_2.ndf'
)to filegroup dbpartitiontable_data2


use dbpartitiontable
go

create table RptHistoricoventas
(
	idventas int,
	idusuario int
)


create table RptHistoricoventas2
(
	idventas int,
	idusuario int
)on dbpartitiontable_data2


-----cambio el storage de la tabla
CREATE UNIQUE CLUSTERED INDEX PK_IdDisco
ON Discos(IdDisco)
WITH (DROP_EXISTING=ON,ONLINE=ON) ON musicallyapp_Data4

/*****************************************/
use master
go
alter database ApiServicesDb add filegroup ApiServicesDb_data2

alter database ApiServicesDb
add file(

	name = ApiServicesDb_2,
	filename = 'D:\SqlData2\ApiServicesDb_2.ndf'
)to filegroup ApiServicesDb_data2

use ApiServicesDb
go

-----cambio el storage de la tabla
CREATE UNIQUE CLUSTERED INDEX PK_Products
ON Catalog.Products(ProductId)
WITH (DROP_EXISTING=ON,ONLINE=ON) ON ApiServicesDb_data2


select * from Catalog.Products


/*****************************************/
use master
go
alter database FirmasSQL add filegroup FirmasSQLb_data2

alter database FirmasSQL
add file(

	name = FirmasSQL_2,
	filename = 'D:\SqlData2\FirmasSQL_2.ndf'
)to filegroup FirmasSQLb_data2


select * from FirmasSQL..corresponsal where year(FechaCreacion) = 2012
