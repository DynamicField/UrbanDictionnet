using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrbanDictionnet.Entities;

namespace UrbanDictionnet
{
    public class UrbanClient
    {
        public async Task<WordDefine> GetWordAsync(string query)
        {
            return await Rest.ExecuteAsync<WordDefine>(new RestSharp.RestRequest
            {
                Resource = $"define?term={query}",
            });
        }
    }
}
