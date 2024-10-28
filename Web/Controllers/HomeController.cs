using HotelProject.Business.Abstracts;
using HotelProject.Business.Requests.About;
using HotelProject.Entities.Dto_s.AboutDto;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAboutService _aboutService;

        public HomeController(ILogger<HomeController> logger,IAboutService aboutService)
        {
            _logger = logger;
            _aboutService = aboutService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //public IActionResult _Hakkimizda(GetAboutListRequest request)
        //{
        //    var result = _aboutService.GetList(request);
        //    var model = result.Items; 
        //    return PartialView( model);
        //}


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
