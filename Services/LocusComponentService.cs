using AutoMapper;
using WebApplication1.Dtos;
using WebApplication1.exceptions;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Services
{
    public class LocusComponentService : ILocusComponentService
    {
        private readonly IMapper _mapper;
        private readonly ILocusComponentRepository _repository;

        public LocusComponentService(IMapper mapper, ILocusComponentRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }


        public async Task<LocusComponentDto> AddAsync(LocusComponentDto entity)
        {
            try
            {


                var locusComponent = _mapper.Map<LocusComponent>(entity);

                var addeLocusComponent = await _repository.AddAsync(locusComponent);

                return _mapper.Map<LocusComponentDto>(addeLocusComponent);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Errore durante l'aggiunta di draw type", ex);
            }
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

        public async Task<IEnumerable<LocusComponentDto>> GetAllAsync()
        {
            try
            {
                var locusComponents = await _repository.GetAllAsync();  
                return _mapper.Map<IEnumerable<LocusComponentDto>>(locusComponents);    
            }
            catch (Exception ex)
            {
                
                throw new ApplicationException("Errore durante il recupero dei Locus Components", ex);
            }
        }

        public async Task<LocusComponentDto> GetByIdAsync(long id)
        {
            var locusComponent = await _repository.GetByIdAsync(id);
            if (locusComponent == null)
            {
                throw new NotFoundException($"il draw type con ID {id} non trovato.");
            }
            return _mapper.Map<LocusComponentDto>(locusComponent);
        }

        public async Task UpdateAsync(long id, LocusComponentDto entity)
        {
            if (id != entity.Id)
            {
                throw new BadRequestException("ID mismatch.");
            }

            LocusComponent existingLocusComponent = await _repository.GetByIdAsync(id);
            if (existingLocusComponent == null)
            {
                throw new NotFoundException($"LocusComponent with ID {id} not found.");
            }

            // Mappa i dati del DTO all'entità esistente


            entity.UpdatedAt = DateTime.Now;

            _mapper.Map(entity, existingLocusComponent);

            //existingDrawType.UpdatedAt = drawTypeDto.UpdatedAt;

            await _repository.UpdateAsync(existingLocusComponent);
        }
    }
}
