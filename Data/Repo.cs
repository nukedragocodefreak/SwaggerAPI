using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerAPI.Models.Data
{
    public interface Repo
    {
        Task<Categories> GetCategories();
         Task<People> GetPeople();      
         Task<object> Search(string q_category, string q_people);   
    }
}