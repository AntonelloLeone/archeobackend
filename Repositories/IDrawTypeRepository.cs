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
        //Task AddAsync(DrawType entity);
        //Task UpdateAsync(DrawType entity);
        //Task DeleteAsync(int id);

    }
}
