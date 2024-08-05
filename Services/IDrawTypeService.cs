using WebApplication1.Dtos;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IDrawTypeService
    {
        Task<IEnumerable<DrawTypeDto>> GetAllAsync();
        Task<DrawTypeDto> GetByIdAsync(long id);
    }
}
