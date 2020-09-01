using devitemapi.Dto;
using devitemapi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Services.Interface
{
    public interface IActionService
    {
        Task<ResponseDto> Add(DevAction action);

        Task<ResponseDto> Delete(int id);

        Task<ResponseDto> Delete(string ids);

        Task<ResponseDto> Modify(DevAction action);

        Task<ResponseDto> Get(int id);

        Task<ResponseDto> Get();
    }
}
