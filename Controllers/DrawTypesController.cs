﻿using Microsoft.AspNetCore.Mvc;
using WebApplication1.Dtos;
using WebApplication1.exceptions;
using WebApplication1.Models;
using WebApplication1.Services;


namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrawTypesController : ControllerBase
    {

        private readonly IDrawTypeService _service;

        public DrawTypesController(IDrawTypeService service)
        {
            _service = service;

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
            try
            {
                var drawTypeDtoResult = await _service.AddAsync(drawTypeDto);
                return CreatedAtAction(nameof(GetDrawType), new { id = drawTypeDtoResult.Id }, drawTypeDtoResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Errore interno del server", details = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        //[Authorize(Roles = "admin")]
        public async Task<IActionResult> DeleteDrawType(long id)
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

        // PUT: api/draw_types/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDrawType(long id, DrawTypeDto drawTypeDto)
        {
            try
            {
                await _service.UpdateAsync(id, drawTypeDto);
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



    }
}

