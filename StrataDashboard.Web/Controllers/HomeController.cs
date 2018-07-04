using System.Web.Mvc;

namespace StrataDashboard.Web.Controllers
{
    public class HomeController : StrataDashboardControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}