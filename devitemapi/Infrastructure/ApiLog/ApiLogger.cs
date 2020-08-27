using devitemapi.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Infrastructure.Log
{
    public class ApiLogger : IApiLogger
    {
        Logger _logger = LogManager.GetCurrentClassLogger();
        public ApiLogger()
        {

        }

        public void Debug()
        {   
            LogEventInfo lei = new LogEventInfo();
            lei.Message = "测试";
            lei.Properties["logcontent"] = "debug";
            lei.Level = NLog.LogLevel.Debug;
            _logger.Log(lei);
        }

        public void Debug(LogDto log)
        {
            throw new NotImplementedException();
        }

        public void Error(LogDto log)
        {
          
        }

        public void Info(LogDto log)
        {

        }

        public void Trace(LogDto log)
        {

        }

        public void Warnnig(LogDto log)
        {

        }
    }
}
