using System;

namespace DreamtecSyncJob
{
    public class TokenManager
    {
        static TokenManager()
        {
            ExpiryDate = DateTime.UtcNow;
        }

        public static bool IsTokenExpired
        {
            get
            {
                return DateTime.UtcNow > ExpiryDate.AddSeconds(-10);
            }
        }

        public static string Token { get; private set; }

        private static DateTime ExpiryDate { get; set; }

        public static void SetToken(string token, DateTime expiryDate)
        {
            Token = token;
            ExpiryDate = expiryDate;
        }
    }
}
