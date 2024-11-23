---Data Types
---int ,float ,money,string XXXXX 
---char(20) store 20B
--id   name
--		ali
--		sara
--		aya

---varchar(20) store 20B
--id   name
--		aliCCCCCCCCCCCCCCCCCCCCCCC  ERROR string or binary data would be truncated
--		sara
--		aya

---nvarchar(20) store 20B
--id   name
--		 محمد 
--		sara
--		aya



---create
---create table TableName
---(
	--column name DT null/not null
---)
------------------------------------------------------
--Database is case insensitive
--employee--->EMPLOYEE
--create ----> CREATE
------------------------------------------------------
--remove employee table as there is no data entered
drop table Employee


create table Employee
(
	SSN int primary key,
	FName varchar(10) not null,
	LName varchar(10) null,
	Age int null,
	Email varchar(20) not null,
	Salary money not null
)

--add Address column
alter table Employee
add Address varchar(30) null

--remove address column
alter table Employee
drop column address


---make age not null
alter table employee
alter column age int not null

create table Department
(
	DeptId int primary key,
	DeptName varchar(20) not null,
	[Desc] varchar(30) null
)


alter table Employee
add DeptId int foreign key references Department(DeptId)


create table Dependent
(
	ESSN int not null,
	Depname varchar(20) not null,
	relationship varchar(20) null
	primary key(ESSN,Depname)
)
-------------------------------------------
create table Project
(	
	ProjNo int not null,
	ProjName varchar(20) not null,
	DeptId int not null,
	constraint AH foreign key(DeptId) references Department(DeptId),
	constraint MT primary key(ProjNo)
)

alter table Project
drop constraint AH

--------------------------------------------------
