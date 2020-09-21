using AutoMapper;
using devitemapi.Dto.Role;
using devitemapi.Entity;

namespace devitemapi.Infrastructure.Profiles
{
    public class RoleProfile:Profile
    {
        public RoleProfile()
        {
            CreateMap<DevRole,RoleDto>().ForMember(p=>p.RoleId,opt =>opt.MapFrom(src => src.Id));
        }
    }
}