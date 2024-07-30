using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Dtos;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrawTypesController : ControllerBase
    {
        private readonly Dek9s8aheu55lvContext _context;

        public DrawTypesController(Dek9s8aheu55lvContext context)
        {
            _context = context;
        }

        // GET: api/draw_types
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DrawTypeDto>>> GetDrawTypes()
        {
            var drawTypes = await _context.DrawTypes
                .OrderBy(dt => dt.Id)
                .Select(dt => new DrawTypeDto
                {
                    Id = dt.Id,
                    Name = dt.Name,
                    CreatedAt = dt.CreatedAt,
                    UpdatedAt = dt.UpdatedAt
                })
                .ToListAsync();

            return Ok(drawTypes);
        }

        // GET: api/draw_types/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DrawTypeDto>> GetDrawType(long id)
        {
            var drawType = await _context.DrawTypes
                .Where(dt => dt.Id == id)
                .Select(dt => new DrawTypeDto
                {
                    Id = dt.Id,
                    Name = dt.Name,
                    CreatedAt = dt.CreatedAt,
                    UpdatedAt = dt.UpdatedAt
                })
                .FirstOrDefaultAsync();

            if (drawType == null)
            {
                return NotFound();
            }

            return Ok(drawType);
        }

        // POST: api/draw_types
        [HttpPost]
        public async Task<ActionResult<DrawTypeDto>> PostDrawType(DrawTypeDto drawTypeDto)
        {
            var drawType = new DrawType
            {
                Name = drawTypeDto.Name,
                CreatedAt = DateTime.SpecifyKind(drawTypeDto.CreatedAt, DateTimeKind.Local),
                UpdatedAt = DateTime.SpecifyKind(drawTypeDto.UpdatedAt, DateTimeKind.Local)

            };

            _context.DrawTypes.Add(drawType);
            await _context.SaveChangesAsync();

            drawTypeDto.Id = drawType.Id;

            return CreatedAtAction(nameof(GetDrawType), new { id = drawType.Id }, drawTypeDto);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> DeleteDrawType(long id)
        {
            var drawType = await _context.DrawTypes.FindAsync(id);
            if (drawType == null)
            {
                return NotFound();
            }
            _context.DrawTypes.Remove(drawType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // PUT: api/draw_types/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDrawType(long id, DrawTypeDto drawTypeDto)
        {
            if (id != drawTypeDto.Id)
            {
                return BadRequest();
            }

            var drawType = await _context.DrawTypes.FindAsync(id);
            if (drawType == null)
            {
                return NotFound();
            }

            // Aggiorna la risorsa con i dati del DTO
            drawType.Name = drawTypeDto.Name;
            //drawType.CreatedAt = DateTime.SpecifyKind(drawTypeDto.CreatedAt, DateTimeKind.Local);
            drawType.UpdatedAt = DateTime.SpecifyKind(drawTypeDto.UpdatedAt, DateTimeKind.Local);

            _context.Entry(drawType).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }


    }
}

