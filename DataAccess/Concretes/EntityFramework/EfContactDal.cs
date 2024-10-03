using HotelProject.DataAccess.Abstracts;
using HotelProject.DataAccess.Context;
using HotelProject.Entities.Concrete;

namespace HotelProject.DataAccess.Concretes.EntityFramework
{
    public class EfContactDal : EfRepositoryBase<Contact, HotelContext>, IContactDal
    {
        public EfContactDal(HotelContext context) : base(context)
        {
        }
    }
}
