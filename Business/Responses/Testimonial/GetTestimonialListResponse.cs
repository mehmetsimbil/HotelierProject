using HotelProject.Entities.Dto_s.TestimonialDto;

namespace HotelProject.Business.Responses.Testimonial
{
    public class GetTestimonialListResponse
    {
        public ICollection<TestimonialListItemDto> Items { get; set; }
    }
}
