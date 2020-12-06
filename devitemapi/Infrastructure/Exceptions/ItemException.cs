using System;
using System.Net;

namespace devitemapi.Infrastructure.Exceptions
{
    public class WxException : Exception
    {
        public HttpStatusCode WxCode = HttpStatusCode.BadRequest;
        
        public WxException(string message,HttpStatusCode code = HttpStatusCode.BadRequest) : base(message)
        {
            WxCode = code;
        }

        public WxException(string message, Exception innerException,HttpStatusCode code = HttpStatusCode.BadRequest) : base(message, innerException)
        {
            WxCode = code;
        }
    }
}