using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace devitemapi.Core.Utils
{
    public class HttpHelper
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public HttpHelper(IHttpClientFactory httpClientFactory)
        {
            this._httpClientFactory = httpClientFactory;
        }

       public async Task<string> DownloadAsync(string url)
       {
            var httpClient = Create();
            var httpRequestMessage = GenerateHttpRequestMessage( url, HttpMethod.Get,new Dictionary<string, string>());
            var httpResponseMsg = await httpClient.SendAsync(httpRequestMessage);
            return await httpResponseMsg.Content.ReadAsStringAsync();
       }

        public HttpRequestMessage GenerateHttpRequestMessage(string url, HttpMethod httpMethod,Dictionary<string,string> dicHeader)
        {
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage();
            httpRequestMessage.Method = httpMethod;
            httpRequestMessage.RequestUri = new Uri(url);
            httpRequestMessage.Headers.TryAddWithoutValidation("User-Agent",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_3) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.149 Safari/537.36 Edg/80.0.361.69");
            
            foreach(var item in dicHeader)
            {
                httpRequestMessage.Headers.TryAddWithoutValidation(item.Key,item.Value);
            }

            return httpRequestMessage;
        }

        public HttpClient Create()
        {
            return _httpClientFactory.CreateClient();
        }

    }
}