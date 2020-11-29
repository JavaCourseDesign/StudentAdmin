using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace StudentAdmin
{
    public static class HttpClientHelper
    {
        private static readonly object LockObj = new object();
        private static HttpClient _client;

        public static async Task<string> GetAsync(string url)
        {
            if (_client == null)
            {
                lock (LockObj)
                {
                    _client ??= new HttpClient();
                }
            }
            return await _client.GetStringAsync(url);
        }
        
        public static string Get(string url)
        {
            if (_client == null)
            {
                lock (LockObj)
                {
                    _client ??= new HttpClient();
                }
            }
            return _client.GetStringAsync(url).Result;
        }
    }
}