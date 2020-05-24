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
    public class WoUsersController : ControllerBase
    {
        private readonly goplayco_redContext _context;

        public WoUsersController(goplayco_redContext context)
        {
            _context = context;
        }

        // GET: api/WoUsers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WoUsers>>> GetWoUsers()
        {
            return await _context.WoUsers.ToListAsync();
        }

        // GET: api/WoUsers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WoUsers>> GetWoUsers(int id)
        {
            var woUsers = await _context.WoUsers.FindAsync(id);

            if (woUsers == null)
            {
                return NotFound();
            }

            return woUsers;
        }
        
        // GET: api/WoUsers/5
        [HttpGet("buscar/{conte}")]
        public async Task<ActionResult<WoUsers>> GetWoUsers(string conte)
        {
            var woUsers = await _context.WoUsers.Where(s => s.Email.Equals(conte) || s.Username.Equals(conte)).ToListAsync();

            if (woUsers == null)
            {
                return null;
            }

            return woUsers.First();
        }

        // PUT: api/WoUsers/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWoUsers(int id, WoUsers woUsers)
        {
            if (id != woUsers.UserId)
            {
                return BadRequest();
            }

            _context.Entry(woUsers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WoUsersExists(id))
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

        // POST: api/WoUsers
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<WoUsers>> PostWoUsers(WoUsers woUsers)
        {
            _context.WoUsers.Add(woUsers);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWoUsers", new { id = woUsers.UserId }, woUsers);
        }

        // DELETE: api/WoUsers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<WoUsers>> DeleteWoUsers(int id)
        {
            var woUsers = await _context.WoUsers.FindAsync(id);
            if (woUsers == null)
            {
                return NotFound();
            }

            _context.WoUsers.Remove(woUsers);
            await _context.SaveChangesAsync();

            return woUsers;
        }

        private bool WoUsersExists(int id)
        {
            return _context.WoUsers.Any(e => e.UserId == id);
        }
    }
}
