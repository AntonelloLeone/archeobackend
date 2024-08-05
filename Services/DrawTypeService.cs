using WebApplication1.Dtos;
using WebApplication1.exceptions;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Services
{
    public class DrawTypeService: IDrawTypeService
    {
        private readonly IDrawTypeRepository _repository;

        public DrawTypeService(IDrawTypeRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<DrawTypeDto>> GetAllAsync()
        {
            try
            {
                var entities = await _repository.GetAllAsync();
                return entities.Select(e => new DrawTypeDto
                {
                    Id = e.Id,
                    Name = e.Name,
                    CreatedAt = e.CreatedAt,
                    UpdatedAt = e.UpdatedAt
                });
            }
            catch (Exception ex)
            {
                // qui potremmo mettere eccezioni custom
                throw new ApplicationException("Errore durante il recupero di draw types-service", ex);
            }
        }

        public async Task<DrawTypeDto> GetByIdAsync(long id)
        {
            
                var drawType = await _repository.GetByIdAsync(id);
                if (drawType == null)
                {
                    throw new NotFoundException($"il draw type con ID {id} non trovato.");
                }
                return new DrawTypeDto
                {
                    Id = drawType.Id,
                    Name = drawType.Name,
                    CreatedAt = drawType.CreatedAt,
                    UpdatedAt = drawType.UpdatedAt
                };
           
        }
    }
}
