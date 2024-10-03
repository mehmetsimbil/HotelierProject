namespace HotelProject.Business.Requests.Guest
{
    public class UpdateGuestRequest
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? City { get; set; }
    }
}
