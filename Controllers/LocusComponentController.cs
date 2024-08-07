using Microsoft.AspNetCore.Mvc;
using WebApplication1.Dtos;
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
    }
}
