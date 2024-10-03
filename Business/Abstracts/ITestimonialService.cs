using HotelProject.Business.Requests.Testimonial;
using HotelProject.Business.Responses.Testimonial;

namespace HotelProject.Business.Abstracts
{
    public interface ITestimonialService
    {
        public AddTestimonialResponse Add(AddTestimonialRequest request);
        public GetTestimonialListResponse GetList(GetTestimonialListRequest request);
        public UpdateTestimonialResponse Update(UpdateTestimonialRequest request);
        public DeleteTestimonialResponse Delete(DeleteTestimonialRequest request);
    }
}
