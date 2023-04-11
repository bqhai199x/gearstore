using Infrastructure.Data;
using Infrastructure.Reposistories;

namespace Infrastructure.Patterns
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory _dbFactory;

        private GearStoreContext _dbContext;


        private IProductRepository _product;
        public IProductRepository Product
        {
            get
            {
                _product = _product ?? new ProductReposistory(DbContext);
                return _product;
            }
        }

        public GearStoreContext DbContext => _dbContext ?? (_dbContext = _dbFactory.Init());


        public UnitOfWork(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public int Commit()
        {
            return DbContext.SaveChanges();
        }

        public Task<int> CommitAsync()
        {
            return DbContext.SaveChangesAsync();
        }
    }
}
