using HotelProject.DataAccess.Abstracts;
using HotelProject.DataAccess.Context;
using HotelProject.Entities.Concrete;

namespace HotelProject.DataAccess.Concretes.EntityFramework
{
    public class EfServiceDal : EfRepositoryBase<Service, HotelContext>, IServiceDal
    {
        public EfServiceDal(HotelContext context) : base(context)
        {
        }
    }
}
