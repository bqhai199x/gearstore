using GearStore.Entities;

namespace Server.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();

        Task<IEnumerable<Product>> GetAllAsync();
    }
}
