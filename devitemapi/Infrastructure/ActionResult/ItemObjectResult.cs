using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace devitemapi.Infrastructure.ActionResult
{
    public class ItemObjectResult : ObjectResult
    {
        public ItemObjectResult(object value,int statusCode) : base(value)
        {
            StatusCode = statusCode;
        }
    }
}