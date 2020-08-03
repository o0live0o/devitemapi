using devitemapi.Dtos;
using devitemapi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Infrastructure.Services.Interface
{
    public interface IActionService
    {
        ResponseDto AddAction(DevAction action);

        ResponseDto DeleteAction(int id);

        ResponseDto DeleteActions(string ids);

        ResponseDto ModifyAction(DevAction action);

        ResponseDto GetAction(int id);

        ResponseDto GetActions();
    }
}
