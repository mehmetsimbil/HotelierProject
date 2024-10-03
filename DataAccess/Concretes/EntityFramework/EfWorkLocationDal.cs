using HotelProject.DataAccess.Abstracts;
using HotelProject.DataAccess.Context;
using HotelProject.Entities.Concrete;

namespace HotelProject.DataAccess.Concretes.EntityFramework
{
    public class EfWorkLocationDal : EfRepositoryBase<WorkLocation, HotelContext>, IWorkLocationDal
    {
        public EfWorkLocationDal(HotelContext context) : base(context)
        {
        }
    }
}
