using AutoMapper;
using devitemapi.Dtos;
using devitemapi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Infrastructure.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<DevUser, UserDto>()
                .ForMember(p => p.Name, opt => opt.MapFrom(src => src.UserName));
            CreateMap<UserDto, DevUser>()
                .ForMember(p => p.UserName, opt => opt.MapFrom(src => src.Name));
        }
    }
}
