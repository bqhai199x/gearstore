using GearStore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Reposistories
{
    public class ProductReposistory : GenericRepository<Product>, IProductRepository
    {
        public ProductReposistory(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
