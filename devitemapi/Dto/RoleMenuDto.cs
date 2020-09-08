/*
 * @Author: live0x 
 * @Date: 2020-09-07 17:59:41 
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-07 18:02:37
 */
using System;
using System.Collections.Generic;

namespace devitemapi.Dto
{
    public class TreeDto
    {
        public List<string> Roles{get;set;} = new List<string>();

        public List<TreeMenuDto> Trees {get;set;} = new List<TreeMenuDto>(); 
    }

    public class TreeMenuDto
    {
        public string MenuName { get; set; }
        public string MenuCode { get; set; }
        public string Path { get; set; }
        public string Icon { get; set; }
        public List<TreeMenuDto> Children {get;set;} = new List<TreeMenuDto>();
        public List<TreeActionDto> Actions {get;set;} = new List<TreeActionDto>();
    }

    public class TreeActionDto
    {
        public string ActionName { get; set; }
        public string ActionCode { get; set; }
    }

    public class RoleMenuDto
    {
        public string RoleName { get; set; }
        public string RoleCode { get; set; }
        public string MenuName { get; set; }
        public string MenuCode { get; set; }
        public string Path { get; set; }
        public string Icon { get; set; }
        public string ActionName { get; set; }
        public string ActionCode { get; set; }
        public Guid MenuParentId { get; set; }
        public Guid MenuId {get;set;}

    }
}