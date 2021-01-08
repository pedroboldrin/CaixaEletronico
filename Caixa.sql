Create database Caixa

use Caixa

Create table Cedulas
(
	Id		int			Primary Key identity	not null,
	Nota	varchar(10)							not null,
	Qtd		int									Not Null
)

Insert into Cedulas values('200', 10)
Insert into Cedulas values('100', 10)
Insert into Cedulas values('50', 20)
Insert into Cedulas values('20', 30)
Insert into Cedulas values('10', 20)
Insert into Cedulas values('5', 10)
Insert into Cedulas values('2', 40)

update Cedulas
set Qtd = 20
where Nota = '50'

Select * from Cedulas

Create Table Saque
(
	Id		int	Primary key	Identity	not null,
	Notas	varchar(50)					not null,
	Valor	int							not	null,
	Hora	datetime					not null
)

