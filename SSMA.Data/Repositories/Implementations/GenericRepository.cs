using Microsoft.EntityFrameworkCore;
using SSMA.Data.Context;
using SSMA.Data.Repositories.Abstractions;

namespace SSMA.Data.Repositories.Implementations
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly SsmaDbContext _context;
        private readonly DbSet<T> _dbSet;


        public GenericRepository(SsmaDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();


        }
        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public async Task InsertAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
