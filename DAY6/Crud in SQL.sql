create database siva
use siva
create table table_1
(
StuId int primary key,
FirstName varchar(50),
SecondName varchar(50),
PhoneNo varchar(50),
class int
)
insert into table_1 values(03,'MS','Dhoni','9940570357',10)
select *from table_1
delete from table_1 where StuId=1
update table_1 set FirstName='MR.360' where StuId=2