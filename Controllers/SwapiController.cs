using System;
using System.Collections.Generic;
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
        private readonly UseRepo useRepo = new UseRepo();
        
        [HttpGet]
          public ActionResult <IEnumerable<People>> GetPeople()
         {
             return null;
         }
    }
}