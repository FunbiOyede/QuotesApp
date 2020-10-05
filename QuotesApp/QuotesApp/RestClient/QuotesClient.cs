using Newtonsoft.Json;
using QuotesApp.model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace QuotesApp.RestClient
{
   public class QuotesClient<T>
    {
        private  string URL = "https://type.fit/api/quotes";
        public async Task<List<T>> GetQuotes()
        {
            try
            {
                var client = new HttpClient();
                var content = await client.GetStringAsync(URL);
                var data = JsonConvert.DeserializeObject<List<T>>(content);
                return data;

            }
            catch (Exception ex)
            {

                throw ex;
            }
          
        }
    }
}
