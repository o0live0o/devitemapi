using AutoMapper;
using devitemapi.Dto.User;
using devitemapi.Entity;

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

            CreateMap<UserAddOrUpdateDto, DevUser>()
                .ForMember(p => p.UserName, opt => opt.MapFrom(src => src.Name));

            CreateMap<UserAddOrUpdateDto, DevUser>()
                .ForMember(p => p.UserName, opt => opt.MapFrom(src => src.Name));
        }
    }
}