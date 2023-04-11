using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Reposistories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {

        private readonly DbSet<TEntity> _dbSet;


        public GenericRepository(DbContext dbContext)
        {
            _dbSet = dbContext.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
    }
}
