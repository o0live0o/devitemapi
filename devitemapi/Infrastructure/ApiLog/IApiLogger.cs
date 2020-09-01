using devitemapi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Infrastructure.Log
{
    public interface IApiLogger
    {
        public void Trace(LogDto log);
        public void Debug(LogDto log);
        public void Info(LogDto log);
        public void Warnnig(LogDto log);
        public void Error(LogDto log);
        
    }
}
