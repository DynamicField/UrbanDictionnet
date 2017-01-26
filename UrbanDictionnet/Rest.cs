using RestSharp;
using System;
using System.Threading.Tasks;

namespace UrbanDictionnet
{
    internal static class Rest
    {
        private static Uri BaseUrl { get; } = new Uri("http://api.urbandictionary.com/v0/");
        public static T Execute<T>(IRestRequest req) where T : new()
        {
            var client = new RestClient {
                BaseUrl = BaseUrl
            };
            var response = client.Execute<T>(req);
            if (response.ErrorException != null)
            {
                throw new Exception("An error occured while resting lol",response.ErrorException);
            }
            return response.Data;
        }
        public async static Task<T> ExecuteAsync<T>(IRestRequest req) where T : new()
        {
            return await Task.Run(() => {
                var client = new RestClient
                {
                    BaseUrl = BaseUrl
                };
                var response = client.Execute<T>(req);
                if (response.ErrorException != null)
                {
                    throw new Exception("An error occured while resting lol", response.ErrorException);
                }
                return response.Data;
            });
            
        }
    }
}
