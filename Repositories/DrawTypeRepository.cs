using WebApplication1.Dtos;
using WebApplication1.exceptions;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class DrawTypeRepository : IDrawTypeRepository
    {

        private readonly Dek9s8aheu55lvContext _context;

        public DrawTypeRepository(Dek9s8aheu55lvContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DrawType>> GetAllAsync()
        {
            try
            {
                return await _context.DrawTypes
                    .AsNoTracking()
                    .OrderBy(dt => dt.Id)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                // qui vedere il tipo che vogliamo lanciare
                throw new Exception("Errore durante il recupero di draw types", ex);
            }
        }

        public async Task<DrawType> GetByIdAsync(long id)
        {

            DrawType? drawType = await _context.DrawTypes
                .AsNoTracking()
                .FirstOrDefaultAsync(dt => dt.Id == id);
            return drawType;

        }

        public async Task<DrawType> AddAsync(DrawType drawType)
        {
            try
            {
                _context.DrawTypes.Add(drawType);
                await _context.SaveChangesAsync();
                return drawType;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Errore durante l'aggiunta di draw type", ex);
            }
        }

        public async Task UpdateAsync(DrawType drawType)
        {
            try
            {
                drawType.UpdatedAt = DateTime.Now;
                drawType.UpdatedAt = DateTime.SpecifyKind(drawType.UpdatedAt, DateTimeKind.Local);
                drawType.CreatedAt = DateTime.SpecifyKind(drawType.CreatedAt, DateTimeKind.Local);
                _context.Entry(drawType).State = EntityState.Modified;
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
