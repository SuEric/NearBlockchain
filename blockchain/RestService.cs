using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using blockchain.utils;
using Newtonsoft.Json.Linq;

namespace blockchain
{
    public class RestService: IRestService
    {
        HttpClient client;
        public RestService()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://swapi.co/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.MaxResponseContentBufferSize = 256000;
        }

        public async Task<List<User>> GetUsers()
        {
            var response = client.GetAsync("people").Result;

            if (response.IsSuccessStatusCode) {
                string content = await response.Content.ReadAsStringAsync();

                var results = JObject.Parse(content)["results"];
                return GenericJSON.JsonToObject<List<User>>(results.Value<string>());
            }

            return null;
        }
    }
}
