using devitemapi.Common;
using devitemapi.Dtos;
using devitemapi.Entities;
using devitemapi.Infrastructure.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Infrastructure.Services
{
    public class MenuService : IMenuService
    {
        private readonly DevDbContext m_dbContext;

        public MenuService(DevDbContext dbContext)
        {
            this.m_dbContext = dbContext;
        }

        public Task<ResponseDto> Add(DevMenu menu)
        {
            return Task.Run(() =>
            {
                ResponseDto response = new ResponseDto();
                m_dbContext.DevMenus.Add(menu);
                m_dbContext.SaveChanges();
                return response;
            });
        }

        public Task<ResponseDto> Delete(int id)
        {
            return Task.Run(() =>
            {
                ResponseDto response = new ResponseDto();
                var menu = m_dbContext.DevMenus.Find(id);
                if (menu != null)
                    m_dbContext.DevMenus.Remove(menu);
                m_dbContext.SaveChanges();
                return response;
            });
        }

        public Task<ResponseDto> Delete(string ids)
        {
            return Task.Run(() =>
            {
                ResponseDto response = new ResponseDto();
                string delSql = $"DELETE DevMenu WHERE Id IN ({ids})";
                m_dbContext.Database.ExecuteSqlRaw(delSql);
                m_dbContext.SaveChanges();
                return response;
            });
        }

        public Task<ResponseDto> Get(int id)
        {
            return Task.Run(() =>
            {
                ResponseDto response = new ResponseDto();
                var menu = m_dbContext.DevMenus.Find(id);
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
                var menus = m_dbContext.DevMenus;
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
                var entity = m_dbContext.DevMenus.Find(menu.Id);
                if (entity != null)
                {
                    entity.MenuName = menu.MenuName;
                    entity.Url = menu.Url;
                    entity.ParentId = menu.ParentId;
                    entity.ModifyDate = DateTime.Now;
                    m_dbContext.SaveChanges();
                }
                else
                    response.SetFail(MessageTxt.ERROR_MODIFY);
                return response;
            });
        }
    }
}
