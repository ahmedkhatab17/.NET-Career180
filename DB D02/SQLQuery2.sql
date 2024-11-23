create table Employee
(
	SSN int primary key,
	FName varchar(20) not null,
	LName varchar(20) null,
	BirthDate date null,
	sex varchar(5) not null,
	salary money not null,
	superSSN int null,
	--DeptId int not null 
)

alter table Employee
add constraint SuperviorFK foreign key (superSSN) references Employee(SSN)

create table Department
(
	DeptId int primary key,
	DeptName varchar(20) not null,
	MgrSSN int foreign key references Employee(SSN) not null,
	MgrHireDate date null
)

alter table employee
add DeptId int foreign key references Department(DeptId)

create table Dept_Locations
(
	deptId int not null,
	Location varchar(20) not null,
	primary key(deptId,Location)
)
alter table Dept_Locations
add constraint LocDeptIDFK foreign key (deptId) references department(deptId)

create table Project
(
	projId int primary key,
	ProjName varchar(20) not null,
	PLocation varchar(20) not null,
	DeptId int not null,
	constraint DeptIDFK foreign key (DeptId) references Department(deptId)
)

create table Employee_Projects
(
	ESSN int not null,
	ProjNo int not null,
	hours int not null,
	primary key(ESSN,ProjNo)
)

alter table Employee_Projects
add constraint ESSNFK foreign key (essn) references employee(ssn)
alter table Employee_Projects
add constraint ProjNoFK foreign key (ProjNo) references Project(projId)

create table Dependent
(
	Essn int foreign key references Employee (ssn) not null,
	name varchar(40) not null,
	sex varchar(10) not null,
	BDate date null,
	Relationship varchar(20) not null,
	primary key(essn,NAME)
)
