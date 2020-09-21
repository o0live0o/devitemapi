/*
 * @Author: live0x
 * @Date: 2020-09-07 09:33:25
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-21 16:39:15
 */

using System;
using System.Collections.Generic;
using devitemapi.Dto.Permission;

namespace devitemapi.Dto.Role
{
    public class RoleDto : BaseDto
    {
        public Guid RoleId { get; set; }
        public string RoleName { get; set; }

        public string RoleCode { get; set; }

    }
}