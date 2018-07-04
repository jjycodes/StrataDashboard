using Abp.Application.Navigation;
using Abp.Localization;

namespace StrataDashboard.Web
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See .cshtml and .js files under App/Main/views/layout/header to know how to render menu.
    /// </summary>
    public class StrataDashboardNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        "Home",
                        new LocalizableString("HomePage", StrataDashboardConsts.LocalizationSourceName),
                        url: "#/",
                        icon: "fa fa-home"
                        ))
                 .AddItem(
                    new MenuItemDefinition(
                        "Home",
                        new LocalizableString("Buildings", StrataDashboardConsts.LocalizationSourceName),
                        url: "#/buildings",
                        icon: "fa fa-home"
                    )).AddItem(
                    new MenuItemDefinition(
                        "About",
                        new LocalizableString("About", StrataDashboardConsts.LocalizationSourceName),
                        url: "#/about",
                        icon: "fa fa-info"
                        ));
        }
    }
}
