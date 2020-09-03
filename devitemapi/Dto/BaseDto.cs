/*
 * @Author: live0x 
 * @Date: 2020-09-03 14:55:41 
 * @Last Modified by:   live0x 
 * @Last Modified time: 2020-09-03 14:55:41 
 */
using System;

namespace devitemapi.Dto
{
    public class BaseDto
    {
        public int OperatorId { get; set; }
        public string Operator { get; set; }
        public DateTime OperateDate { get; set; }
    }
}