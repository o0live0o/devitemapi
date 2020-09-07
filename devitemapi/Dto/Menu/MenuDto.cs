/*
 * @Author: live0x
 * @Date: 2020-09-07 09:33:42
 * @Last Modified by:   live0x
 * @Last Modified time: 2020-09-07 09:33:42
 */

using System;

namespace devitemapi.Dto.Menu
{
    public class MenuDto : BaseDto
    {
        public Guid Id { get; set; }
        public string MenuName { get; set; }

        public int ParentId { get; set; }

        public string Url { get; set; }

        public string Icon { get; set; }
    }
}