using HotelProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.DataAccess.Context
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions<HotelContext> options) : base(options) 
        {
            
        }
        
        public DbSet<About> Abouts { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<MessageCategory> MessageCategories { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<SendMessage> SendMessages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Subscribe> Subscriptions { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<WorkLocation> WorkLocations { get; set; }

    }
}
