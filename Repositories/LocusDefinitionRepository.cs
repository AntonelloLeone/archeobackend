using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class LocusDefinitionRepository : ILocusDefinitionRepository
    {
        private readonly Dek9s8aheu55lvContext _context;

        public LocusDefinitionRepository(Dek9s8aheu55lvContext context)
        {
            _context = context;
        }
        public async Task<LocusDefinition> AddAsync(LocusDefinition entity)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<LocusDefinition>> GetAllAsync()
        {
            try
            {
                return await _context.LocusDefinitions
                    .AsNoTracking()
                    .OrderBy(dt => dt.Id)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                
                throw new Exception("Errore durante il recupero di locus definition", ex);
            }
        }

        public async Task<LocusDefinition> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(LocusDefinition entity)
        {
            throw new NotImplementedException();
        }
    }
}
