using CookDoWebAPI.Context;
using CookDoWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CookDoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredinetController : ControllerBase
    {
        private readonly CDContext _CDContext;

        public IngredinetController(CDContext cDContext)
        {
            _CDContext = cDContext;
        }

        // GET: api/<IngredinetController>
        [HttpGet]
        public IEnumerable<Ingredient> Get() => _CDContext.Ingredients;


        // GET api/<IngredinetController>/5
        [HttpGet("{id}", Name = "Get")]
        public Ingredient Get(int id) => _CDContext.Ingredients.SingleOrDefault(x => x.Id == id);

        // POST api/<IngredinetController>
        [HttpPost]
        public void Post([FromBody] Ingredient ingredient)
        {
            _CDContext.Ingredients.Add(ingredient);
            _CDContext.SaveChanges();
        }

        // PUT api/<IngredinetController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Ingredient ingredient)
        {
            ingredient.Id = id;
            _CDContext.Ingredients.Update(ingredient);
            _CDContext.SaveChanges();
        }

        // DELETE api/<IngredinetController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _CDContext.Ingredients.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                _CDContext.Ingredients.Remove(item);
                _CDContext.SaveChanges();
            }
            else
            {
                BadRequest();
            }
        }
    }
}
