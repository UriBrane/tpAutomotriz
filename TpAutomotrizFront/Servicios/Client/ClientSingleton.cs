using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpAutomotrizFront.Servicios.Client
{
    public class ClientSingleton
    {
        private static ClientSingleton instance;
        private HttpClient client;
        private ClientSingleton()
        {
            client = new HttpClient();
        }
        public static ClientSingleton GetInstance()
        {
            if (instance == null)
                instance = new ClientSingleton();
            return instance;
        }

        // CRUD
        public async Task<string> GetAsync(string url)
        {
            var result = await client.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            return content;
        }

        public async Task<string> PostAsync(string url, string data)
        {
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var result = await client.PutAsync(url, content);
            var response = "";
            if (result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();
            return response;
        }

    }
}
