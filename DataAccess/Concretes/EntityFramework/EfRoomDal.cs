using HotelProject.DataAccess.Abstracts;
using HotelProject.DataAccess.Context;
using HotelProject.Entities.Concrete;

namespace HotelProject.DataAccess.Concretes.EntityFramework
{
    public class EfRoomDal : EfRepositoryBase<Room, HotelContext>, IRoomDal
    {
        public EfRoomDal(HotelContext context) : base(context)
        {
        }
    }
}
