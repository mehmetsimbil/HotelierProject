namespace HotelProject.Business.Requests.About
{
    public class AddAboutRequest
    {
        public AddAboutRequest()
        {
            
        }
        public AddAboutRequest(string? title1, string? title2, string? content, int roomCount, int staffCount, int customerCount)
        {
            Title1 = title1;
            Title2 = title2;
            Content = content;
            RoomCount = roomCount;
            StaffCount = staffCount;
            CustomerCount = customerCount;
        }

        public string? Title1 { get; set; }
        public string? Title2 { get; set; }
        public string? Content { get; set; }
        public int RoomCount { get; set; }
        public int StaffCount { get; set; }
        public int CustomerCount { get; set; }
        
    }
}
