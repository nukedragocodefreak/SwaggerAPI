using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SwaggerAPI.Models;

namespace SwaggerAPI.Controllers
{
    //api/chuck
     [Route("api/[controller]/categories")]
     [ApiController]
    public class ChuckController : ControllerBase
    {
        public ActionResult <IEnumerable<Categories>> GetCategories()
         {
             return null;
         }
    }
}