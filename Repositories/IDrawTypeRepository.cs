using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Dtos;
using WebApplication1.Models;


namespace WebApplication1.Repositories
{
    public interface IDrawTypeRepository
    {
        Task<IEnumerable<DrawType>> GetAllAsync();
        Task<DrawType> GetByIdAsync(long id);

        Task<DrawType> AddAsync(DrawType drawType);
        Task UpdateAsync(DrawType drawType);

        Task DeleteAsync(long id);

    }
}
