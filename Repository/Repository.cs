using System.Linq.Expressions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MahalCoffee.Data;

namespace MahalCoffee.Repsitory;
using MahalCoffee.Repository.IRepository;
public class Repository<T> : IRepository <T>  where T : class
{
    private readonly AppDbContext _db;
    internal DbSet<T> dbSet;

    public Repository(AppDbContext db)
    {
        _db = db;
        this.dbSet = db.Set<T>();
    }

    public async Task AddAsync(T entity)
    {
        await dbSet.AddAsync(entity);
        await _db.SaveChangesAsync();
    }

    public async  Task<T> GetAsync(Expression<Func<T, bool>> filter)
    {
        IQueryable<T> query = dbSet;
        query = query.Where(filter);
        return await query.FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        IQueryable<T> query = dbSet;
        return await query.ToListAsync();
    }

    public async Task RemoveAsync(T entity)
    {
        dbSet.Remove(entity);
    }

    public async Task DeleteRangeAsync(IEnumerable<T> entity)
    {
        dbSet.RemoveRange(entity);
    }
    
}