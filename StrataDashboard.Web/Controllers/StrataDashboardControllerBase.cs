using Abp.Web.Mvc.Controllers;

namespace StrataDashboard.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class StrataDashboardControllerBase : AbpController
    {
        protected StrataDashboardControllerBase()
        {
            LocalizationSourceName = StrataDashboardConsts.LocalizationSourceName;
        }
    }
}