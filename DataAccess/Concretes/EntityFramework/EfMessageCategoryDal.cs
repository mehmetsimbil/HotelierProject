using HotelProject.DataAccess.Abstracts;
using HotelProject.DataAccess.Context;
using HotelProject.Entities.Concrete;

namespace HotelProject.DataAccess.Concretes.EntityFramework
{
    public class EfMessageCategoryDal : EfRepositoryBase<MessageCategory, HotelContext>, IMessageCategoryDal
    {
        public EfMessageCategoryDal(HotelContext context) : base(context)
        {
        }
    }
}
