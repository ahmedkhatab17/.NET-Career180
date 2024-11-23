create table Employee
(
	SSN int primary key,
	FName varchar(20) not Null,
	LName varchar(20) Null,
	Birthdate date null,
	Sex varchar(5) not null,
	Salary money not null,
	SuperSSN int null

)

alter table Employee
add constraint SupervisorFK foreign key (SuperSSN) references Employee(SSN) 

create table Department 
(
	DeptId int primary key,
	DeptName varchar(20) not null,
	MgrSSN int foreign key references Employee(SSN) not null,
	MgrHiredate date null
)

alter table Employee
add DeptId int foreign key references Department(DeptId)

create table Dept_Locations
(
	DeptId int not null,
	Location varchar(20) not null,
	primary key(DeptId, Location)
)

alter table Dept_Locations
add constraint LocDeptIdFK foreign key (DeptId) references Department (DeptId)


create table Project
(
	PId int primary key,
	PName varchar(20) not null, 
	PLocation varchar(20) not null,
	DeptId int not null,
	constraint DeptIdFK foreign key (DeptId) references Department (DeptId)

)

create table Employee_Project
(
	ESSN int not null,
	PNO int not null
	primary key (ESSN ,PNO),
	Hours int not null
)

alter table Employee_Project
add constraint ESSNFK foreign key (ESSN) references Employee(SSN)

alter table Employee_Project
add constraint PNOFK foreign key (PNO) references Project(PId)

create table Dependent 
(
	ESSN int foreign key references Employee (SSN) not null,
	name varchar(40) not null,
	Sex Varchar(5) not null,
	Birthdate date null,
	Relationship varchar(20) not null,
	primary key(ESSN, Name)
)

alter table Dependent 
alter column sex varchar(10) not null

alter table employee 
alter column sex varchar(10) not null

-----------------DML-----------------------
--insert -- update -- delete

-- insert into tablename values(, , , ,.... in orders)
-- insert into tablename (colums) values( , , , ...)
---------colums must include all not null colums--------

insert into Employee Values(9,'Ahmed','Khatab','11/23/2022','male',10000,null,null)
insert into Employee Values(3,'Omar','Ashraf','12/23/2018','male',10000,null,null)
insert into Employee Values(4,'Arwa','Tarek','3/23/2014','female',10000,null,null)
insert into Employee Values(5,'Eman',null,'3/3/2004','female',10000,null,null)
insert into Employee Values(6,'Khaled','Raouf','2/3/2020','male',10000,null,null)
insert into Employee Values(7,'Ali','Ibrahim','4/8/2014','male',10000,null,null)
insert into Employee Values(8,'Aalaa','Fathy','3/9/2013','female',10000,null,null)

insert into Employee (SSN,FName,Sex,Salary)  values(2,'Sara','Female',9000)

insert into Department values (10,'.NET',1,'1/1/2004')
insert into Department values (11,'UI',2,'5/4/2004')
insert into Department values (12,'NodeJS',3,'5/30/2004')
insert into Department values (13,'OS',4,'6/3/2004')


----------------------------------------------------
---update
--update tablename
--set columnname1= newvalue,columnname2= newvalue,columnname3= newvalue.....
----where PK=value

update Employee
set Salary = Salary+salary*15/100
where ssn = 2

update Employee
set superSSN =1 ,deptid =10
where ssn =6

---------------------------------------------------
--delete
--delete from table name where pk=value


delete from Employee
where SSN=9
----------------------------------------------------
--select
-- select *(all columns) from tablename

select * From Employee
select Fname, LName from Employee

select * From Employee
where sex='female'

select * From Employee
where SuperSSN is null

select * From Employee
where SuperSSN is not null

select SSN, FName+' '+LName as FullName From Employee


--------------------------------------------------------

UPDATE Employee
SET SuperSSN = NULL, DeptId = 10
WHERE SSN = 9;

UPDATE Employee
SET SuperSSN = 1, DeptId = 11
WHERE SSN = 3;

UPDATE Employee
SET SuperSSN = 1, DeptId = 12
WHERE SSN = 4;

UPDATE Employee
SET SuperSSN = 3, DeptId = 10
WHERE SSN = 5;

UPDATE Employee
SET SuperSSN = 4, DeptId = 11
WHERE SSN = 6;

UPDATE Employee
SET SuperSSN = NULL, DeptId = 12
WHERE SSN = 7;

UPDATE Employee
SET SuperSSN = 1, DeptId = 13
WHERE SSN = 8;

UPDATE Employee
SET SuperSSN = 4, DeptId = 10
WHERE SSN = 1;

UPDATE Employee
SET SuperSSN = 4, DeptId = 11
WHERE SSN = 2;

insert into Dept_Locations (DeptId, Location)
values 
(10, 'Riyadh'),
(10, 'Jeddah'),
(11, 'Dubai'),
(12, 'Abu Dhabi'),
(13, 'Cairo');


insert into Project (PId, PName, PLocation, DeptId)
values 
(101, 'E-Commerce System', 'Riyadh', 10),
(102, 'Mobile Banking App', 'Dubai', 11),
(103, 'Healthcare Portal', 'Abu Dhabi', 12),
(104, 'AI Research', 'Cairo', 13);

insert into Employee_Project (ESSN, PNO, Hours)
values 
(1, 101, 40),
(2, 102, 35),
(3, 103, 25),
(4, 104, 30),
(5, 101, 20),
(6, 102, 18),
(7, 103, 32),
(8, 104, 28);


insert into Dependent (ESSN, Name, Sex, Birthdate, Relationship)
values 
(1, 'alaa', 'Female', '5/12/2015', 'Daughter'),
(2, 'Omar Jr.', 'Male', '9/20/2018', 'Son'),
(3, 'Fatima', 'Female', '9/20/2018', 'Wife'),
(4, 'Salim', 'Male', '9/20/2015', 'Son'),
(5, 'Nada', 'Female', '9/20/2018', 'Wife'),
(6, 'Zain', 'Male', '9/20/2018', 'Son'),
(7, 'Ranaa', 'Female', '9/20/2018', 'Wife'),
(8, 'Yusuf', 'Male', '9/20/2018', 'Son');



----------------------------------------------------
-- lab ansewr
--1
select * from Employee

--2
select fname, lname ,salary, deptid from Employee

--3
select pname, plocation, deptid from Project

--4
select ssn, fname+' '+isnull(lname,'') as Fullname, salary * 12 *0.1 as Annual_Commission 
from Employee

--5
select ssn, fname+' '+isnull(lname,'') as Fullname from Employee
where Salary > 1000

--6
select ssn, fname+' '+isnull(lname,'') as Fullname from Employee
where Salary*12 > 120000

--7 
select FName,LName,Salary from Employee
where Sex = 'female'

--8 
select deptid,deptname from Department
where MgrSSN =1

--9
select PId, PName,PLocation from Project
where deptid =10