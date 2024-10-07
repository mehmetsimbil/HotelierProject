using Business.Requests.Booking;
using Business.Responses.Booking;
using HotelProject.Business.Abstracts;
using HotelProject.Business.Requests.Booking;
using HotelProject.Business.Responses.Booking;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class BookingController : Controller
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        public IActionResult Index(GetBookingListRequest request)
        {
            GetBookingListResponse result = _bookingService.GetList(request);
            var model = result.Items;
            return View(model);
        }
        [HttpPost]
        public ActionResult AddBooking(AddBookingRequest request)
        {
            AddBookingResponse result = _bookingService.Add(request);

            return RedirectToAction("Index", "Booking");
        }
        [HttpGet]
        public IActionResult AddBooking()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetById(GetBookingByIdRequest request)
        {
            GetBookingByIdResponse response = _bookingService.GetById(request);
            var updateRequest = new UpdateBookingRequest
            {
                Id = response.Id,
                Name= response.Name,
                Mail= response.Mail,
                CheckIn=response.CheckIn,
                CheckOut=response.CheckOut,
                AdultCount=response.AdultCount,
                ChildrenCount=response.ChildrenCount,
                RoomCount=response.RoomCount,
                SpecialRequest=response.SpecialRequest,
                Description=response.Description,
                Status=response.Status,
                City=response.City,
                Country=response.Country
                
            };
            return View("UpdateBooking", updateRequest);
        }
        [HttpPost]
        public ActionResult UpdateBooking(UpdateBookingRequest request)
        {
            UpdateBookingResponse result = _bookingService.Update(request);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteBooking(DeleteBookingRequest request)
        {
            DeleteBookingResponse result = _bookingService.Delete(request);
            return RedirectToAction("Index");
        }
    }
}

