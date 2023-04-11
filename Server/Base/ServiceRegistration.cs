using Infrastructure.Data;
using Infrastructure.Patterns;
using Server.Services;

namespace Server.Base
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<GearStoreContext>();
            services.AddTransient<IDbFactory, DbFactory>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }

        public static void AddInjectService(this IServiceCollection services)
        {
            services.AddTransient<IProductService, ProductService>();
        }
    }
}
