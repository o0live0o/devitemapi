/*
 * @Author: live0x 
 * @Date: 2020-10-28 10:45:24 
 * @Last Modified by: live0x
 * @Last Modified time: 2020-10-28 10:45:45
 */
using System.Collections.Generic;

namespace devitemapi.Dto.Wbl
{
    public class WblGateWayDto
    {
        public string zone_id { get; set; }

        public string zone_name { get; set; }

        public List<WblServerDto> Servers { get; set; }
    }
}