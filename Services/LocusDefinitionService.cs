using AutoMapper;
using WebApplication1.Dtos;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Services
{
    public class LocusDefinitionService : ILocusDefinitionService
    {
        private readonly IMapper _mapper;
        private readonly ILocusDefinitionRepository _repository;

        public LocusDefinitionService(IMapper mapper, ILocusDefinitionRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<LocusDefinitionDto> AddAsync(LocusDefinitionDto entity)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<LocusDefinitionDto>> GetAllAsync()
        {
            try
            {
                var locusDefinitions = await _repository.GetAllAsync();
                return _mapper.Map<IEnumerable<LocusDefinitionDto>>(locusDefinitions);
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Errore durante il recupero dei Locus Components", ex);
            }
        }

        public async Task<LocusDefinitionDto> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(long id, LocusDefinitionDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
