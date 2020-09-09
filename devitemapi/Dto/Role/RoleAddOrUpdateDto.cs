/*
 * @Author: live0x
 * @Date: 2020-09-07 09:33:20
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-09 16:21:51
 */

using System.Collections.Generic;
using devitemapi.Dto.Permission;

namespace devitemapi.Dto.Role
{
    public class RoleAddOrUpdateDto : BaseDto
    {
        public string ActionName { get; set; }

        public string ActionCode { get; set; }

        public ICollection<PermissionDto> Permissions {get;set;}
    }
}