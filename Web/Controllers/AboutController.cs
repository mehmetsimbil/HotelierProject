using Business.Requests.About;
using Business.Responses.About;
using HotelProject.Business.Abstracts;
using HotelProject.Business.Requests.About;
using HotelProject.Business.Responses.About;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IActionResult Index(GetAboutListRequest request)
        {
            GetAboutListResponse result = _aboutService.GetList(request);
            var model = result.Items;
            return View(model);
        }
        [HttpPost]
        public ActionResult AddAbout(AddAboutRequest request)
        {
            AddAboutResponse result = _aboutService.Add(request);

            return RedirectToAction("Index", "About");
        }
        [HttpGet]
        public IActionResult AddAbout()
        {
            return View();
        }
        [HttpGet]
            public ActionResult GetById(GetAboutByIdRequest request)
            {
                GetAboutByIdResponse response = _aboutService.GetById(request);
            var updateRequest = new UpdateAboutRequest
            {
                Id = response.Id,
                Title1 = response.Title1,
                Title2 = response.Title2,
                Content = response.Content,
                RoomCount = response.RoomCount,
                StaffCount = response.StaffCount,
                CustomerCount = response.CustomerCount
            };
            return View("UpdateAbout", updateRequest);
            }
        [HttpPost]
        public ActionResult UpdateAbout(UpdateAboutRequest request)
        {
            UpdateAboutResponse result = _aboutService.Update(request);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteAbout(DeleteAboutRequest request)
        {
            DeleteAboutResponse result = _aboutService.Delete(request);
            return RedirectToAction("Index");
        }
    }
}
