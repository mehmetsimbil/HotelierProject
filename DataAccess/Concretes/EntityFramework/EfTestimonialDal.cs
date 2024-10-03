using HotelProject.DataAccess.Abstracts;
using HotelProject.DataAccess.Context;
using HotelProject.Entities.Concrete;

namespace HotelProject.DataAccess.Concretes.EntityFramework
{
    public class EfTestimonialDal : EfRepositoryBase<Testimonial, HotelContext>, ITestimonialDal
    {
        public EfTestimonialDal(HotelContext context) : base(context)
        {
        }
    }
}
