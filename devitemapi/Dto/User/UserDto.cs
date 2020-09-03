/*
 * @Author: live0x 
 * @Date: 2020-09-03 14:55:31 
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-03 15:07:18
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using devitemapi.Dto;

namespace devitemapi.Dto.User
{
    public class UserDto: BaseDto
    {
        public string Name { get; set; }

        public string Account { get; set; }

        public string Address { get; set; }

        public string EMail { get; set; }

        public string Phone{ get; set; }

        public int Status { get; set; }

    }
}
