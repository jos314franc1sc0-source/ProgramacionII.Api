using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProgramacionII.Api.Controllers.DTOs;
using ProgramacionII.Api.Controllers.Models;
using ProgramacionII.Api.Data;
using ProgramacionII.Api.DTOs;

namespace ProgramacionII.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MiembrosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MiembrosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/miembros
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Miembro>>> GetMiembros()
        {
            return await _context.Miembros.ToListAsync();
        }

        // GET: api/miembros/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Miembro>> GetMiembro(int id)
        {
            var miembro = await _context.Miembros.FindAsync(id);

            if (miembro == null)
                return NotFound();

            return miembro;
        }

        // POST: api/miembros
        [HttpPost]
        public async Task<ActionResult<Miembro>> CreateMiembro(MiembroCreateDto dto)
        {
            var miembro = new Miembro
            {
                Nombre = dto.Nombre,
                Cedula = dto.Cedula,
                Rol = dto.Rol
            };

            _context.Miembros.Add(miembro);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMiembro), new { id = miembro.Id }, miembro);
        }

        // PUT: api/miembros/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMiembro(int id, MiembroUpdateDto dto)
        {
            var miembro = await _context.Miembros.FindAsync(id);

            if (miembro == null)
                return NotFound();

            miembro.Nombre = dto.Nombre;
            miembro.Cedula = dto.Cedula;
            miembro.Rol = dto.Rol;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/miembros/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMiembro(int id)
        {
            var miembro = await _context.Miembros.FindAsync(id);

            if (miembro == null)
                return NotFound();

            _context.Miembros.Remove(miembro);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
