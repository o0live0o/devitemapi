using devitemapi.Common;
using devitemapi.Dto;
using devitemapi.Entity;
using devitemapi.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Services
{
    public class MenuService : IMenuService
    {
        private readonly DevDbContext _dbContext;

        public MenuService(DevDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public Task<ResponseDto> Add(DevMenu menu)
        {
            return Task.Run(() =>
            {
                ResponseDto response = new ResponseDto();
                _dbContext.DevMenus.Add(menu);
                _dbContext.SaveChanges();
                return response;
            });
        }

        public Task<ResponseDto> Delete(int id)
        {
            return Task.Run(() =>
            {
                ResponseDto response = new ResponseDto();
                var menu = _dbContext.DevMenus.Find(id);
                if (menu != null)
                    _dbContext.DevMenus.Remove(menu);
                _dbContext.SaveChanges();
                return response;
            });
        }

        public Task<ResponseDto> Delete(string ids)
        {
            return Task.Run(() =>
            {
                ResponseDto response = new ResponseDto();
                string delSql = $"DELETE DevMenu WHERE Id IN ({ids})";
                _dbContext.Database.ExecuteSqlRaw(delSql);
                _dbContext.SaveChanges();
                return response;
            });
        }

        public Task<ResponseDto> Get(int id)
        {
            return Task.Run(() =>
            {
                ResponseDto response = new ResponseDto();
                var menu = _dbContext.DevMenus.Find(id);
                if (menu == null)
                    response.SetFail(MessageTxt.EMPTY_SEARCH);
                else
                    response.SetData(menu);
                return response;
            });
        }

        public Task<ResponseDto> Get()
        {
            return Task.Run(() =>
            {
                ResponseDto response = new ResponseDto();
                var menus = _dbContext.DevMenus;
                if (menus == null || menus.Count() < 1)
                    response.SetFail(MessageTxt.EMPTY_SEARCH);
                else
                    response.SetData(menus);
                return response;
            });
        }

        public Task<ResponseDto> Modify(DevMenu menu)
        {
            return Task.Run(() => {
                ResponseDto response = new ResponseDto();
                var entity = _dbContext.DevMenus.Find(menu.Id);
                if (entity != null)
                {
                    entity.MenuName = menu.MenuName;
                    entity.Url = menu.Url;
                    entity.ParentId = menu.ParentId;
                    entity.ModifyDate = DateTime.Now;
                    _dbContext.SaveChanges();
                }
                else
                    response.SetFail(MessageTxt.ERROR_MODIFY);
                return response;
            });
        }
    }
}
