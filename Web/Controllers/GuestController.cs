using Business.Requests.Guest;
using Business.Responses.Guest;
using HotelProject.Business.Abstracts;
using HotelProject.Business.Requests.Guest;
using HotelProject.Business.Responses.Guest;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class GuestController : Controller
    {
        private readonly IGuestService _guestService;

        public GuestController(IGuestService guestService)
        {
            _guestService = guestService;
        }

        public IActionResult Index(GetGuestListRequest request)
        {
            GetGuestListResponse result = _guestService.GetList(request);
            var model = result.Items;
            return View(model);
        }
        [HttpPost]
        public ActionResult AddGuest(AddGuestRequest request)
        {
            AddGuestResponse result = _guestService.Add(request);

            return RedirectToAction("Index", "Guest");
        }
        [HttpGet]
        public IActionResult AddGuest()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetById(GetGuestByIdRequest request)
        {
            GetGuestByIdResponse response = _guestService.GetById(request);
            var updateRequest = new UpdateGuestRequest
            {
                Id = response.Id,
                Name = response.Name,
                Surname = response.Surname,
                City = response.City,
               
            };
            return View("UpdateGuest", updateRequest);
        }
        [HttpPost]
        public ActionResult UpdateGuest(UpdateGuestRequest request)
        {
            UpdateGuestResponse result = _guestService.Update(request);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteGuest(DeleteGuestRequest request)
        {
            DeleteGuestResponse result = _guestService.Delete(request);
            return RedirectToAction("Index");
        }
    }
}

