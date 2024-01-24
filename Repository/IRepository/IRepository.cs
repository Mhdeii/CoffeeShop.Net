using System.Linq.Expressions;

namespace MahalCoffee.Repository.IRepository;

public interface IRepository<T> where T : class
{
 //T is product or barista
 Task<IEnumerable<T>> GetAllAsync();
 Task<T> GetAsync(Expression<Func<T, bool>> filter);
 Task AddAsync(T entity);
 Task RemoveAsync(T entity);
 Task DeleteRangeAsync(IEnumerable<T> entity);

}