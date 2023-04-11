using Infrastructure.Data;

namespace Infrastructure.Patterns
{
    public interface IDbFactory : IDisposable
    {
        GearStoreContext Init();
    }
}
