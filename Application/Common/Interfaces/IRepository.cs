namespace Application.Common.Interfaces;

public interface IRepository<T> where T : class
{
    Task<List<T>> GetAll();
    Task<T> Get(Guid Id);
    Task<T> AddAsync(T entity);
    Task<ICollection<T>> AddRangeAsync(ICollection<T> entities);
    Task<bool> UpdateAsync(T entity);
    Task<bool> DeleteAsync(T entity);

}
