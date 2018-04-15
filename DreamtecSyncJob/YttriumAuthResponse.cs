using System;

namespace DreamtecSyncJob
{
    public class YttriumAuthResponse
    {
        public string AccessToken { get; set; }
        public string Error { get; set; }
        public DateTime TokenExpiry { get; set; }
    }
}
