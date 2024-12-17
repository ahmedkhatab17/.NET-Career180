using AutoMapper;
using Day6.DTOs.EmployeeDTO;
using Day6.Models;
namespace Day6.MppingConfigs
{
    public class MappingConfig:Profile
    {
        public MappingConfig()
        {
            CreateMap<Employee, addemployeeDTO>().ReverseMap();
            CreateMap<Employee, DisplayemployeeDTO>().AfterMap(
                (src, dest) =>
                {
                    dest.departmentName = src.dept.name;
                });
        }
    }
}
