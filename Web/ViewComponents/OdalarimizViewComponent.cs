using HotelProject.Business.Abstracts;
using HotelProject.Business.Requests.Room;
using HotelProject.Business.Responses.Room;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
    public class OdalarimizViewComponent : ViewComponent
    {
        private readonly IRoomService _roomService;

        public OdalarimizViewComponent(IRoomService roomService)
        {
            _roomService = roomService;
        }

        public IViewComponentResult Invoke()
        {
            var req = new GetRoomListRequest();
            GetRoomListResponse result = _roomService.GetList(req);
            var model = result.Items;
            return View(model);

        }
    }
}
