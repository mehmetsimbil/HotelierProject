using HotelProject.DataAccess.Abstracts;
using HotelProject.DataAccess.Context;
using HotelProject.Entities.Concrete;

namespace HotelProject.DataAccess.Concretes.EntityFramework
{
    public class EfSubscribeDal : EfRepositoryBase<Subscribe, HotelContext>, ISubscribeDal
    {
        public EfSubscribeDal(HotelContext context) : base(context)
        {
        }
    }
}
