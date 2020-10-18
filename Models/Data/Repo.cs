namespace SwaggerAPI.Models.Data
{
    public interface Repo
    {
         IEnumerable<Categories> GetCategories();
         IEnumerable<People> GetPeople();      
    }
}