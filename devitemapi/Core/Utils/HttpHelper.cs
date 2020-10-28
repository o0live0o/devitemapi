using System.Collections.Generic;
using System.Net.Http;

namespace devitemapi.Core.Utils
{
    public class HttpHelper
    {

       public void DownloadAsync()
       {
            IHttpClientFactory httpClient = null;
            
       }

        public HttpRequestMessage GenerateHttpRequestMessage(HttpMethod httpMethod,Dictionary<string,string> dicHeader)
        {
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage();
            httpRequestMessage.Method = httpMethod;
            httpRequestMessage.Headers.TryAddWithoutValidation("User-Agent",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_3) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.149 Safari/537.36 Edg/80.0.361.69");
            
            foreach(var item in dicHeader)
            {
                httpRequestMessage.Headers.TryAddWithoutValidation(item.Key,item.Value);
            }

            return httpRequestMessage;
        }

    }
}