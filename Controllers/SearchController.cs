using System;
using System.Collections.Generic;
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
        private readonly UseRepo useRepo = new UseRepo();
        
        [HttpGet]
          public ActionResult <IEnumerable<object>> Search(string q_category, string q_people)
         {
             return null;
         }
    }
}