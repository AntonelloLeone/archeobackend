using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class LocusComponentRepository : ILocusComponentRepository
    {

        private readonly Dek9s8aheu55lvContext _context;

        public LocusComponentRepository(Dek9s8aheu55lvContext context)
        {
            _context = context;
        }

        public async Task<LocusComponent> AddAsync(LocusComponent entity)
        {
            throw new NotImplementedException();

        }

        public async Task DeleteAsync(LocusComponent entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<LocusComponent>> GetAllAsync()
        {
            try
            {
                return await _context.LocusComponents
                    .AsNoTracking()
                    .OrderBy(dt => dt.Id)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                // qui vedere il tipo che vogliamo lanciare
                throw new Exception("Errore durante il recupero di locus component", ex);
            }
        }

        public async Task<LocusComponent> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<LocusComponent> UpdateAsync(LocusComponent entity)
        {
            throw new NotImplementedException();
        }
    }
}
