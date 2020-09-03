using devitemapi.Infrastructure.Message;
using Microsoft.AspNetCore.Mvc;

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
        public ValidateErrorResult(string message = ErrorTxt.VALIDATE_FAILED) : base(message)
        {

        }

        public object Error { get; set; }

    }


}