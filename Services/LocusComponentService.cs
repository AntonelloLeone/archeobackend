using AutoMapper;
using WebApplication1.Dtos;
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
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(LocusComponentDto entity)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public async Task<LocusComponentDto> UpdateAsync(LocusComponentDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
