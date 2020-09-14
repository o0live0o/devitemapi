using AutoMapper;
using devitemapi.Entity;
using devitemapi.Infrastructure.Exceptions;
using devitemapi.Infrastructure.Message;
using devitemapi.Infrastructure.Repositories.Interface;
using devitemapi.Services.Interface;
using System;
using System.Linq;

namespace devitemapi.Services
{
    public class MenuService : BaseService<DevMenu>, IMenuService
    {

        public MenuService(IBaseRepository<DevMenu> repository) : base(repository)
        {
        }

        public override async void Add(DevMenu menu)
        {
            if (string.IsNullOrEmpty(menu.MenuName))
            {
                throw new ItemException(TipsTxt.MENU_MENUNAME_EMPTY);
            }
            var menus = await QueryAsync(r => r.MenuName == menu.MenuName);
            if (menus != null || menus.Count() > 0)
            {
                throw new ItemException(TipsTxt.MENU_ALREADY_EXISTS);
            }
            menu.Id = Guid.NewGuid();
            base.Add(menu);
        }
    }
}