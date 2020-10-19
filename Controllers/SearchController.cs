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
          public ActionResult <Task<object>> Search(SearchData searchData)
         {
              var _chuckswapi = _repository.Search(searchData);
              return Ok(_chuckswapi.Result);
         }
    }
}