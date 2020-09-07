/*
 * @Author: live0x
 * @Date: 2020-09-07 08:58:15
 * @Last Modified by:   live0x
 * @Last Modified time: 2020-09-07 08:58:15
 */

using devitemapi.Infrastructure.Message;

namespace devitemapi.Infrastructure.ActionResult
{
    public class ErrorResult
    {
        public ErrorResult(string message)
        {
            this.Message = message;
        }

        public string Message { get; set; }
    }

    public class ValidateErrorResult : ErrorResult
    {
        public ValidateErrorResult(string message = TipsTxt.VALIDATE_FAILED) : base(message)
        {
        }

        public object Error { get; set; }
    }
}