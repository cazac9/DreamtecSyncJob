using Microsoft.Rest;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace DreamtecSyncJob
{
    public class AcumaticaLoginCredentials : ServiceClientCredentials
    {
        private readonly string _url;
        private readonly string _userName;
        private readonly string _password;
        private readonly string _company;

        private readonly CookieContainer _cookies;

        private HttpClient _httpClient;


        public AcumaticaLoginCredentials(string url, string userName, string password, string company, CookieContainer cookies)
        {
            _url = url;
            _userName = userName;
            _password = password;
            _company = company;

            _cookies = cookies;
        }

        public override void InitializeServiceClient<T>(ServiceClient<T> client)
        {
            _httpClient = new HttpClient(new HttpClientHandler
                {
                    UseCookies = true,
                    CookieContainer = new CookieContainer()
                })
            {
                BaseAddress = new Uri(_url),
                DefaultRequestHeaders =
                {
                    Accept = {MediaTypeWithQualityHeaderValue.Parse("text/json") }
                }
            };
        }
        public override async Task ProcessHttpRequestAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var authResult = await _httpClient.PostAsJsonAsync(
             _url, new
             {
                 name = _userName,
                 password = _password,
                 company = _company,
             });

            var cookies = authResult.Headers.GetValues("Set-Cookie").Select(t => t.Split(';').First());

            foreach (var cookie in cookies)
            {
                var kvp = cookie.Split('=');
                _cookies.Add(new Cookie(kvp.First(), kvp.LastOrDefault(), "/", new Uri(_url).Host));
            }
        }
    }
}
