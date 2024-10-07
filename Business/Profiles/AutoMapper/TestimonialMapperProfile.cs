using AutoMapper;
using Business.Responses.Testimonial;
using HotelProject.Business.Requests.Testimonial;
using HotelProject.Business.Responses.Testimonial;
using HotelProject.Entities.Concrete;
using HotelProject.Entities.Dto_s.TestimonialDto;

namespace HotelProject.Business.Profiles.AutoMapper
{
    public class TestimonialMapperProfile : Profile
    {
        public TestimonialMapperProfile()
        {
            CreateMap<AddTestimonialRequest, Testimonial>();
            CreateMap<Testimonial,AddTestimonialResponse>();

            CreateMap<Testimonial, TestimonialListItemDto>();
            CreateMap<IList<Testimonial>, GetTestimonialListResponse>();

            CreateMap<UpdateTestimonialRequest, Testimonial>();
            CreateMap<Testimonial,UpdateTestimonialResponse>();

            CreateMap<Testimonial, DeleteTestimonialResponse>();
            CreateMap<Testimonial,GetTestimonialByIdResponse>();
        }
    }
}
