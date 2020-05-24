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
    public class WoGroupMembersController : ControllerBase
    {
        private readonly goplayco_redContext _context;

        public WoGroupMembersController(goplayco_redContext context)
        {
            _context = context;
        }

        // GET: api/WoGroupMembers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WoGroupMembers>>> GetWoGroupMembers()
        {
            var Jugadores = await (from Equ in _context.WoGroups
                                   join EJ in _context.WoGroupMembers on Equ.Id equals EJ.GroupId
                                   join Jug in _context.WoUsers on EJ.UserId equals Jug.UserId
                                   select new
                                   {

                                       EJ.Id,
                                       EJ.GroupId,
                                       EJ.Active,
                                       EJ.Time,
                                       EJ.UserId,
                                       Grupo = new
                                       {
                                           Equ.GroupName,
                                           Equ.GroupTitle,
                                           Avatar = $"https://www.goplay.com.co/red/{Equ.Avatar.Trim()}",
                                           Cover = $"https://www.goplay.com.co/red/{Equ.Cover.Trim()}",
                                           Equ.About,
                                       },
                                       User = new
                                       {
                                           Jug.UserId,
                                           Jug.FirstName,
                                           Jug.LastName,
                                           Jug.Username,
                                       }

                                   }).ToListAsync();
            return Ok(Jugadores);
            //return await _context.WoGroupMembers.ToListAsync();
        }

        // GET: api/WoGroupMembers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WoGroupMembers>> GetWoGroupMembers(int id)
        {
            var Jugadores = await (from Equ in _context.WoGroups
                                   join EJ in _context.WoGroupMembers on Equ.Id equals EJ.GroupId
                                   join Jug in _context.WoUsers on EJ.UserId equals Jug.UserId
                                   where Equ.Id == id
                                   select new
                                   {

                                       EJ.Id,
                                       EJ.GroupId,
                                       EJ.Active,
                                       EJ.Time,
                                       EJ.UserId,
                                       Grupo = new
                                       {
                                           Equ.GroupName,
                                           Equ.GroupTitle,
                                           Avatar = $"https://www.goplay.com.co/red/{Equ.Avatar.Trim()}",
                                           Cover = $"https://www.goplay.com.co/red/{Equ.Cover.Trim()}",
                                           Equ.About,
                                       },
                                       User = new
                                       {
                                           Jug.UserId,
                                           Jug.FirstName,
                                           Jug.LastName,
                                           Jug.Username,
                                       }
                                   }).ToListAsync();

            if (Jugadores == null)
            {
                return NotFound();
            }

            return Ok(Jugadores);

        }

        // PUT: api/WoGroupMembers/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWoGroupMembers(int id, WoGroupMembers woGroupMembers)
        {
            if (id != woGroupMembers.Id)
            {
                return BadRequest();
            }

            _context.Entry(woGroupMembers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WoGroupMembersExists(id))
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

        // POST: api/WoGroupMembers
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<WoGroupMembers>> PostWoGroupMembers(WoGroupMembers woGroupMembers)
        {
            _context.WoGroupMembers.Add(woGroupMembers);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWoGroupMembers", new { id = woGroupMembers.Id }, woGroupMembers);
        }

        // DELETE: api/WoGroupMembers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<WoGroupMembers>> DeleteWoGroupMembers(int id)
        {
            var woGroupMembers = await _context.WoGroupMembers.FindAsync(id);
            if (woGroupMembers == null)
            {
                return NotFound();
            }

            _context.WoGroupMembers.Remove(woGroupMembers);
            await _context.SaveChangesAsync();

            return woGroupMembers;
        }

        private bool WoGroupMembersExists(int id)
        {
            return _context.WoGroupMembers.Any(e => e.Id == id);
        }
    }
}
