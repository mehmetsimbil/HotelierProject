using AutoMapper;
using DataAccess.UnitOfWork;
using HotelProject.Business.Abstracts;
using HotelProject.Business.Requests.Room;
using HotelProject.Business.Responses.Room;
using HotelProject.Entities.Concrete;

namespace HotelProject.Business.Concretes
{
    public class RoomManager : IRoomService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RoomManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public AddRoomResponse Add(AddRoomRequest request)
        {
            var roomToAdd = _mapper.Map<Room>(request);
            Room addedRoom =  _unitOfWork.RoomDal.Add(roomToAdd);
            var response = _mapper.Map<AddRoomResponse>(addedRoom);
            _unitOfWork.Save();
            return response;
        }

        public DeleteRoomResponse Delete(DeleteRoomRequest request)
        {
            Room? roomToDelete = _unitOfWork.RoomDal.Get(predicate:r=>r.Id == request.Id);
            Room deletedRoom = _unitOfWork.RoomDal.Delete(roomToDelete!);
            var response = _mapper.Map<DeleteRoomResponse>(deletedRoom);
            _unitOfWork.Save();
            return response;
        }

        public GetRoomListResponse GetList(GetRoomListRequest request)
        {
            IList<Room> rooms = _unitOfWork.RoomDal.GetList();
            GetRoomListResponse response = _mapper.Map<GetRoomListResponse>(rooms);
            return response;
        }

        public UpdateRoomResponse Update(UpdateRoomRequest request)
        {
            Room? roomToUpdate = _unitOfWork.RoomDal.Get(predicate: r => r.Id == request.Id);
            roomToUpdate = _mapper.Map(request, roomToUpdate);
            Room updatedRoom = _unitOfWork.RoomDal.Update(roomToUpdate!);
            var response = _mapper.Map<UpdateRoomResponse>(updatedRoom);
            _unitOfWork.Save();
            return response;
        }
    }
}
