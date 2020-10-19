using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SwaggerAPI.Models;
using SwaggerAPI.Models.Data;

namespace SwaggerAPI.Controllers
{
    //api/search
    [Produces("application/json")]
    [Route("api/[controller]")]
     [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly UseRepo _repository = new UseRepo();
        
        [HttpPost]
          public async Task<object> Search(SearchData searchData)
         {
              var _chuckswapi = await  _repository.Search(searchData);
              return _chuckswapi;
         }
    }
}