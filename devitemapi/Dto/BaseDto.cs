﻿/*
 * @Author: live0x
 * @Date: 2020-09-03 14:55:41
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-21 14:42:27
 */

using System;

namespace devitemapi.Dto
{
    public class BaseDto
    {

    }

    public class OperatorDto : BaseDto
    {
        public Guid OperatorId { get; set; }
        public string Operator { get; set; }
        public DateTime OperateDate { get; set; }
    }

}