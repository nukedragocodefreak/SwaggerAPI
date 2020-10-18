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

        IEnumerable<Categories> Repo.GetCategories()
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<People> Repo.GetPeople()
        {
            throw new System.NotImplementedException();
        }
    }
}