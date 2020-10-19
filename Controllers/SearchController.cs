using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SwaggerAPI.Models;
using SwaggerAPI.Models.Data;

namespace SwaggerAPI.Controllers
{
    //api/search
    [Route("api/[controller]")]
     [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly UseRepo _repository = new UseRepo();
        
        [HttpPost]
          public ActionResult <Task<object>> Search(string q_category, string q_people)
         {
              var _chuckswapi = _repository.Search(q_category, q_people);
              return Ok(_chuckswapi.Result);
         }
    }
}