using devitemapi.Dto;
using devitemapi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Services.Interface
{
    public interface IUserService
    {
        Task<ResponseDto> Add(DevUser user);

        Task<ResponseDto> Delete(int id);

        Task<ResponseDto> Delete(string ids);

        Task<ResponseDto> Modify(DevUser user);

        Task<ResponseDto> Get(int id);

        Task<ResponseDto> Get();
    }
}
