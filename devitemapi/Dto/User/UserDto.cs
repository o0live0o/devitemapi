/*
 * @Author: live0x
 * @Date: 2020-09-03 14:55:31
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-04 15:21:34
 */

using System;

namespace devitemapi.Dto.User
{
    public class UserDto : BaseDto
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }

        public string Account { get; set; }

        public string Address { get; set; }

        public string EMail { get; set; }

        public string Phone { get; set; }

        public int Status { get; set; }
    }
}