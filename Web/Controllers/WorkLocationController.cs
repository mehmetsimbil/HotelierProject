using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class WorkLocationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
