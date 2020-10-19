using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwaggerAPI.Models.Data
{
    public interface Repo
    {
        Task<Categories> GetCategories();
         Task<People> GetPeople();      
         Task<Search> Search(SearchData searchData);   
    }
}