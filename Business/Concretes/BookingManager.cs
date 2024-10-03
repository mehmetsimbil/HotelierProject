using AutoMapper;
using DataAccess.UnitOfWork;
using HotelProject.Business.Abstracts;
using HotelProject.Business.Requests.Booking;
using HotelProject.Business.Responses.Booking;
using HotelProject.Entities.Concrete;

namespace HotelProject.Business.Concretes
{
    public class BookingManager : IBookingService

    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BookingManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public AddBookingResponse Add(AddBookingRequest request)
        {
            var bookingToAdd = _mapper.Map<Booking>(request);
            Booking addedBooking = _unitOfWork.BookingDal.Add(bookingToAdd);
            var response = _mapper.Map<AddBookingResponse>(addedBooking);
            _unitOfWork.Save();
            return response;
        }

        public DeleteBookingResponse Delete(DeleteBookingRequest request)
        {
            Booking? bookingToDelete = _unitOfWork.BookingDal.Get(predicate: a => a.Id == request.Id);
            Booking deletedBooking = _unitOfWork.BookingDal.Delete(bookingToDelete!);
            var response = _mapper.Map<DeleteBookingResponse>(deletedBooking);
            _unitOfWork.Save();
            return response;
        }

        public GetBookingListResponse GetList(GetBookingListRequest request)
        {
            IList<Booking> bookings = _unitOfWork.BookingDal.GetList();
            GetBookingListResponse response = _mapper.Map<GetBookingListResponse>(bookings);
            return response;
        }

        public UpdateBookingResponse Update(UpdateBookingRequest request)
        {
            Booking? bookingToUpdate = _unitOfWork.BookingDal.Get(predicate: b => b.Id == request.Id);
            bookingToUpdate = _mapper.Map(request, bookingToUpdate);
            Booking updatedBooking = _unitOfWork.BookingDal.Update(bookingToUpdate!);
            var response = _mapper.Map<UpdateBookingResponse>(updatedBooking);
            _unitOfWork.Save();
            return response;
        }
    }
}
