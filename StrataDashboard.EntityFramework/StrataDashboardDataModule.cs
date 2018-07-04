using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using StrataDashboard.EntityFramework;

namespace StrataDashboard
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(StrataDashboardCoreModule))]
    public class StrataDashboardDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<StrataDashboardDbContext>(null);
        }
    }
}
