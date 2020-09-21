/*
 * @Author: live0x 
 * @Date: 2020-09-21 11:07:57 
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-21 11:55:00
 */
using System.Collections.Generic;
using devitemapi.Dto.Action;
using devitemapi.Dto.Menu;

namespace devitemapi.Dto.MenuAction
{
    public class MenuActionsDto
    {
        public MenuDto Menu { get; set; }

        public List<ActionDto> Actions { get; } = new List<ActionDto>();
    }
}