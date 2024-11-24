create table Student
(
	id int primary key identity,
	name varchar(20) not null,
	email varchar(20) not null,
)
create table Student2
(
	id int primary key identity,
	name varchar(20) not null,
	email varchar(20) not null,
	ssn int not null identity
)

truncate table student

insert into Student values('Marwan','m@s.s')

select * from Student
---there may appear one identity column per table
---auto incremental column