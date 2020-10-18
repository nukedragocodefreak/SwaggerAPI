using System.Collections.Generic;

namespace SwaggerAPI.Models.Data
{
    public interface Repo
    {
         IEnumerable<Categories> GetCategories();
         IEnumerable<People> GetPeople();      
         IEnumerable<object> Search(string q_category, string q_people);   
    }
}