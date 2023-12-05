using Microsoft.AspNetCore.Mvc;

namespace CentumApps.Web.Controllers
{
    public class ContentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
