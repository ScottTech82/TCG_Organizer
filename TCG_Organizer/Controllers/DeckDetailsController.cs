using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TCG_Organizer.Models;

namespace TCG_Organizer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeckDetailsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DeckDetailsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/DeckDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DeckDetail>>> GetDeckDetails()
        {
            return await _context.DeckDetails.ToListAsync();
        }

        // GET: api/DeckDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DeckDetail>> GetDeckDetail(int id)
        {
            var deckDetail = await _context.DeckDetails.FindAsync(id);

            if (deckDetail == null)
            {
                return NotFound();
            }

            return deckDetail;
        }

        // PUT: api/DeckDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDeckDetail(int id, DeckDetail deckDetail)
        {
            if (id != deckDetail.Id)
            {
                return BadRequest();
            }

            _context.Entry(deckDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeckDetailExists(id))
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

        // POST: api/DeckDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DeckDetail>> PostDeckDetail(DeckDetail deckDetail)
        {
            _context.DeckDetails.Add(deckDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDeckDetail", new { id = deckDetail.Id }, deckDetail);
        }

        // DELETE: api/DeckDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDeckDetail(int id)
        {
            var deckDetail = await _context.DeckDetails.FindAsync(id);
            if (deckDetail == null)
            {
                return NotFound();
            }

            _context.DeckDetails.Remove(deckDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DeckDetailExists(int id)
        {
            return _context.DeckDetails.Any(e => e.Id == id);
        }
    }
}
