--DML   [RECORDS,ROW]
---insert ,update ,delete

---insert into TableName values(,,,in orders)

---insert into TableName (specific Columns) values(,,,in orders) 
----------REMEMBER Columns here must include ALL not null columns


insert into Employee values
(1,'Ahmed','Hossam','10/23/2010','male',10000,NULL,NULL)
--
alter table Employee
alter column Sex varchar(10) not null
--
insert into Employee (ssn,fname,sex,salary)
values(2,'Sara','Female',9000)

insert into Department values
(10,'.NET',1,'1/1/2001')

insert into Department values
(20,'UI',2,'2/2/2002')



---------------------------------------------
insert into Employee values
(3,'Eman','Ali','10/23/2010','Female',10000,NULL,NULL),
(4,'Omar','Ali','10/23/2010','male',10000,NULL,NULL),
(5,'Lara','Ali','10/23/2010','Female',10000,NULL,NULL),
(6,'Marwan','Ali','10/23/2010','male',10000,NULL,NULL),
(7,'Amany','Ali','10/23/2010','Female',10000,NULL,NULL)

insert into Employee values
(8,'Eman','Ibrahim','10/23/2010','Female',10000,NULL,NULL)

-------------------------------------------------------------
---update
----update tableName
----set columnName1=newValue,columnName2=newValue,columnName3=newValue
----where PK=value

---NOT RECOMMENDED
update Employee
set salary=salary+salary*15/100
where fname='Eman'

---RECOMMENDED
update Employee
set salary=salary+salary*15/100
where ssn=3

update Employee
set superssn=1,deptid=10
where ssn =6

------------------------------------------------
--delete
--delete from tblName where PK=value

--not recommended
delete from Employee
where fname='Eman'

delete from Employee
where ssn=3

-------------------------------------------------
--select

--select * from tblName

select * from Employee

select fname ,lname from Employee


select * 
from Employee
where sex='Female'

select *
from Employee
where superssn is NULL

select *
from Employee
where superssn is not NULL

--Execlusive with sql server [not standard] 
select ssn as [Social Number], fname+' '+lname as [full name]
from Employee

-- [standard] concat
select ssn as [Social Number], concat(fname,' ',lname) as [full name]
from Employee
