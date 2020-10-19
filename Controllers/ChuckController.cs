using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SwaggerAPI.Models;
using SwaggerAPI.Models.Data;
using System.Threading.Tasks;

namespace SwaggerAPI.Controllers
{
    //api/chuck
     [Route("api/[controller]/categories")]
     [ApiController]
    public class ChuckController : ControllerBase
    {
        private readonly UseRepo _repository = new UseRepo();
        
        [HttpGet]
        public ActionResult <Task<Categories>> GetCategories()
         {
             var _categories = _repository.GetCategories();
             return Ok(_categories);
         }
    }
}