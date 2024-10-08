using Business.Requests.Service;
using Business.Requests.Subscribe;
using Business.Responses.Service;
using Business.Responses.Subscribe;
using HotelProject.Business.Abstracts;
using HotelProject.Business.Requests.Service;
using HotelProject.Business.Requests.Subscribe;
using HotelProject.Business.Responses.Service;
using HotelProject.Business.Responses.Subscribe;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class SubscribeController : Controller
    {
        private readonly ISubscribeService _subscribeService;

        public SubscribeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        public IActionResult Index(GetSubscribeListRequest request)
        {
            GetSubscribeListResponse result = _subscribeService.GetList(request);
            var model = result.Items;
            return View(model);
        }
        [HttpPost]
        public ActionResult AddSubscribe(AddSubscribeRequest request)
        {
            AddSubscribeResponse result = _subscribeService.Add(request);

            return RedirectToAction("Index", "Subscribe");
        }
        [HttpGet]
        public IActionResult AddSubscribe()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetById(GetSubscribeByIdRequest request)
        {
            GetSubscribeByIdResponse response = _subscribeService.GetById(request);
            var updateRequest = new UpdateSubscribeRequest
            {
                Id = response.Id,
                Mail=response.Mail,

            };
            return View("UpdateSubscribe", updateRequest);
        }
        [HttpPost]
        public ActionResult UpdateSubscribe(UpdateSubscribeRequest request)
        {
            UpdateSubscribeResponse result = _subscribeService.Update(request);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSubscribe(DeleteSubscribeRequest request)
        {
            DeleteSubscribeResponse result = _subscribeService.Delete(request);
            return RedirectToAction("Index");
        }
    }
}
