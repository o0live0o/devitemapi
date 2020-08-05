using devitemapi.Common;
using devitemapi.Dtos;
using devitemapi.Entities;
using devitemapi.Infrastructure.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Infrastructure.Services
{
    public class LoginService : ILoginService
    {
        private readonly DevDbContext m_dbContext;

        public LoginService(DevDbContext dbContext)
        {
            this.m_dbContext = dbContext;
        }

        public ResponseDto GetMenuTree(string userId)
        {
            throw new NotImplementedException();
        }

        public ResponseDto GetMenuTreeByUser(string userId)
        {
            throw new NotImplementedException();
        }

        public ResponseDto GetPowerByUser(string userId)
        {
            throw new NotImplementedException();
        }

        public ResponseDto Login(string userName, string pwd)
        {
            ResponseDto response = new ResponseDto();
            var user = m_dbContext.DevUsers.Where(u=>userName.Equals(u.UserName) && pwd.Equals(u.Pwd));
            if (user == null)
                response.SetFail(MessageTxt.ERROR_LOGIN_MISS_USERORPWD);
            else
            {
                response.SetSuccess(MessageTxt.PASS_LOGIN);
                //TODO JWT
            }
            return response;
        }
    }
}
