/*
 * @Author: live0x
 * @Date: 2020-09-02 17:46:40
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-25 11:16:59
 */

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace devitemapi.Infrastructure.ActionResult
{
    public class InternalServerErrorObjectResult : ObjectResult
    {
        public InternalServerErrorObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status500InternalServerError;
        }
    }
}