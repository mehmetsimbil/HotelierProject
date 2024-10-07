using AutoMapper;
using Business.Responses.Booking;
using HotelProject.Business.Requests.Booking;
using HotelProject.Business.Responses.Booking;
using HotelProject.Entities.Concrete;
using HotelProject.Entities.Dto_s.BookingDto;

namespace HotelProject.Business.Profiles.AutoMapper
{
    public class BookingMapperProfile : Profile
    {
        public BookingMapperProfile()
        {
            CreateMap<AddBookingRequest, Booking>();
            CreateMap<Booking, AddBookingResponse>();
            CreateMap<Booking,BookingListItemDto>();
            CreateMap<IList<Booking>,GetBookingListResponse>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src));
            CreateMap<Booking, DeleteBookingResponse>();
            CreateMap<UpdateBookingRequest, Booking>();
            CreateMap<Booking, UpdateBookingResponse>();
            CreateMap<Booking, GetBookingByIdResponse>();
        }
    }
}
