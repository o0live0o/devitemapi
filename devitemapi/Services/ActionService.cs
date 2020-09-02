using devitemapi.Common;
using devitemapi.Dto;
using devitemapi.Entity;
using devitemapi.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Services
{
    public class ActionService : IActionService
    {
        private readonly DevDbContext _dbContext;

        public ActionService(DevDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public Task<ResponseDto> Add(DevAction action)
        {
            return Task.Run(() =>
            {
                ResponseDto response = new ResponseDto();
                _dbContext.DevActions.Add(action);
                _dbContext.SaveChanges();
                return response;
            });
        }

        public Task<ResponseDto> Delete(int id)
        {
            return Task.Run(() =>
            {
                ResponseDto response = new ResponseDto();
                var action = _dbContext.DevActions.Find(id);
                if (action != null)
                    _dbContext.DevActions.Remove(action);
                _dbContext.SaveChanges();
                return response;
            });
        }

        public Task<ResponseDto> Delete(string ids)
        {
            return Task.Run(() =>
            {
                ResponseDto response = new ResponseDto();
                string delSql = $"DELETE DevAction WHERE Id IN ({ids})";
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
                var action = _dbContext.DevActions.Find(id);
                if (action == null)
                    response.SetFail(MessageTxt.EMPTY_SEARCH);
                else
                    response.SetData(action);
                return response;
            });
        }

        public Task<ResponseDto> Get()
        {
            return Task.Run(() =>
            {
                ResponseDto response = new ResponseDto();
                var actions = _dbContext.DevActions;
                if (actions == null || actions.Count() < 1)
                    response.SetFail(MessageTxt.EMPTY_SEARCH);
                else
                    response.SetData(actions);
                return response;
            });
        }

        public Task<ResponseDto> Modify(DevAction action)
        {
            return Task.Run(() =>
            {
                ResponseDto response = new ResponseDto();

                var entity = _dbContext.DevActions.Find(action.Id);
                if (entity != null)
                {
                    entity.ActionCode = action.ActionCode;
                    entity.ActionName = action.ActionName;
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