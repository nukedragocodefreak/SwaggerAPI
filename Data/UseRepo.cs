using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SwaggerAPI.Models.Data
{
    public class UseRepo : Repo
    {
         private static string baseUrlChuck = "https://api.chucknorris.io/jokes/";
          private static string baseUrlSwapi = "https://swapi.dev/api/";

          
         public async Task<Categories> GetCategories()
         {
             var callchuck = await GetStringAsync(baseUrlChuck + "categories/" );
            // Here I use Newtonsoft.Json to deserialize JSON string to User object
             var categories = JsonConvert.DeserializeObject<Categories>(callchuck);
            return categories;
         }
         public async Task<People> GetPeople()
         {
             var callswapi = await GetStringAsync(baseUrlSwapi + "people/" );
            // Here I use Newtonsoft.Json to deserialize JSON string to User object
             var people = JsonConvert.DeserializeObject<People>(callswapi);
            return people;
         }

         public async Task<object> Search(string q_category, string q_people)
        {
            var call_chuck = await GetStringAsync(baseUrlChuck + "categories/" + q_category);
            var call_swapi = await GetStringAsync(baseUrlSwapi + "people/" + q_people );
            // Here I use Newtonsoft.Json to deserialize JSON string to User object
            var people = JsonConvert.DeserializeObject<People>(call_swapi);
            var categories = JsonConvert.DeserializeObject<Categories>(call_chuck);

            //Create an object
            var results = new
            {
                Chuck = call_chuck,
                Swapi = call_swapi
            }; 
            //Tranform it to Json object
            string chuck_swapi = JsonConvert.SerializeObject(results);
            return chuck_swapi;
        }
         private static async Task<string> GetStringAsync(string url)
    {
        using (var httpClient = new HttpClient())
        {
            return await httpClient.GetStringAsync(url);
        }
    }
    }
}