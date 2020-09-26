using System;
using System.Net;

namespace devitemapi.Infrastructure.Exceptions
{
    public class ItemException : Exception
    {
        public HttpStatusCode ItemCode = HttpStatusCode.BadRequest;
        
        public ItemException(string message,HttpStatusCode code = HttpStatusCode.BadRequest) : base(message)
        {
            ItemCode = code;
        }

        public ItemException(string message, Exception innerException,HttpStatusCode code = HttpStatusCode.BadRequest) : base(message, innerException)
        {
            ItemCode = code;
        }
    }
}