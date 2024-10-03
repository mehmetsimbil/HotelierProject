namespace HotelProject.Business.Requests.Contact
{
    public class UpdateContactRequest
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Mail { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
        public int MessageCategoryID { get; set; }
    }
}
