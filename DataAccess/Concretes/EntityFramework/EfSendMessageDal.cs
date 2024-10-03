using HotelProject.DataAccess.Abstracts;
using HotelProject.DataAccess.Context;
using HotelProject.Entities.Concrete;

namespace HotelProject.DataAccess.Concretes.EntityFramework
{
    public class EfSendMessageDal : EfRepositoryBase<SendMessage, HotelContext>, ISendMessageDal
    {
        public EfSendMessageDal(HotelContext context) : base(context)
        {
        }
    }
}
