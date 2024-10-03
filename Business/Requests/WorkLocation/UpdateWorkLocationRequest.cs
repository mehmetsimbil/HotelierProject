namespace HotelProject.Business.Requests.WorkLocation
{
    public class UpdateWorkLocationRequest
    {
        public int Id { get; set; }
        public string? WorkLocationName { get; set; }
        public string? WorkLocationCity { get; set; }
    }
}
