using AutoMapper;
using HotelProject.Business.Requests.MessageCategory;
using HotelProject.Business.Responses.MessageCategory;
using HotelProject.Entities.Concrete;
using HotelProject.Entities.Dto_s.MessageCategoryDto;

namespace HotelProject.Business.Profiles.AutoMapper
{
    public class MessageCategoryMapperProfile : Profile
    {
        public MessageCategoryMapperProfile()
        {
            CreateMap<AddMessageCategoryRequest, MessageCategory>();
            CreateMap<MessageCategory, AddMessageCategoryResponse>();
            CreateMap<MessageCategory,MessageCategoryListItemDto>();
            CreateMap<IList<MessageCategory>,GetMessageCategoryListResponse>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src));
            CreateMap<UpdateMessageCategoryRequest,MessageCategory>();
            CreateMap<MessageCategory, UpdateMessageCategoryResponse>();
            CreateMap<MessageCategory,DeleteMessageCategoryResponse>();
        }
    }
}
