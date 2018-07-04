using System.Reflection;
using Abp.Modules;

namespace StrataDashboard
{
    [DependsOn(typeof(StrataDashboardCoreModule))]
    public class StrataDashboardApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
