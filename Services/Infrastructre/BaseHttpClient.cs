using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Services.Infrastructre
{
    /// <summary>
    /// Http üzerinden istek atmak için temel sınıf
    /// GET
    /// POST
    /// PUT
    /// DELETE
    /// </summary>
    public class BaseHttpClient
    {
        private readonly HttpClient _httpClient;

        public BaseHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Get isteği atar ve sonucu belirtilen tipe deserialize eder
        /// Header ekleme imkanı sağlar
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="headers"></param>
        /// <returns></returns>
        internal async Task<T> GetAsync<T>(string url, Dictionary<string, string> headers = null)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, url);

                // Header ekleme
                if (headers != null)
                {
                    foreach (var header in headers)
                    {
                        request.Headers.Add(header.Key, header.Value);
                    }
                }

                var response = await _httpClient.SendAsync(request);

                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();

                var type = typeof(T);

                bool isList = typeof(IEnumerable).IsAssignableFrom(type)
                              && type != typeof(string);

                if (isList) 
                {
                    var result = JsonConvert.DeserializeObject<T>(json);

                    return result;
                }
                else
                {
                    var result = JsonConvert.DeserializeObject<List<T>>(json);

                    if (result.Count > 0) return result[0];

                    else return default(T);
                }                    
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
