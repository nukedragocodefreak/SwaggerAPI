using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SwaggerAPI.URLs;

namespace SwaggerAPI.Models.Data
{
    public class UseRepo : Repo
    {        
        URL url = new URL();

         public async Task<Categories> GetCategories()
         {
             var callchuck = await GetStringAsync(url.baseUrlChuck + "categories/" );
            // Here I use Newtonsoft.Json to deserialize JSON string to User object
             var categories = JsonConvert.DeserializeObject<Categories>(callchuck);           
            return categories;
         }
         public async Task<People> GetPeople()
         {
             var callswapi = await GetStringAsync(url.baseUrlSwapi + "people/" );
            // Here I use Newtonsoft.Json to deserialize JSON string to User object
             var people = JsonConvert.DeserializeObject<People>(callswapi);
            return people;
         }

         public async Task<Search> Search(SearchData searchData)
        {
            var call_chuck = await GetStringAsync(url.baseUrlChuck + "categories/" + searchData.q_category);
            var call_swapi = await GetStringAsync(url.baseUrlSwapi + "people/" + searchData.q_people );
            // Here I use Newtonsoft.Json to deserialize JSON string to User object
            var people = JsonConvert.DeserializeObject<People>(call_swapi);
            var categories = JsonConvert.DeserializeObject<Categories>(call_chuck);

            //Create an object
            var search = new
            {
                categories = call_chuck.ToString(),
                people = call_swapi.ToString()
            }; 
            //Tranform it to Json object
            var chuck_swapi = JsonConvert.SerializeObject(search);
             var _chuck_swapi = JsonConvert.DeserializeObject<Search>(chuck_swapi);
            return _chuck_swapi;
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