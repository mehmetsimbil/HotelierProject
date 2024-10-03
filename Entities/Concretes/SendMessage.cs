using HotelProject.Entities.Abstract;

namespace HotelProject.Entities.Concrete
{
    public class SendMessage : Entity<int>
    {
        public string? ReceiverName { get; set; }
        public string? ReceiverMail { get; set; }
        public string? SenderName { get; set; }
        public string? SenderMail { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
    }
}
