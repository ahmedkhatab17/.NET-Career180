using Day6.Models;
using Day6.Repository;
using Day6.UnitOfWorks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class empDeptController : ControllerBase
    {
        //GenericRepository<Employee> _empreps;
        //GenericRepository<Department> _deptrep;
        //public empDeptController(GenericRepository<Employee> _empreps , GenericRepository<Department> _deptrep)
        //{
        //    this._empreps = _empreps;
        //    this._deptrep = _deptrep;
        //}

        UnitOfWork _unit;
        public empDeptController(UnitOfWork _unit)
        {
            this._unit = _unit;
        }

        [HttpGet]
        public IActionResult getall ()
        {
            List<Employee> emps = _unit.empreps.selectall();
            List<Department> depts= _unit.deptrep.selectall();
            var ob = new { employees = emps, department = depts };
            return Ok(ob);
        }
       

        [HttpPost]
        public IActionResult add(Employee emp)
        {
            _unit.deptrep.add(emp.dept);
           // _deptrep.save();
            _unit.empreps.add(emp);
            _unit.save();
            return Ok();
        }
    }
}
