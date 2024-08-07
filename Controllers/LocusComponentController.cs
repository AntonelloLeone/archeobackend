using Microsoft.AspNetCore.Mvc;
using WebApplication1.Dtos;
using WebApplication1.exceptions;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocusComponentController : Controller
    {
        private readonly ILocusComponentService _service;

        public LocusComponentController(ILocusComponentService service)
        {
            _service = service;

        }


        // GET: api/locus_components
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LocusComponentDto>>> GetLocusComponents()
        {
            try
            {
                var locusComponents = await _service.GetAllAsync();
                return Ok(locusComponents);
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

        // GET: api/locus_components/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LocusComponentDto>> GetLocusComponent(long id)
        {
            try
            {
                var locusComponent = await _service.GetByIdAsync(id);
                return Ok(locusComponent);
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

        // POST: api/locus_components
        [HttpPost]
        public async Task<ActionResult<DrawTypeDto>> PostLocusComponent(LocusComponentDto locusComponentDto)
        {
            try
            {
                var locusComponentDtoResult = await _service.AddAsync(locusComponentDto);
                return CreatedAtAction(nameof(GetLocusComponent), new { id = locusComponentDtoResult.Id }, locusComponentDtoResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Errore interno del server", details = ex.Message });
            }
        }

        // PUT: api/draw_types/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocusComponent(long id, LocusComponentDto locusComponentDto)
        {
            try
            {
                await _service.UpdateAsync(id, locusComponentDto);
                return NoContent();
            }
            catch (NotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (BadRequestException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        //[Authorize(Roles = "admin")]
        public async Task<IActionResult> DeleteLocusComponente(long id)
        {
            try
            {
                await _service.DeleteAsync(id);
                return NoContent();
            }
            catch (NotFoundException ex)
            {
                return NotFound(new { Message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "Errore interno del server", Details = ex.Message });
            }
        }
    }
}
