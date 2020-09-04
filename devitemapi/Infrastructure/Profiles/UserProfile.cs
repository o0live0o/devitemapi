using AutoMapper;
using devitemapi.Dto;
using devitemapi.Dto.User;
using devitemapi.Entity;
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
                .ForMember(p => p.Name, opt => opt.MapFrom(src => src.UserName))
                .ForMember(p => p.UserId, opt => opt.MapFrom(src => src.Id));

            CreateMap<UserDto, DevUser>()
                .ForMember(p => p.UserName, opt => opt.MapFrom(src => src.Name));

            CreateMap<UserAddDto, DevUser>()
                .ForMember(p => p.UserName, opt => opt.MapFrom(src => src.Name));

            CreateMap<UserUpdateDto, DevUser>()
                .ForMember(p => p.UserName, opt => opt.MapFrom(src => src.Name));
        }
    }
}
