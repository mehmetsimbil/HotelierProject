using AutoMapper;
using Business.Requests.Guest;
using Business.Responses.Guest;
using DataAccess.UnitOfWork;
using HotelProject.Business.Abstracts;
using HotelProject.Business.Requests.Guest;
using HotelProject.Business.Responses.Guest;
using HotelProject.Entities.Concrete;

namespace HotelProject.Business.Concretes
{
    public class GuestManager : IGuestService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GuestManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public AddGuestResponse Add(AddGuestRequest request)
        {
            var guestToAdd = _mapper.Map<Guest>(request);
            Guest addedGuest = _unitOfWork.GuestDal.Add(guestToAdd);
            var response = _mapper.Map<AddGuestResponse>(addedGuest);
            _unitOfWork.Save();
            return response;
        }

        public DeleteGuestResponse Delete(DeleteGuestRequest request)
        {
            Guest? guestToDelete = _unitOfWork.GuestDal.Get(predicate: g=>g.Id == request.Id);
            if (guestToDelete == null)
            {
                throw new KeyNotFoundException($"No About found with ID {request.Id}");
            }


            guestToDelete.IsDeleted = true;
            Guest deletedGuest = _unitOfWork.GuestDal.Delete(guestToDelete!);
            var response= _mapper.Map<DeleteGuestResponse>(deletedGuest);
            _unitOfWork.Save();
            return response;
        }

        public GetGuestByIdResponse GetById(GetGuestByIdRequest request)
        {
            Guest? guest = _unitOfWork.GuestDal.Get(predicate: guest=>guest.Id == request.Id);
            var response = _mapper.Map<GetGuestByIdResponse>(guest);
            return response;
        }

        public GetGuestListResponse GetList(GetGuestListRequest request)
        {
            IList<Guest> guests = _unitOfWork.GuestDal.GetList();
            GetGuestListResponse response = _mapper.Map<GetGuestListResponse>(guests);
            return response;
        }

        public UpdateGuestResponse Update(UpdateGuestRequest request)
        {
            Guest? guestToUpdate = _unitOfWork.GuestDal.Get(predicate: g => g.Id == request.Id);
            guestToUpdate = _mapper.Map(request, guestToUpdate);
            Guest updatedGuest = _unitOfWork.GuestDal.Update(guestToUpdate!);
            var response = _mapper.Map<UpdateGuestResponse>(updatedGuest);
            _unitOfWork.Save();
            return response;
        }
    }
}
