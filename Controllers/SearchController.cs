using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SwaggerAPI.Models;

namespace SwaggerAPI.Controllers
{
    //api/search
    [Route("api/[controller]")]
     [ApiController]
    public class SearchController : ControllerBase
    {
        [HttpGet]
          public ActionResult <IEnumerable<object>> Search(string q_category, string q_people)
         {
             return null;
         }
    }
}