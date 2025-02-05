using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SamuraiProject.Library.Models;

namespace SamuraiProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HorseController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public HorseController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Horse
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Horse>>> GetHorse()
        {
            return await _context.Horse.ToListAsync();
        }

        // GET: api/Horse/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Horse>> GetHorse(int id)
        {
            var horse = await _context.Horse.FindAsync(id);

            if (horse == null)
            {
                return NotFound();
            }

            return horse;
        }

        // PUT: api/Horse/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHorse(int id, Horse horse)
        {
            if (id != horse.Id)
            {
                return BadRequest();
            }

            _context.Entry(horse).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HorseExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Horse
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Horse>> PostHorse(Horse horse)
        {
            _context.Horse.Add(horse);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHorse", new { id = horse.Id }, horse);
        }

        // DELETE: api/Horse/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHorse(int id)
        {
            var horse = await _context.Horse.FindAsync(id);
            if (horse == null)
            {
                return NotFound();
            }

            _context.Horse.Remove(horse);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HorseExists(int id)
        {
            return _context.Horse.Any(e => e.Id == id);
        }
    }
}
