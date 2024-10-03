using HotelProject.DataAccess.Abstracts;
using HotelProject.DataAccess.Context;
using HotelProject.Entities.Concrete;

namespace HotelProject.DataAccess.Concretes.EntityFramework
{
    public class EfAboutDal : EfRepositoryBase<About, HotelContext>,IAboutDal
    {
        public EfAboutDal(HotelContext context) : base(context)
        {
        }
    }
}
