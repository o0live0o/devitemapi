using devitemapi.Dtos;
using devitemapi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Infrastructure.Services.Interface
{
    public interface IMenuService
    {
        Task<ResponseDto> Add(DevMenu menu);

        Task<ResponseDto> Delete(int id);

        Task<ResponseDto> Delete(string ids);

        Task<ResponseDto> Modify(DevMenu menu);

        Task<ResponseDto> Get(int id);

        Task<ResponseDto> Get();
    }
}
