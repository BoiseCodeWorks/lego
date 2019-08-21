using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lego.Data;
using Lego.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lego.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KitsController : ControllerBase
    {
        private readonly KitRepository _repo;

        public KitsController(KitRepository repo)
        {
            _repo = repo;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public ActionResult<Kit> Post([FromBody] Kit kitData)
        {
            try
            {
                return Ok(_repo.CreateKit(kitData));
            }
            catch (Exception e)
            {
                return BadRequest("YOU MAKE ME SAD");
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) { }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id) { }
    }
}