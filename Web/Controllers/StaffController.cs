using Business.Requests.Staff;
using Business.Responses.Staff;
using HotelProject.Business.Abstracts;
using HotelProject.Business.Requests.Staff;
using HotelProject.Business.Responses.Staff;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class StaffController : Controller
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService StaffService)
        {
            _staffService = StaffService;
        }

        public IActionResult Index(GetStaffListRequest request)
        {
            GetStaffListResponse result = _staffService.GetList(request);
            var model = result.Items;
            return View(model);
        }
        [HttpPost]
        public ActionResult AddStaff(AddStaffRequest request)
        {
            AddStaffResponse result = _staffService.Add(request);

            return RedirectToAction("Index", "Staff");
        }
        [HttpGet]
        public IActionResult AddStaff()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetById(GetStaffByIdRequest request)
        {
            GetStaffByIdResponse response = _staffService.GetById(request);
            var updateRequest = new UpdateStaffRequest
            {
                Id = response.Id,
                Name = response.Name,
                Title = response.Title,
                Image = response.Image,
                Github = response.Github,
                Instagram = response.Instagram,
                Linkedin = response.Linkedin
            };
            return View("UpdateStaff", updateRequest);
        }
        [HttpPost]
        public ActionResult UpdateStaff(UpdateStaffRequest request)
        {
            UpdateStaffResponse result = _staffService.Update(request);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteStaff(DeleteStaffRequest request)
        {
            DeleteStaffResponse result = _staffService.Delete(request);
            return RedirectToAction("Index");
        }
    }
}
