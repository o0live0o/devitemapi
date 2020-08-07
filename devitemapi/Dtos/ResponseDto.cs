using devitemapi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Dtos
{
    public class ResponseDto
    {
        public ResponseDto()
        {
            Code = ReqStatus.Success;
            Message = "请求成功";
        }

        /// <summary>
        /// 响应代码
        /// </summary>
        public ReqStatus Code { get; set; }
        
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
            Code = ReqStatus.Error;
            Message = msg;
        }
        public void SetSuccess(string msg = "请求成功")
        {
            Code = ReqStatus.Success;
            Message = msg;
        }

        public void SetData(object o)
        {
            Message = "获取数据成功";
            Code = ReqStatus.Success;
            Data = o;
        }
    }
}
