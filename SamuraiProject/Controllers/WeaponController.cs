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
    public class WeaponController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public WeaponController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Weapon
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Weapon>>> GetWeapons()
        {
            return await _context.Weapons.ToListAsync();
        }

        // GET: api/Weapon/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Weapon>> GetWeapon(int id)
        {
            var weapon = await _context.Weapons.FindAsync(id);

            if (weapon == null)
            {
                return NotFound();
            }

            return weapon;
        }

        // PUT: api/Weapon/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWeapon(int id, Weapon weapon)
        {
            if (id != weapon.Id)
            {
                return BadRequest();
            }

            _context.Entry(weapon).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WeaponExists(id))
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

        // POST: api/Weapon
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Weapon>> PostWeapon(Weapon weapon)
        {
            _context.Weapons.Add(weapon);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWeapon", new { id = weapon.Id }, weapon);
        }

        // DELETE: api/Weapon/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWeapon(int id)
        {
            var weapon = await _context.Weapons.FindAsync(id);
            if (weapon == null)
            {
                return NotFound();
            }

            _context.Weapons.Remove(weapon);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WeaponExists(int id)
        {
            return _context.Weapons.Any(e => e.Id == id);
        }
    }
}
