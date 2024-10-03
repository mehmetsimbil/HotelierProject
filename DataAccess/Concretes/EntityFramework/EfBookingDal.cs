using HotelProject.DataAccess.Abstracts;
using HotelProject.DataAccess.Context;
using HotelProject.Entities.Concrete;

namespace HotelProject.DataAccess.Concretes.EntityFramework
{
    public class EfBookingDal : EfRepositoryBase<Booking, HotelContext>, IBookingDal
    {
        public EfBookingDal(HotelContext context) : base(context)
        {
        }
    }
}
