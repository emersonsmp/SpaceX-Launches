using MyApp.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Utils.Configurations
{
    public class HttpClientConfiguration
    {
        private const string MediaType = "application/json";
        private const string AcceptCharset = "UTF8";
        private const int RequestTime = 60000;

        public static void ConfigureHttpClient(HttpClient client)
        {
            client.BaseAddress = new Uri(AppConfigurationProvider.Instance.ApiUrl);
            client.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue("gzip"));
            client.DefaultRequestHeaders.AcceptCharset.Add(new StringWithQualityHeaderValue(AcceptCharset));
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(MediaType));
            client.DefaultRequestHeaders.TryAddWithoutValidation("X-ClientId", "");
            client.Timeout = TimeSpan.FromMilliseconds(RequestTime);
        }
    }
}
