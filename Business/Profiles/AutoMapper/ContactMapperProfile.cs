using AutoMapper;
using Business.Responses.Contact;
using HotelProject.Business.Requests.Contact;
using HotelProject.Business.Responses.Contact;
using HotelProject.Entities.Concrete;
using HotelProject.Entities.Dto_s.ContactDto;

namespace HotelProject.Business.Profiles.AutoMapper
{
    public class ContactMapperProfile : Profile
    {
        public ContactMapperProfile()
        {
            CreateMap<AddContactRequest, Contact>();
            CreateMap<Contact, AddContactResponse>();
            CreateMap<Contact, ContactListItemDto>();
            CreateMap<IList<Contact>,GetContactListResponse>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src));
            CreateMap<Contact, DeleteContactResponse>();
            CreateMap<UpdateContactRequest, Contact>();
            CreateMap<Contact,UpdateContactResponse>();
            CreateMap<Contact,GetContactByIdResponse>();
        }
    }
}
