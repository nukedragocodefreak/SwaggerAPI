using System.Collections.Generic;

namespace SwaggerAPI.Models.Data
{
    public class UseRepo : Repo
    {
         public IEnumerable<Categories> GetCategories()
         {
             return null;
         }
         public IEnumerable<People> GetPeople()
         {
             return null;
         }

         public IEnumerable<object> Search(string q_category, string q_people)
        {
            return null;
        }
    }
}