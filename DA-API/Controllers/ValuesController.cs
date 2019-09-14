using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DA_API.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DA_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DAContext _context;

        public ValuesController(DAContext context)
        {
            _context = context;
        }
        // GET api/values
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetValue()
        {
            var query = await _context.Values.ToListAsync();
            return Ok(query);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            var query = await _context.Values.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(query);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
