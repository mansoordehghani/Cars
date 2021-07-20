using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarGroupsController : ControllerBase
    {

         private readonly DataContext _context;
        public CarGroupsController(DataContext context)
        {
            _context=context;
        }
        // GET api/CarGroups
        [HttpGet]
       public async Task<ActionResult<IEnumerable<CarGroup>>> Get()
        {
            var cargroups=await _context.CarGroups.ToListAsync();
            return Ok(cargroups);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarGroup>> Get(int id)
        {
            var cargroups=await _context.CarGroups.FindAsync(id);
            return Ok(cargroups);
        }

        // POST api/CarGroups
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/CarGroups/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/CarGroups/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
