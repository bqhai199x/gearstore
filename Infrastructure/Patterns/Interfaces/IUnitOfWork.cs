using Infrastructure.Reposistories;

namespace Infrastructure.Patterns
{
    public interface IUnitOfWork
    {
        IProductRepository Product { get; }

        int Commit();

        Task<int> CommitAsync();
    }
}
