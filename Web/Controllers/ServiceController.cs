using Business.Requests.Service;
using Business.Responses.Service;
using HotelProject.Business.Abstracts;
using HotelProject.Business.Requests.Service;
using HotelProject.Business.Responses.Service;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IActionResult Index(GetServiceListRequest request)
        {
            GetServiceListResponse result = _serviceService.GetList(request);
            var model = result.Items;
            return View(model);
        }
        [HttpPost]
        public ActionResult AddService(AddServiceRequest request)
        {
            AddServiceResponse result = _serviceService.Add(request);

            return RedirectToAction("Index", "Service");
        }
        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetById(GetServiceByIdRequest request)
        {
            GetServiceByIdResponse response = _serviceService.GetById(request);
            var updateRequest = new UpdateServiceRequest
            {
                Id = response.Id,
                Title = response.Title,
                Icon = response.Icon,
                Description = response.Description,

            };
            return View("UpdateService", updateRequest);
        }
        [HttpPost]
        public ActionResult UpdateService(UpdateServiceRequest request)
        {
            UpdateServiceResponse result = _serviceService.Update(request);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteService(DeleteServiceRequest request)
        {
            DeleteServiceResponse result = _serviceService.Delete(request);
            return RedirectToAction("Index");
        }
    }
}
