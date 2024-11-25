select s.St_Id, CONCAT(s.st_fname,' ',s.St_Lname) as FullName from Student s

select c.Crs_Id, c.Crs_Name, c.Crs_Duration from Stud_Course sc ,Course c where sc.crs_id =c.crs_id and sc.St_Id = 


select * from Student
update Student set st_fname = @fn ,st_lname = @ln,st_address = @address where st_id =@id
