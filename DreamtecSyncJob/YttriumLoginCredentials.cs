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
    public class YttriumLoginCredentials : ServiceClientCredentials
    {
        private readonly string _url;
        private readonly string _userName;
        private readonly string _password;
        private readonly string _clientId;

        private HttpClient _httpClient;

        public YttriumLoginCredentials(string url, string userName, string password, string clientId)
        {
            _url = url;
            _userName = userName;
            _password = password;
            _clientId = clientId;
        }

        public override void InitializeServiceClient<T>(ServiceClient<T> client)
        {
            _httpClient = new HttpClient
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
            if (TokenManager.IsTokenExpired)
            {
                var authResult = await _httpClient.PostAsJsonAsync(
                     _url, new
                     {
                         Username = _userName,
                         Password = _password,
                         ClientId = _clientId,
                     });

                var content = await authResult.Content.ReadAsAsync<YttriumAuthResponse>();

                TokenManager.SetToken(content.AccessToken, content.TokenExpiry);
            }
            
            request.Headers.Add("Authorization", "Bearer " + TokenManager.Token);
        }
    }
}
