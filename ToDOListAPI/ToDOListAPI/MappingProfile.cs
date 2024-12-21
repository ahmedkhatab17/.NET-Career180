using AutoMapper;
using ToDOListAPI.DTOs;

namespace ToDOListAPI
{
    public class MappingProfile:Profile
    {
        public MappingProfile() {

            CreateMap<Models.Task, DTOs.TaskDTO>().ReverseMap();
            CreateMap<DTOs.CreateTaskDTO, Models.Task>();
            CreateMap<DTOs.UpdateTaskDTO, Models.Task>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

        }
    }
}
