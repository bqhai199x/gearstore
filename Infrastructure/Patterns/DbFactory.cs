using Infrastructure.Data;

namespace Infrastructure.Patterns
{
    public class DbFactory : Disposable, IDbFactory
    {
        private GearStoreContext _dbcontext;

        public GearStoreContext Init() => _dbcontext ?? (_dbcontext = new GearStoreContext());

        protected override void DisposeCore()
        {
            if(_dbcontext != null)
            {
                _dbcontext.Dispose();
            }
        }
    }
}
