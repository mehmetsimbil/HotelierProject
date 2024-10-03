using HotelProject.DataAccess.Abstracts;
using HotelProject.DataAccess.Context;
using HotelProject.Entities.Concrete;

namespace HotelProject.DataAccess.Concretes.EntityFramework
{
    public class EfStaffDal : EfRepositoryBase<Staff, HotelContext>, IStaffDal
    {
        public EfStaffDal(HotelContext context) : base(context)
        {
        }
    }
}
