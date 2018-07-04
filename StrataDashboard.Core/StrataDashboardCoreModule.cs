using System.Reflection;
using Abp.Modules;

namespace StrataDashboard
{
    public class StrataDashboardCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
