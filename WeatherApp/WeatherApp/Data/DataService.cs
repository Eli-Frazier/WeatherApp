using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.Data
{
    class DataService
    {     
        public static async Task<dynamic> getDataFromService(string queryString)     
        {

            dynamic data = null;
            try
            {
                var client = new HttpClient();
                var response = await client.GetAsync(queryString);
               
                if (response != null)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    data = JsonConvert.DeserializeObject(json);
                }               
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return data;
        }
    }
}


