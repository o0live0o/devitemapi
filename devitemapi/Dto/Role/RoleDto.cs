/*
 * @Author: live0x
 * @Date: 2020-09-07 09:33:25
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-09 17:03:10
 */

using System;
using System.Collections.Generic;
using devitemapi.Dto.Permission;

namespace devitemapi.Dto.Role
{
    public class RoleDto : BaseDto
    {
        public Guid Id { get; set; }
        public string ActionName { get; set; }

        public string ActionCode { get; set; }

    }
}