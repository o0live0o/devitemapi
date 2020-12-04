/*
 * @Author: live0x
 * @Date: 2020-09-07 09:33:53
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-09 17:56:35
 */

using System;

namespace devitemapi.Dto.Action
{
    
    public class ActionDto : BaseDto
    {
        public int ActionId { get; set; }
        
        public string ActionName { get; set; }

        public string ActionCode { get; set; }
    }
}