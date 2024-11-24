select * 
from authors

select * from employee

select fname,lname 
from employee

select concat(fname,' ',lname) as FullName
from employee

-------------------------------------------
--using ITI DB
select * from Student

--address in cairo or alex
select *
from Student
where St_Address='Cairo'
or St_Address='Alex'

select *
from Student
where St_Address in ('Cairo','Alex')

-- age>20   age<25
select *
from Student
where 
St_Age>20
and
st_age<25

select *
from Student
where St_Age between 20 and 25

select *
from Student
order by St_Fname

select *
from Student
order by St_Fname,St_Lname

select *
from Student
order by St_Fname desc

select *
from Student
where St_Fname like 'M%'

select *
from Student
where St_Fname like  '%h%'

select *
from Student
where St_Fname like 'h___'

select *
from Student
where St_Fname like  '__h%'

select *
from Student
where St_Fname like '%[_]%'

select *
from Student
where St_Age>25
order by St_Fname

--aggregate functions
---min()  max() count() avg()

select min(St_Age) minimumAge,MAX(st_age) maxAge  ,avg(st_age) averageAge 
from Student


select count(St_Id)  NoOfStudents
from Student

select * from Student

select s.Dept_Id,count(St_Id) NoOfStudents
from Student s
group by s.Dept_Id

select * from Instructor

select i.Ins_Degree,count(i.Ins_Id)
from Instructor i
group by i.Ins_Degree

--condition on aggregate function  [having]
select s.Dept_Id,count(St_Id) NoOfStudents
from Student s
group by s.Dept_Id
having count(St_Id)>3

--------------------------------------------------------
select *
from Instructor
where Salary*12>100000

select i.Ins_Name,i.Salary*12 as [Annual Salary]
from Instructor i

---------------------------------------------------------
---cartesian product
select * from Student
select * from Department

select *
from Student s,Department d


--------------------------------------------------
---Joins
-----Equi Join  [most recommended]
-----inner join
-----left outer join
-----right outer join

select *
from Student s,Department d
where s.Dept_Id=d.Dept_Id

select *
from Student s inner join Department d
on s.Dept_Id=d.Dept_Id


--retrieve students who have dept and also who havent
select *
from Student s left outer join Department d
on s.Dept_Id=d.Dept_Id


select *
from Student s right outer join Department d
on s.Dept_Id=d.Dept_Id


------------------------------------------------------

select s.St_Fname,s.St_Lname,c.Crs_Name
from Student s,Course c ,Stud_Course sc
where s.St_Id=sc.St_Id
and sc.Crs_Id=c.Crs_Id

------------------------------------------------------
select s.St_Fname,s.St_Lname,c.Crs_Name,t.Top_Name
from Student s,Course c,Stud_Course sc,Topic t
where s.St_Id=sc.St_Id
and sc.Crs_Id=c.Crs_Id
and c.Top_Id=t.Top_Id

-------------------------------------------------------
select s.St_Fname,s.St_Lname,d.Dept_Name,t.Top_Name
from Student s,Department d,Stud_Course sc,Course c,Topic t
where s.St_Id=sc.St_Id
and sc.Crs_Id=c.Crs_Id
and c.Top_Id=t.Top_Id
and s.Dept_Id=d.Dept_Id
and s.St_Fname like 'a%'
-----------------------------------------------------------
---deptid,deptname,# of students
select d.Dept_Id,d.Dept_Name,COUNT(s.St_Id) #OfStudents
from Department d,Student s
where s.Dept_Id=d.Dept_Id
group by d.Dept_Id,d.Dept_Name

-----------------------------------------------------------
---display all managers[instructor that manages department]
select i.Ins_Name,d.Dept_Name
from Instructor i ,Department d
where d.Dept_Manager=i.Ins_Id

---display instructor and his/her department [works for]
select i.Ins_Name,d.Dept_Name
from Department d,Instructor i
where i.Dept_Id=d.Dept_Id

-----------------------------------------------------

select distinct St_Age
from Student

------------------------------------------------------
----nested select is the worst select ever
select *
from Student
where St_Age>(select avg(st_age) from Student)

declare @age int
select @age=avg(st_age) from student
select *
from Student
where St_Age>@age

-----------------------------------------------
--recursive relationship
select std.St_Fname+' '+std.St_Lname as [Student Name],supervisor.St_Fname+' '+supervisor.St_Lname as [supervisor Name]
from Student std,Student supervisor
where std.St_super=supervisor.St_Id

--------------------------------------------------