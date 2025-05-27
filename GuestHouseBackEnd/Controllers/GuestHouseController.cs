using GuestHouseBackEnd.Data;
using GuestHouseBackEnd.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GuestHouseBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestHousesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public GuestHousesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/GuestHouses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GuestHouse>>> GetGuestHouses()
        {
            return await _context.GuestHouses
                .Include(gh => gh.Rooms)
                .ToListAsync();
        }

        // GET: api/GuestHouses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GuestHouse>> GetGuestHouse(int id)
        {
            var guestHouse = await _context.GuestHouses
                .Include(gh => gh.Rooms)
                .FirstOrDefaultAsync(gh => gh.Id == id);

            if (guestHouse == null)
                return NotFound();

            return guestHouse;
        }

        // POST: api/GuestHouses
        [HttpPost]
        public async Task<ActionResult<GuestHouse>> PostGuestHouse(GuestHouse guestHouse)
        {
            _context.GuestHouses.Add(guestHouse);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetGuestHouse), new { id = guestHouse.Id }, guestHouse);
        }

        // PUT: api/GuestHouses/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGuestHouse(int id, GuestHouse guestHouse)
        {
            if (id != guestHouse.Id)
                return BadRequest();

            _context.Entry(guestHouse).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.GuestHouses.Any(e => e.Id == id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        // DELETE: api/GuestHouses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGuestHouse(int id)
        {
            var guestHouse = await _context.GuestHouses.FindAsync(id);
            if (guestHouse == null)
                return NotFound();

            _context.GuestHouses.Remove(guestHouse);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
