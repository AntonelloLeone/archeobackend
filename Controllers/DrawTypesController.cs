using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Dtos;
using WebApplication1.exceptions;
using WebApplication1.Models;
using WebApplication1.Repositories;
using WebApplication1.Services;


namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrawTypesController : ControllerBase
    {
        private readonly Dek9s8aheu55lvContext _context;
        private readonly IDrawTypeService _service;

        public DrawTypesController(IDrawTypeService service, Dek9s8aheu55lvContext context)
        {
            _service = service;
            _context = context;
        }


        // GET: api/draw_types
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DrawTypeDto>>> GetDrawTypes()
        {
            try
            {
                var drawTypes = await _service.GetAllAsync();
                return Ok(drawTypes);
            }
            catch (ApplicationException ex)
            {
                // Gestione di eccezioni custom
                return StatusCode(500, new { message = ex.Message });
            }
            catch (Exception ex)
            {
                // Gestione di eccezioni generiche
                return StatusCode(500, new { message = "Errore interno del server" });
            }
        }






        // GET: api/draw_types/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DrawTypeDto>> GetDrawType(long id)
        {
            try
            {
                var drawType = await _service.GetByIdAsync(id);
                return Ok(drawType);
            }
            catch (NotFoundException ex)
            {
                // Restituisci un 404 Not Found se l'elemento non è stato trovato
                return NotFound(new { Message = ex.Message });
            }
            catch (Exception ex)
            {
                // Restituisci un 500 Internal Server Error per errori generali
                return StatusCode(500, new { Message = "Errore interno del server", Details = ex.Message });
            }
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



        [HttpPost("trans")]
        public async Task<ActionResult<DrawTypeDto>> TransType(DrawTypeDto drawTypeDto)
        {

            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    var drawType = new DrawType
                    {
                        Name = drawTypeDto.Name,
                        CreatedAt = DateTime.SpecifyKind(drawTypeDto.CreatedAt, DateTimeKind.Local),
                        UpdatedAt = DateTime.SpecifyKind(drawTypeDto.UpdatedAt, DateTimeKind.Local)

                    };

                    _context.DrawTypes.Add(drawType);
                    await _context.SaveChangesAsync();

                    await transaction.CommitAsync();

                    drawTypeDto.Id = drawType.Id;

                    return CreatedAtAction(nameof(GetDrawType), new { id = drawType.Id }, drawTypeDto);
                }
                catch (Exception ex) // segnalare diversi messaggi
                {
                    
                    await transaction.RollbackAsync();
                    return StatusCode(500, new { message = "An error occurred", error = ex.Message });
                }

            }
        }
    }
}

