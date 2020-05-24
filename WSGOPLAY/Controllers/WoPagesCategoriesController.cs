using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WSGOPLAY.Models;

namespace WSGOPLAY.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WoPagesCategoriesController : ControllerBase
    {
        private readonly goplayco_redContext _context;

        public WoPagesCategoriesController(goplayco_redContext context)
        {
            _context = context;
        }

        // GET: api/WoPagesCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WoPagesCategories>>> GetWoPagesCategories()
        {
            return await _context.WoPagesCategories.ToListAsync();
        }

        // GET: api/WoPagesCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WoPagesCategories>> GetWoPagesCategories(int id)
        {
            var woPagesCategories = await _context.WoPagesCategories.FindAsync(id);

            if (woPagesCategories == null)
            {
                return NotFound();
            }

            return woPagesCategories;
        }

        // PUT: api/WoPagesCategories/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWoPagesCategories(int id, WoPagesCategories woPagesCategories)
        {
            if (id != woPagesCategories.Id)
            {
                return BadRequest();
            }

            _context.Entry(woPagesCategories).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WoPagesCategoriesExists(id))
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

        // POST: api/WoPagesCategories
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<WoPagesCategories>> PostWoPagesCategories(WoPagesCategories woPagesCategories)
        {
            _context.WoPagesCategories.Add(woPagesCategories);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWoPagesCategories", new { id = woPagesCategories.Id }, woPagesCategories);
        }

        // DELETE: api/WoPagesCategories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<WoPagesCategories>> DeleteWoPagesCategories(int id)
        {
            var woPagesCategories = await _context.WoPagesCategories.FindAsync(id);
            if (woPagesCategories == null)
            {
                return NotFound();
            }

            _context.WoPagesCategories.Remove(woPagesCategories);
            await _context.SaveChangesAsync();

            return woPagesCategories;
        }

        private bool WoPagesCategoriesExists(int id)
        {
            return _context.WoPagesCategories.Any(e => e.Id == id);
        }
    }
}
