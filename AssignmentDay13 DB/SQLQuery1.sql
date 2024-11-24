--1. Display the Department id, name and id and the name of its manager.
select d.DeptId, d.DeptName, d.MgrSSN, CONCAT(e.FName,' ',e.LName) as ManagerName
from Department d
join Employee e on d.MgrSSN = e.SSN

--2. Display the name of the departments and the name of the projects under its control.
select d.DeptName, p.PName
from Department d
join Project p on d.DeptId = p.DeptId;

--3. Display the full data about all the dependence associated with the name of the employee they depend on him/her.
select d.* , CONCAT(e.FName,' ',e.LName) as ManagerName
from Department d
join Employee e on d.MgrSSN = e.SSN

--4. Display the Id, name and location of the projects in Cairo or Alex city.
select PId,PName,PLocation
from Project
where PLocation in('cairo','alex')

--5. Display the Projects full data of the projects with a name starts with "a" letter
select * from Project
where PName like 'a%'

--6. display all the employees in department 30 whose salary from 1000 to 2000 LE monthly
select * from Employee
where DeptId =30 and Salary between 10000 and 20000

--7. Retrieve the names of all employees in department 10 who works more than or equal10 hours per week on "AL Rabwah" project.
select CONCAT(e.FName,' ',e.LName) as EmployeeName 
from Employee e
join Employee_Project ep on e.SSN = ep.ESSN
join Project p on ep.PNO = p.PId
where e.DeptId = 10 and ep.Hours >= 10 --and p.PName = 'AL Rabwah'

--8. Find the names of the employees who directly supervised with Kamel Mohamed.
select CONCAT(e.FName,' ',e.LName) as EmployeeName 
from Employee e
join Employee ee on e.SuperSSN =ee.SSN
where CONCAT(ee.FName,' ',ee.LName) = 'Kamal Mohamed'
--9. Retrieve the names of all employees and the names of the projects they are working on, sorted by the project name.
select CONCAT(e.FName,' ',e.LName) as EmployeeName 
from Employee e
join Employee_Project ep on e.SSN= ep.essn
join Project p on ep.PNO = p.PId order by p.PName

--10. For each project located in Cairo City , find the project number, the controlling department name ,the department manager last name ,address and birthdate.
select p.PId, d.DeptName, e.LName ,e.Birthdate,e.Sex
from Project p
join Department d on p.DeptId = d.DeptId
join Employee e on d.MgrSSN = e.SSN
where p.PLocation ='cairo'

--11. Display All Data of the mangers
select * from Employee
where SSN in (select MgrSSN from Department)

--12. Display All Employees data and the data of their dependents even if they have no dependents
select e.*, d.*
from Employee e
join Dependent d on e.SSN= d.ESSN

------------------------------------------------------------------------------
--
insert into Employee (SSN, FName, LName, Birthdate, Sex, Salary, SuperSSN, DeptId)
values (12672, 'Ahmed', 'Ashraf', '5/17/2004', 'Male', 30000, 12233, 20);
--
insert into Employee (SSN, FName, LName, Birthdate, Sex, DeptId)
values (102660, 'Omar', 'Khatab', '1/1/2000', 'Male', 30);
--
update Employee
set Salary= Salary*1.2 where SSN = 12672

select * from Employee


