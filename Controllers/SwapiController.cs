using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SwaggerAPI.Models;
using SwaggerAPI.Models.Data;

namespace SwaggerAPI.Controllers
{
    //api/swapi
    [Route("api/[controller]/people")]
    [ApiController]
    public class SwapiController : ControllerBase
    {
        private readonly UseRepo _repository = new UseRepo();
        
        [HttpGet]
          public ActionResult <Task<People>> GetPeople()
         {           
             var _people = _repository.GetPeople();
             return Ok(_people);
         }
    }
}