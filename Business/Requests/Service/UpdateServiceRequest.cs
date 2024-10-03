namespace HotelProject.Business.Requests.Service
{
    public class UpdateServiceRequest
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Icon { get; set; }
        public string? Description { get; set; }
    }
}
