using HotelProject.DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        public IAboutDal AboutDal { get; }
        public IBookingDal BookingDal { get; }
        public IContactDal ContactDal { get; }
        public IGuestDal GuestDal { get; }
        public IMessageCategoryDal MessageCategoryDal { get; }
        public IRoomDal RoomDal { get; }
        public ISendMessageDal MessageSendDal { get; }
        public IServiceDal ServiceDal { get; }
        public IStaffDal StaffDal { get; }
        public ISubscribeDal SubscribeDal { get; }
        public ITestimonialDal TestimonialDal { get; }
        public IUserDal UserDal { get; }
        public IWorkLocationDal WorkLocationDal { get; }
        int Save();
    }
}
