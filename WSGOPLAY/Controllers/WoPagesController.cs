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
    public class WoPagesController : ControllerBase
    {
        private readonly goplayco_redContext _context;

        public WoPagesController(goplayco_redContext context)
        {
            _context = context;
        }

        // GET: api/WoPages
        [HttpGet("{pag}")]
        public async Task<ActionResult<IEnumerable<WoPages>>> GetWoPages(int pag = 1)
        {
            int total = 0;
            // Número total de registros de la tabla Customers
            total = 4;
            var page = await (from pa in _context.WoPages
                              join cate in _context.WoPagesCategories
                              on pa.PageCategory equals cate.Id
                              join user in _context.WoUsers
                              on pa.UserId equals user.UserId
                              select new
                              {
                                  paginacion = new { total = _context.WoPages.ToList().Count, pag = total, indice = (pag - 1) * total },
                                  pa.PageId,
                                  pa.PageName,
                                  pa.PageTitle,
                                  pa.PageDescription,
                                  Avatar = $"https://www.goplay.com.co/red/{pa.Avatar.Trim()}",
                                  Cover = $"https://www.goplay.com.co/red/{pa.Cover.Trim()}",
                                  pa.Phone,
                                  pa.Address,
                                  pa.Active,
                                  cate.LangKey,
                                  pa.Facebook,
                                  pa.Google,
                                  pa.Twitter,
                                  pa.UserId,
                                  pa.Lat,
                                  pa.Lng,
                                  user = new
                                  {
                                      user.UserId,
                                      user.FirstName,
                                      user.LastName,
                                      user.Username
                                  }
                              }).Skip((pag - 1) * total).Take(total).ToListAsync();

            return Ok(page);

        }

        [HttpGet("todos")]
        public async Task<ActionResult<IEnumerable<WoPages>>> GetWoPages()
        {
            int total = 0;
            // Número total de registros de la tabla Customers
            total = 4;
            var page = await (from pa in _context.WoPages
                              join cate in _context.WoPagesCategories
                              on pa.PageCategory equals cate.Id
                              join user in _context.WoUsers
                              on pa.UserId equals user.UserId
                              select new
                              {
                                  pa.PageId,
                                  pa.PageName,
                                  pa.PageTitle,
                                  pa.PageDescription,
                                  Avatar = $"https://www.goplay.com.co/red/{pa.Avatar.Trim()}",
                                  Cover = $"https://www.goplay.com.co/red/{pa.Cover.Trim()}",
                                  pa.Phone,
                                  pa.Address,
                                  pa.Active,
                                  cate.LangKey,
                                  pa.Facebook,
                                  pa.Google,
                                  pa.Twitter,
                                  pa.UserId,
                                  pa.Lat,
                                  pa.Lng,
                                  user = new
                                  {
                                      user.UserId,
                                      user.FirstName,
                                      user.LastName,
                                      user.Username
                                  }
                              }).ToListAsync();

            return Ok(page);

        }

        [HttpGet("pagina/horario/{id}")]
        public async Task<ActionResult<WoPages>> GetWoPageshorario(int id =1)
        {
            var PG = await _context.WoPages
                            .Include(horario=> horario.Horario)
                                .ThenInclude(s=> s.Sinreserva)
                            .Include(horario => horario.Horario)
                                .ThenInclude(Horario  => Horario.Reserva)
                                    .ThenInclude(est => est.IdestadoNavigation)
                                    .Where(s=>s.PageId.Equals(id)).FirstAsync();

            return PG;
        }

        // GET: api/WoPages/5
        [HttpGet("id/{id}")]
        public async Task<ActionResult<WoPages>> GetWoPagess(int id, int pag = 1)
        {
            int total = 0;
            // Número total de registros de la tabla Customers
            total = _context.WoPages.ToList().Count;
            var page = await (from pa in _context.WoPages
                              join cate in _context.WoPagesCategories
                              on pa.PageCategory equals cate.Id
                              join user in _context.WoUsers on pa.UserId equals user.UserId
                              where pa.PageId == id
                              select new
                              {
                                  paginacion = new { total = _context.WoPages.ToList().Count, pag = total, indice = (pag - 1) * total },
                                  pa.PageId,
                                  pa.PageName,
                                  pa.PageTitle,
                                  pa.PageDescription,
                                  Avatar = $"https://www.goplay.com.co/red/{pa.Avatar.Trim()}",
                                  Cover = $"https://www.goplay.com.co/red/{pa.Cover.Trim()}",
                                  pa.Phone,
                                  pa.Address,
                                  pa.Active,
                                  cate.LangKey,
                                  pa.Facebook,
                                  pa.Google,
                                  pa.Twitter,
                                  pa.UserId,
                                  pa.Lat,
                                  pa.Lng,
                                  user = new
                                  {
                                      user.UserId,
                                      user.FirstName,
                                      user.LastName,
                                      user.Username
                                  }

                              }).Skip((pag - 1) * total).Take(total).ToListAsync();

            if (page == null)
            {
                return NotFound();
            }

            return Ok(page);
        }

        // GET: api/WoPages/5
        [HttpGet("Buscar/{contenido}")]
        public async Task<ActionResult<WoPages>> GetWoPages(string contenido, int categoria)
        {
            var page = await (from pa in _context.WoPages
                              join cate in _context.WoPagesCategories
                              on pa.PageCategory equals cate.Id
                              join user in _context.WoUsers on pa.UserId equals user.UserId
                              where pa.PageTitle.ToLower().Contains(contenido.ToLower()) || cate.Id == categoria
                              select new
                              {
                                  pa.PageId,
                                  pa.PageName,
                                  pa.PageTitle,
                                  pa.PageDescription,
                                  Avatar = $"https://www.goplay.com.co/red/{pa.Avatar.Trim()}",
                                  Cover = $"https://www.goplay.com.co/red/{pa.Cover.Trim()}",
                                  pa.Phone,
                                  pa.Address,
                                  pa.Active,
                                  cate.LangKey,
                                  pa.Facebook,
                                  pa.Google,
                                  pa.Twitter,
                                  pa.UserId,
                                  pa.Lat,
                                  pa.Lng,
                                  user = new
                                  {
                                      user.UserId,
                                      user.FirstName,
                                      user.LastName,
                                      user.Username
                                  }

                              }).ToListAsync();

            if (page == null)
            {
                return NotFound();
            }

            return Ok(page);
        }

        // PUT: api/WoPages/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWoPages(int id, WoPages woPages)
        {
            if (id != woPages.PageId)
            {
                return BadRequest();
            }

            _context.Entry(woPages).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WoPagesExists(id))
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

        // POST: api/WoPages
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<WoPages>> PostWoPages(WoPages woPages)
        {
            _context.WoPages.Add(woPages);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWoPages", new { id = woPages.PageId }, woPages);
        }

        // DELETE: api/WoPages/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<WoPages>> DeleteWoPages(int id)
        {
            var woPages = await _context.WoPages.FindAsync(id);
            if (woPages == null)
            {
                return NotFound();
            }

            _context.WoPages.Remove(woPages);
            await _context.SaveChangesAsync();

            return woPages;
        }

        private bool WoPagesExists(int id)
        {
            return _context.WoPages.Any(e => e.PageId == id);
        }
    }
}
