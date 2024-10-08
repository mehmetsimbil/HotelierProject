using AutoMapper;
using Business.Responses.About;
using HotelProject.Business.Requests.About;
using HotelProject.Business.Responses.About;
using HotelProject.Entities.Concrete;
using HotelProject.Entities.Dto_s.AboutDto;
namespace HotelProject.Business.Profiles.AutoMapper
{
    public class AboutMapperProfile : Profile
    {
        public AboutMapperProfile()
        {
            CreateMap<AddAboutRequest, About>();
            CreateMap<About, AddAboutResponse>();

            CreateMap<About,AboutListItemDto>();
            CreateMap<IList<About>,GetAboutListResponse>()
                .ForMember(dest => dest.Items,opt=> opt.MapFrom(src => src));

            CreateMap<About, DeleteAboutResponse>();
            CreateMap<UpdateAboutRequest,About>().ForMember(dest => dest.Id, opt => opt.Ignore()); ;
            CreateMap<About,UpdateAboutResponse>();

            CreateMap<About, GetAboutyByIdResponse>();
        }
    }
}
