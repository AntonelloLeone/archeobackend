using Microsoft.AspNetCore.Mvc;
using WebApplication1.Dtos;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocusDefinitionsController : Controller
    {
        private readonly ILocusDefinitionService _service;

        public LocusDefinitionsController(ILocusDefinitionService service)
        {
            _service = service;

        }

        // GET: api/locus_definitions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LocusDefinitionDto>>> GetLocusDefinitions()
        {
            try
            {
                var locusDefinitions = await _service.GetAllAsync();
                return Ok(locusDefinitions);
            }
            catch (ApplicationException ex)
            {
                // Gestione di eccezioni custom
                return StatusCode(500, new { message = ex.Message });
            }
            catch (Exception ex)
            {
                // Gestione di eccezioni generiche
                return StatusCode(500, new { message = "Errore interno del server", dettagli = ex.Message });
            }
        }
    }
}
