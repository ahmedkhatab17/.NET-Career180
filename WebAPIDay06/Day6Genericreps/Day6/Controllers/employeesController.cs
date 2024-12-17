using Day6.DTOs.EmployeeDTO;
using Day6.Models;
using Day6.Repository;
using Day6.Repository.OldClass;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Day6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class employeesController : ControllerBase
    {
        GenericRepository<Employee> _reps;

        public employeesController(GenericRepository<Employee> _reps)
        {
            this._reps =_reps;
        }

        [HttpGet]
        public IActionResult getall()
        {
            //  List<Employee> emps= Db.Employees.Include(n=>n.dept).ToList();
            List<Employee> emps = _reps.selectall();
            List<DisplayemployeeDTO> empsDTO = new List<DisplayemployeeDTO>();
            foreach (Employee item in emps) {
                DisplayemployeeDTO employeeDTO = new DisplayemployeeDTO()
                {
                    name = item.name,
                    age = item.age,
                    salary = item.salary,
                    hiredate = item.hiredate,
                    departmentName = item.dept.name
                };
            empsDTO.Add(employeeDTO);
            }

            return Ok(empsDTO);
        }

        [HttpGet("{id}")]
        public IActionResult getbyid(int id)
        {
            // Employee emp = Db.Employees.Include(n=>n.dept).FirstOrDefault(n => n.id == id);
            Employee emp = _reps.selectbyid(id);
            if (emp == null) return NotFound();

            else
            {
                DisplayemployeeDTO empDTO = new DisplayemployeeDTO()
                {
                    name = emp.name,
                    age = emp.age,
                    salary = emp.salary,
                    hiredate = emp.hiredate,
                    departmentName = emp.dept.name
                };
                return Ok(empDTO);
            }
                
        }

        [HttpPost]
        public IActionResult add(addemployeeDTO empDTO)
        {
            if (ModelState.IsValid)
            {
                Employee em = new Employee()
                {
                    name = empDTO.name,
                    age = empDTO.age,
                    salary = empDTO.salary,
                    hiredate = empDTO.hiredate,
                    deptid = empDTO.deptid,
                };
                _reps.add(em);
                _reps.save();
                return Ok(em);

            }
            else
                return BadRequest(ModelState);
        }
    }
}
