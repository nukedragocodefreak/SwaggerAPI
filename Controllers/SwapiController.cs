using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SwaggerAPI.Models;

namespace SwaggerAPI.Controllers
{
    //api/swapi
    [Route("api/[controller]/people")]
    [ApiController]
    public class SwapiController : ControllerBase
    {
        [HttpGet]
          public ActionResult <IEnumerable<People>> GetPeople()
         {
             return null;
         }
    }
}