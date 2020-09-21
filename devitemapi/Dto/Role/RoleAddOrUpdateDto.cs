/*
 * @Author: live0x
 * @Date: 2020-09-07 09:33:20
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-21 14:53:43
 */

using System.Collections.Generic;
using devitemapi.Dto.Permission;

namespace devitemapi.Dto.Role
{
    public class RoleAddOrUpdateDto : BaseDto
    {
        public string ActionName { get; set; }

        public string ActionCode { get; set; }

    }
}