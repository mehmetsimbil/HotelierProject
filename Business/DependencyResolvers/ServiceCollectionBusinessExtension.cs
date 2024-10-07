using Business.Concretes;
using DataAccess.UnitOfWork;
using HotelProject.Business.Abstracts;
using HotelProject.Business.Concretes;
using HotelProject.DataAccess.Abstracts;
using HotelProject.DataAccess.Concretes.EntityFramework;
using HotelProject.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace Business.DependencyResolvers
{
    public static class ServiceCollectionBusinessExtension
    {
        public static IServiceCollection AddBusinessServices(
        this IServiceCollection services,
        IConfiguration configuration
    )
        {
            services
                .AddScoped<IAboutService, AboutManager>()
                .AddScoped<IAboutDal, EfAboutDal>()
                .AddScoped<IBookingService, BookingManager>()
                .AddScoped<IBookingDal, EfBookingDal>()
                .AddScoped<IContactService, ContactManager>()
                .AddScoped<IContactDal, EfContactDal>()
                .AddScoped<IGuestService, GuestManager>()
                .AddScoped<IGuestDal, EfGuestDal>()
                .AddScoped<IMessageCategoryService, MessageCategoryManager>()
                .AddScoped<IMessageCategoryDal, EfMessageCategoryDal>()
                .AddScoped<IRoomService, RoomManager>()
                .AddScoped<IRoomDal, EfRoomDal>()
                .AddScoped<ISendMessageService, SendMessageManager>()
                .AddScoped<ISendMessageDal, EfSendMessageDal>()
                .AddScoped<IServiceService, ServiceManager>()
                .AddScoped<IServiceDal, EfServiceDal>()
                .AddScoped<IStaffService, StaffManager>()
                .AddScoped<IStaffDal, EfStaffDal>()
                .AddScoped<ISubscribeService, SubscribeManager>()
                .AddScoped<ISubscribeDal, EfSubscribeDal>()
                .AddScoped<ITestimonialService, TestimonialManager>()
                .AddScoped<ITestimonialDal, EfTestimonialDal>()
                .AddScoped<IUserService, UserManager>()
                .AddScoped<IUserDal, EfUserDal>()
                .AddScoped<IWorkLocationService, WorkLocationManager>()
                .AddScoped<IWorkLocationDal, EfWorkLocationDal>()
                .AddScoped<IUnitOfWork, UnitOfWork>()
                .AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddDbContext<HotelContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("HotelierConnectionString")));

            return services;
        }
    }
}
