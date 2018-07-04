using Abp.Application.Services;

namespace StrataDashboard
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class StrataDashboardAppServiceBase : ApplicationService
    {
        protected StrataDashboardAppServiceBase()
        {
            LocalizationSourceName = StrataDashboardConsts.LocalizationSourceName;
        }
    }
}