using AutoMapper;
using System.Data.Entity.Core.Metadata.Edm;
using WebApplication1.Dtos;
using WebApplication1.exceptions;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Services
{
    public class DrawTypeService: IDrawTypeService
    {
        private readonly IMapper _mapper;
        private readonly IDrawTypeRepository _repository;

        public DrawTypeService(IMapper mapper, IDrawTypeRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<IEnumerable<DrawTypeDto>> GetAllAsync()
        {
            try
            {
                var drawTypes = await _repository.GetAllAsync();
                return _mapper.Map<IEnumerable<DrawTypeDto>>(drawTypes);
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
                return _mapper.Map<DrawTypeDto>(drawType);

        }

        public async Task<DrawTypeDto> AddAsync(DrawTypeDto drawTypeDto)
        {
            try
            {
                

                var drawType = _mapper.Map<DrawType>(drawTypeDto);

                var addedDrawType = await _repository.AddAsync(drawType);

                return _mapper.Map<DrawTypeDto>(addedDrawType);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Errore durante l'aggiunta di draw type", ex);
            }
        }

        public async Task UpdateAsync(long id, DrawTypeDto drawTypeDto)
        {
            if (id != drawTypeDto.Id)
            {
                throw new BadRequestException("ID mismatch.");
            }

            DrawType existingDrawType = await _repository.GetByIdAsync(id);
            if (existingDrawType == null)
            {
                throw new NotFoundException($"DrawType with ID {id} not found.");
            }

            // Mappa i dati del DTO all'entità esistente
            

            drawTypeDto.UpdatedAt = DateTime.Now;
            
            _mapper.Map(drawTypeDto, existingDrawType);

            //existingDrawType.UpdatedAt = drawTypeDto.UpdatedAt;

            await _repository.UpdateAsync(existingDrawType);
        }

        public async Task DeleteAsync(long id)
        {
            try
            {
                await _repository.DeleteAsync(id);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Errore durante l'eliminazione di draw type", ex);
            }
        }

    }
}
