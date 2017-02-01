using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrbanDictionnet.Entities;
using static System.Security.SecurityElement;
using RestSharp;
namespace UrbanDictionnet
{
    /// <summary>
    /// The main UrbanClient to instanciate in order to use the functions.
    /// </summary>
    public class UrbanClient
    {
        /// <summary>
        /// Get a definiton using a string as query.
        /// </summary>
        /// <param name="query">The query to request, will be escaped later</param>
        /// <returns>When awaited, a <see cref="WordDefine"/>.</returns>
        /// <exception cref="WordNotFoundException"/>
        /// <remarks>
        ///  Will throw <see cref="WordNotFoundException"/> if the returned <see cref="WordDefine.ResultType"/> is <see cref="ResultType.NoResults"/>
        /// </remarks>
        public async Task<WordDefine> GetWordAsync(string query)
        {
            var result = await Rest.ExecuteAsync<WordDefine>(new RestRequest
            {
                Resource = $"define?term={Escape(query)}",
            });
            if (result.ResultType == ResultType.NoResults)
            {
                throw new WordNotFoundException($"The word {query} wasn't found.");
            }
            return result;
        }
        /// <summary>
        /// Get a definiton using a definition id (defid) as query.
        /// </summary>
        /// <param name="defId">The definiton id to request.</param>
        /// <returns>When awaited, a <see cref="WordDefine"/></returns>
        /// <exception cref="WordNotFoundException"/>
        /// <remarks>
        ///  Will throw <see cref="WordNotFoundException"/> if the returned <see cref="WordDefine.ResultType"/> is <see cref="ResultType.NoResults"/>
        /// </remarks>
        public async Task<WordDefine> GetWordAsync(int defId)
        {
            if (defId <= 0)
            {
                throw new ArgumentException("The definition id is equal or lower than 0.");
            }
            var result = await Rest.ExecuteAsync<WordDefine>(new RestRequest
            {
                Resource = $"define?defid={defId}",
            });
            if (result.ResultType == ResultType.NoResults)
            {
                throw new WordNotFoundException($"The definition with the id {defId} wasn't found.");
            }
            return result;
        }
        /// <summary>
        /// Get a random word from the API.
        /// </summary>
        /// <returns>When awaited, a <see cref="WordDefine"/>.</returns>
        public async Task<WordDefine> GetRandomWordAsync()
        {
            return await Rest.ExecuteAsync<WordDefine>(new RestRequest("random"));
        }
    }
}
