using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Common
{
    public class ResponseDto
    {
        public ResponseDto()
        {
            Code = 200;
            Message = "请求成功";
        }

        /// <summary>
        /// 响应代码
        /// </summary>
        public int Code { get; set; }
        
        /// <summary>
        /// 响应信息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 响应数据
        /// </summary>
        public object Data { get; set; }
        
        public void SetFail(string msg = "请求异常")
        {
            Code = 400;
            Message = msg;
        }
        public void SetSuccess(string msg = "请求成功")
        {
            Code = 200;
            Message = msg;
        }
    }
}
