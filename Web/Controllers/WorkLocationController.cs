using HotelProject.Business.Abstracts;
using HotelProject.Business.Requests.WorkLocation;
using HotelProject.Business.Responses.WorkLocation;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class WorkLocationController : Controller
    {
        private readonly IWorkLocationService _workLocationService;

        public WorkLocationController(IWorkLocationService workLocationService)
        {
            _workLocationService = workLocationService;
        }

        public IActionResult Index(GetWorkLocationRequest request)
        {
            GetWorkLocationListResponse result = _workLocationService.Get(request);
            var model = result.Items;
            return View(model);
        }
        [HttpPost]
        public ActionResult AddWorkLocation(AddWorkLocationRequest request)
        {
            AddWorkLocationResponse result = _workLocationService.Add(request);

            return RedirectToAction("Index", "WorkLocation");
        }
        [HttpGet]
        public IActionResult AddWorkLocation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateWorkLocation(UpdateWorkLocationRequest request)
        {
            UpdateWorkLocationResponse result = _workLocationService.Update(request);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteWorkLocation(DeleteWorkLocationRequest request)
        {
            DeleteWorkLocationResponse result = _workLocationService.Delete(request);
            return RedirectToAction("Index");
        }
    }
}
