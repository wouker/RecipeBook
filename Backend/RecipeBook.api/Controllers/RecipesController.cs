﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace RecipeBook.Api.Controllers
{
    [Route("api/[controller]")]
    public class RecipesController : Controller
    {
        // GET api/recipes
        [HttpGet]
        public IEnumerable<string> GetAll()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/recipes/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/recipes
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/recipes/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/recipes/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
