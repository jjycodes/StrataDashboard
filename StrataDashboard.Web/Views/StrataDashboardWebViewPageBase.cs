using Abp.Web.Mvc.Views;

namespace StrataDashboard.Web.Views
{
    public abstract class StrataDashboardWebViewPageBase : StrataDashboardWebViewPageBase<dynamic>
    {

    }

    public abstract class StrataDashboardWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected StrataDashboardWebViewPageBase()
        {

        }
    }
}