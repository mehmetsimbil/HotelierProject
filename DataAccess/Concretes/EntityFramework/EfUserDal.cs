using HotelProject.DataAccess.Abstracts;
using HotelProject.DataAccess.Context;
using HotelProject.Entities.Concrete;

namespace HotelProject.DataAccess.Concretes.EntityFramework
{
    public class EfUserDal : EfRepositoryBase<User, HotelContext>, IUserDal
    {
        public EfUserDal(HotelContext context) : base(context)
        {
        }
    }
}
