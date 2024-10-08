using Business.Requests.Room;
using Business.Responses.About;
using Business.Responses.Room;
using HotelProject.Business.Abstracts;
using HotelProject.Business.Requests.Room;
using HotelProject.Business.Responses.Room;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class RoomController : Controller
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        public IActionResult Index(GetRoomListRequest request)
        {
            GetRoomListResponse result = _roomService.GetList(request);
            var model = result.Items;
            return View(model);
        }
        [HttpPost]
        public ActionResult AddRoom(AddRoomRequest request)
        {
            AddRoomResponse result = _roomService.Add(request);

            return RedirectToAction("Index", "Room");
        }
        [HttpGet]
        public IActionResult AddRoom()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetById(GetRoomByIdRequest request)
        {
            GetRoomByIdResponse response = _roomService.GetById(request);
            var updateRequest = new UpdateRoomRequest
            {
                Id = response.Id,
                RoomNumber = response.RoomNumber,
                RoomCoverImage = response.RoomCoverImage,
                Price = response.Price,
                Title = response.Title,
                BathCount = response.BathCount,
                BedCount = response.BedCount,
                Wifi = response.Wifi,
                Description = response.Description
            };
            return View("UpdateRoom", updateRequest);
        }
        [HttpPost]
        public ActionResult UpdateRoom(UpdateRoomRequest request)
        {
            UpdateRoomResponse result = _roomService.Update(request);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteRoom(DeleteRoomRequest request)
        {
            DeleteRoomResponse result = _roomService.Delete(request);
            return RedirectToAction("Index");
        }
    }
}
