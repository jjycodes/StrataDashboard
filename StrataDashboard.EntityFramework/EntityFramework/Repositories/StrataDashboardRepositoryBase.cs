using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace StrataDashboard.EntityFramework.Repositories
{
    public abstract class StrataDashboardRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<StrataDashboardDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected StrataDashboardRepositoryBase(IDbContextProvider<StrataDashboardDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class StrataDashboardRepositoryBase<TEntity> : StrataDashboardRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected StrataDashboardRepositoryBase(IDbContextProvider<StrataDashboardDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
