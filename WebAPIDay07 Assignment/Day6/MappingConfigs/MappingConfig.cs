using AutoMapper;
using Day6.DTOs.DepartmentDto;
using Day6.DTOs.EmployeeDTO;
using Day6.Models;

namespace Day6.MappingConfigs
{
    public class MappingConfig:Profile
    {
        public MappingConfig()
        {
            CreateMap<Employee, addemployeeDTO>().ReverseMap();
            CreateMap<Department, AddDepartmentDTo>().ReverseMap();
            CreateMap<Employee, DisplayemployeeDTO>().AfterMap(
                (src, des) =>
                {
                    des.departmentName = src.dept.name;
                }
            );
            CreateMap<Department,DisplayDepartmentDto>().ForMember(des => des.employeecount, opt => opt.MapFrom(src => src.Employees.Count())).ReverseMap();
        }
    }
}
