using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace devitemapi.Infrastructure.ActionResult
{
    public class WxObjectResult : ObjectResult
    {
        public WxObjectResult(object value,int statusCode) : base(value)
        {
            StatusCode = statusCode;
        }
    }
}