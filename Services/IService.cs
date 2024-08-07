namespace WebApplication1.Services
{
    public interface IService<T>
    {
        Task<T> GetByIdAsync(long id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(long id, T entity);
        Task DeleteAsync(long id);
    }
}
