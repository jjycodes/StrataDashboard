using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace StrataDashboard
{
    [DependsOn(typeof(AbpWebApiModule), typeof(StrataDashboardApplicationModule))]
    public class StrataDashboardWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(StrataDashboardApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
