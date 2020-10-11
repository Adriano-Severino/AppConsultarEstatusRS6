using EstatusRs6.Core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace EstatusRs6.Core.Services
{
    public class UserService : Service , IUserServices
    {
        public async Task<Root> GetUser(string name)
        {
            
            HttpResponseMessage response = await _client.GetAsync($"{BaseApiUrl}/uplay/{name}");
            Root root = null;

            if (response.IsSuccessStatusCode)
            {
               
                var resultado =  await response.Content.ReadAsStringAsync();
                root = JsonConvert.DeserializeObject<Root>(resultado);
            }

            return root;
        }

        public async Task<List<Root>> GetUsers()
        {
            HttpResponseMessage response = await _client.GetAsync($"{BaseApiUrlLeaderboards}/windows/america");
             List<Root> root = null;

            if (response.IsSuccessStatusCode)
            {

                var resultado = await response.Content.ReadAsStringAsync();
                root = JsonConvert.DeserializeObject<List<Root>>(resultado);
            }

            return root;
        }

    }
}
