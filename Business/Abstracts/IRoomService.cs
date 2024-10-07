using Business.Requests.Room;
using Business.Responses.Room;
using HotelProject.Business.Requests.Room;
using HotelProject.Business.Responses.Room;

namespace HotelProject.Business.Abstracts
{
    public interface IRoomService
    {
        public AddRoomResponse Add(AddRoomRequest request);
        public GetRoomListResponse GetList(GetRoomListRequest request);
        public UpdateRoomResponse Update(UpdateRoomRequest request);
        public DeleteRoomResponse Delete(DeleteRoomRequest request);
        public GetRoomByIdResponse GetById(GetRoomByIdRequest request);
    }
}
