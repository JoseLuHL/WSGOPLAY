using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WSGOPLAY.Models;
using EpaycoSdk;
using EpaycoSdk.Models;
using System.Net;

namespace WSGOPLAY.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private readonly goplayco_redContext _context;

        public GroupsController(goplayco_redContext context)
        {
           

            _context = context;
        }

        // GET: api/Groups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WoGroups>>> GetWoGroups()
        {
            try
            {
                return await _context.WoGroups.ToListAsync();
            }
            catch (Exception ex)
            {
                return Ok(ex);
                //throw;
            }
        }

        // GET: api/Groups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WoGroups>> GetWoGroups(int id)
        {
            var woGroups = await _context.WoGroups.FindAsync(id);

            if (woGroups == null)
            {
                return NotFound();
            }

            return woGroups;
        }

        // PUT: api/Groups/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWoGroups(int id, WoGroups woGroups)
        {
            if (id != woGroups.Id)
            {
                return BadRequest();
            }

            _context.Entry(woGroups).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WoGroupsExists(id))
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

        // POST: api/Groups
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<WoGroups>> PostWoGroups(WoGroups woGroups)
        {
            _context.WoGroups.Add(woGroups);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWoGroups", new { id = woGroups.Id }, woGroups);
        }

        // DELETE: api/Groups/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<WoGroups>> DeleteWoGroups(int id)
        {
            var woGroups = await _context.WoGroups.FindAsync(id);
            if (woGroups == null)
            {
                return NotFound();
            }

            _context.WoGroups.Remove(woGroups);
            await _context.SaveChangesAsync();

            return woGroups;
        }

        private bool WoGroupsExists(int id)
        {
            return _context.WoGroups.Any(e => e.Id == id);
        }
    }
}
