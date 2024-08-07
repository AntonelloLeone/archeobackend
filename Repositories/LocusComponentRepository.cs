using System.Data.Entity.Core.Metadata.Edm;
using WebApplication1.exceptions;
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
            try
            {
                _context.LocusComponents.Add(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Errore durante l'aggiunta di draw type", ex);
            }

        }

        public async Task DeleteAsync(long id)
        {
            try
            {
                var entity = await _context.LocusComponents.FindAsync(id);
                if (entity == null)
                {
                    throw new NotFoundException($"DrawType with ID {id} not found.");
                }

                _context.LocusComponents.Remove(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Errore durante l'eliminazione di locus component", ex);
            }
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
            LocusComponent? locusComponent = await _context.LocusComponents
                .AsNoTracking()
                .FirstOrDefaultAsync(dt => dt.Id == id);
            return locusComponent;
        }

        public async Task UpdateAsync(LocusComponent entity)
        {
            try
            {

                _context.Entry(entity).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Lancia un'eccezione personalizzata
                throw new DataAccessException("Errore durante l'aggiornamento di draw type", ex);
            }
        }
    }
}
