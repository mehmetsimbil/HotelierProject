using HotelProject.DataAccess.Abstracts;
using HotelProject.DataAccess.Context;

namespace DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HotelContext _context;

        public UnitOfWork(HotelContext context,
            IAboutDal aboutDal,
            IBookingDal bookingDal,
            IContactDal contactDal,
            IGuestDal guestDal,
            IMessageCategoryDal messageCategoryDal,
            IRoomDal roomDal,
            ISendMessageDal messageSendDal,
            IServiceDal serviceDal,
            IStaffDal staffDal,
            ISubscribeDal subscribeDal,
            ITestimonialDal testimonialDal,
            IUserDal userDal,
            IWorkLocationDal workLocationDal)
        {
            _context = context;
            AboutDal = aboutDal;
            BookingDal = bookingDal;
            ContactDal = contactDal;
            GuestDal = guestDal;
            MessageCategoryDal = messageCategoryDal;
            RoomDal = roomDal;
            MessageSendDal = messageSendDal;
            ServiceDal = serviceDal;
            StaffDal = staffDal;
            SubscribeDal = subscribeDal;
            TestimonialDal = testimonialDal;
            UserDal = userDal;
            WorkLocationDal = workLocationDal;
        }

        public IAboutDal AboutDal { get; set; }

        public IBookingDal BookingDal { get; set; }

        public IContactDal ContactDal { get; set; }

        public IGuestDal GuestDal { get; set; }

        public IMessageCategoryDal MessageCategoryDal { get; set; }

        public IRoomDal RoomDal { get; set; }

        public ISendMessageDal MessageSendDal { get; set; }

        public IServiceDal ServiceDal { get; set; }

        public IStaffDal StaffDal { get; set; }

        public ISubscribeDal SubscribeDal { get; set; }

        public ITestimonialDal TestimonialDal { get; set; }

        public IUserDal UserDal { get; set; }

        public IWorkLocationDal WorkLocationDal { get; set; }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
