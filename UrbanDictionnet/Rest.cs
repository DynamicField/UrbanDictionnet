using RestSharp;
using System;
using System.Threading.Tasks;
namespace UrbanDictionnet
{
    /// <summary>
    /// The rest client of this library.
    /// </summary>
    internal static class Rest
    {
        /// <summary>
        /// The base url.
        /// </summary>
        private static Uri BaseUrl { get; } = new Uri("http://api.urbandictionary.com/v0/");
        /// <summary>
        /// Execute a <see cref="IRestRequest"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="req"></param>
        /// <returns></returns>
        public async static Task<T> ExecuteAsync<T>(IRestRequest req) where T : new()
        {          
            
            var client = new RestClient
            {
                BaseUrl = BaseUrl
            };
            var response = await client.ExecuteTaskAsync<T>(req);
            if (response.ErrorException != null)
            {
                throw new Exception("An error occured while processing a REST request", response.ErrorException);
            }
            return response.Data;
        }
    }
}
