/*
 * @Author: live0x 
 * @Date: 2020-10-29 10:06:57 
 * @Last Modified by: live0x
 * @Last Modified time: 2020-10-29 10:27:54
 */
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using devitemapi.Core.Utils;
using devitemapi.Dto.Wbl;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace devitemapi.Core.Wbl
{
    public class WblSpider
    {
        private const string BASE_URL = "https://api-wanbaolou.xoyo.com/api/";
        private readonly HttpHelper _httpHelper;

        public WblSpider(HttpHelper httpHelper)
        {
            this._httpHelper = httpHelper;
        }
        public List<WblGateWayDto> GetGateWays()
        {
            var url = Path.Combine(BASE_URL, "platform/setting/gateways");
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            var response = webRequest.GetResponse();
            var stream = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            var result = sr.ReadToEndAsync().Result;
            // Console.WriteLine(result);
            JObject obj = JsonConvert.DeserializeObject<JObject>(result);
            var s = obj["data"]["list"].ToString();
            var GateWays = JsonConvert.DeserializeObject<List<WblGateWayDto>>(s);
            if (GateWays.Count > 0)
                Console.WriteLine($"获取服务器数据成功:{GateWays.Count}");
            else
                Console.WriteLine("获取服务器数据失败");
            return GateWays;
        }

        public void GetGoldPrice(List<WblGateWayDto> gateWays)
        {
            ConcurrentDictionary<string,List<WblGoldDto>> dic = new ConcurrentDictionary<string, List<WblGoldDto>>();
            List<Action> actions = new List<Action>();
            foreach(var gateWay in gateWays)
            {
                if(gateWay.Servers == null) continue;
                foreach(var server in gateWay.Servers)
                {
                    actions.Add(async () => 
                    {
                        dic.TryAdd(server.Server_id,
                         await GetGoldPrice(gateWay.zone_id,server.Server_id));
                    });
                }
            }
            ParallelOptions parallelOptions = new ParallelOptions();
            parallelOptions.MaxDegreeOfParallelism = 10;
            Parallel.Invoke(parallelOptions, actions.ToArray());

        }

        public async Task<List<WblGoldDto>> GetGoldPrice(string zoneId,string serverId,int pageIndex = 1)
        {
            Console.WriteLine($"获取大区:{zoneId} 服务器{serverId} 第 {pageIndex} 页数据 ");
            List<WblGoldDto> list = new List<WblGoldDto>();
            var path = $"buyer/goods/list?zone_id={zoneId}&server_id={serverId}&game=jx3&page={pageIndex}&size=10&goods_type=1";
            var url = Path.Combine(BASE_URL, path);
            var result = await _httpHelper.DownloadAsync(url);
            JObject obj = JsonConvert.DeserializeObject<JObject>(result);
            var s = obj["data"]["list"].ToString();
            list.AddRange(JsonConvert.DeserializeObject<List<WblGoldDto>>(s));
            if(list.Count % 10 == 0)
            {
               pageIndex++;
               list.AddRange(await  GetGoldPrice(zoneId,serverId,pageIndex));
            }
            return list;
        }

    }
}