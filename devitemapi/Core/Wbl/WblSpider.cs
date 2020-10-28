/*
 * @Author: live0x 
 * @Date: 2020-10-28 11:55:40 
 * @Last Modified by:   live0x 
 * @Last Modified time: 2020-10-28 11:55:40 
 */
using System.Collections.Generic;
using System.Net.Http;
using devitemapi.Dto.Wbl;

namespace devitemapi.Core.Wbl
{
    public class WblSpider
    {
        private const string BASE_URL = "";

        public List<WblGateWayDto> GetGateWays()
        {
            return null;
        }

        public void GetGoldPrice(List<WblGateWayDto> gateWays)
        {
            foreach(var gateWay in gateWays)
            {
                if(gateWay.Servers == null) continue;
                foreach(var server in gateWay.Servers)
                {
                    GetGoldPrice(gateWay.zone_id,server.Server_id);
                }
            }
            HttpClient http = new HttpClient();
            HttpRequestMessage httpRequestMsg = new HttpRequestMessage();
            http.SendAsync(httpRequestMsg);
        }

        public void GetGoldPrice(string zoneId,string serverId)
        {
            
        }

    }
}