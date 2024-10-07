using AutoMapper;
using Business.Responses.SendMessage;
using HotelProject.Business.Requests.SendMessage;
using HotelProject.Business.Responses.SendMessage;
using HotelProject.Entities.Concrete;
using HotelProject.Entities.Dto_s.SendMessageDto;

namespace HotelProject.Business.Profiles.AutoMapper
{
    public class SendMessageMapperProfile : Profile
    {
        public SendMessageMapperProfile()
        {
            CreateMap<AddSendMessageRequest, SendMessage>();
            CreateMap<SendMessage,AddSendMessageResponse>();
            CreateMap<SendMessage,SendMessageListItemDto>();
            CreateMap<IList<SendMessage>,GetSendMessageListResponse>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src));
            CreateMap<UpdateSendMessageRequest, SendMessage>();
            CreateMap<SendMessage, UpdateSendMessageResponse>();
            CreateMap<SendMessage,DeleteSendMessageResponse>();
            CreateMap<SendMessage, GetSendMessageByIdResponse>();
        }
    }
}
