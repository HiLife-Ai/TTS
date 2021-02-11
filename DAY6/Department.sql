create table Department
(
DepartmentID int,
DepartmentName varchar(50),
EmployeeID INT FOREIGN KEY REFERENCES Employee(EmployeeID)
)
select *from Department
insert into Department values(4,'TopOrder',4) 