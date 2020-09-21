using AutoMapper;
using devitemapi.Dto.Menu;
using devitemapi.Entity;

namespace devitemapi.Infrastructure.Profiles
{
    public class MenuProfile:Profile
    {
        public MenuProfile()
        {
            CreateMap<DevMenu,MenuDto>();
        }
    }
}