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
    public class CarClassesController : ControllerBase
    {
        private readonly DataContext _context;
        public CarClassesController (DataContext context)
        {
            _context=context;
        }
        // GET api/CarClasses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarClass>>> Get()
        {
            var carclasses=await _context.CarClasses.ToListAsync();
            return Ok(carclasses);
        }

        // GET api/CarClasses/5
        [HttpGet("{id}")]
       public async Task<ActionResult<CarClass>> Get(int id)
        {
            var carclasses=await _context.CarClasses.FindAsync(id);
            return Ok(carclasses);
        }

        [HttpGet("Getgrpclass/{grpid}")]
        public  ActionResult<CarClass> Getgrpclass(int grpid)
        {
            var carclasses=_context.CarClasses.Where(c=>c.CarGrpId==grpid).ToList();
            //var carclasses=_context.CarClasses.Select(c=>c.CarGrpId==grpid).ToList();
            return Ok(carclasses);
        }
        // POST api/CarClasses
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/CarClasses/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/CarClasses/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
