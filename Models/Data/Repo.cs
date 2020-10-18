using System.Collections.Generic;

namespace SwaggerAPI.Models.Data
{
    public interface Repo
    {
         IEnumerable<Categories> GetCategories();
         IEnumerable<People> GetPeople();      
    }
}