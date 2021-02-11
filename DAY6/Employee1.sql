create table Employee
(
EmployeeID int primary key,
EmpName varchar(50),
DepartmentID int,
Address varchar(50)
)
select *from Employee
insert into Employee values(3,'Kane Williamson',3,'Newzealand')
update Employee set DepartmentID=1 where EmployeeID=1