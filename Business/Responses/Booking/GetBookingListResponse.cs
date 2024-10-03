using HotelProject.Entities.Dto_s.BookingDto;

namespace HotelProject.Business.Responses.Booking
{
    public class GetBookingListResponse
    {
        public ICollection<BookingListItemDto> Items { get; set; }
    }
}
