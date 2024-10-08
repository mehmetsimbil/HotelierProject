using Business.Requests.Testimonial;
using Business.Responses.Testimonial;
using HotelProject.Business.Abstracts;
using HotelProject.Business.Requests.Testimonial;
using HotelProject.Business.Responses.Testimonial;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class TestimonialController : Controller
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public IActionResult Index(GetTestimonialListRequest request)
        {
            GetTestimonialListResponse result = _testimonialService.GetList(request);
            var model = result.Items;
            return View(model);
        }
        [HttpPost]
        public ActionResult AddTestimonial(AddTestimonialRequest request)
        {
            AddTestimonialResponse result = _testimonialService.Add(request);

            return RedirectToAction("Index", "Testimonial");
        }
        [HttpGet]
        public IActionResult AddTestimonial()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetById(GetTestimonialByIdRequest request)
        {
            GetTestimonialByIdResponse response = _testimonialService.GetById(request);
            var updateRequest = new UpdateTestimonialRequest
            {
                Id = response.Id,
                Name = response.Name,
                Title= response.Title,
                Description= response.Description,

            };
            return View("UpdateTestimonial", updateRequest);
        }
        [HttpPost]
        public ActionResult UpdateTestimonial(UpdateTestimonialRequest request)
        {
            UpdateTestimonialResponse result = _testimonialService.Update(request);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteTestimonial(DeleteTestimonialRequest request)
        {
            DeleteTestimonialResponse result = _testimonialService.Delete(request);
            return RedirectToAction("Index");
        }
    }
}
