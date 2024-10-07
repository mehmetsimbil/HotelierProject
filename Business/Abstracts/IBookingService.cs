using Business.Requests.Booking;
using Business.Responses.Booking;
using HotelProject.Business.Requests.Booking;
using HotelProject.Business.Responses.Booking;

namespace HotelProject.Business.Abstracts
{
    public interface IBookingService
    {
        public AddBookingResponse Add(AddBookingRequest request);
        public GetBookingListResponse GetList(GetBookingListRequest request);
        public UpdateBookingResponse Update(UpdateBookingRequest request);
        public DeleteBookingResponse Delete(DeleteBookingRequest request);
        public GetBookingByIdResponse GetById(GetBookingByIdRequest request);
    }
}
