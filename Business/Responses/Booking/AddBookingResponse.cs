﻿namespace HotelProject.Business.Responses.Booking
{
    public class AddBookingResponse
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Mail { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string? AdultCount { get; set; }
        public string? ChildrenCount { get; set; }
        public string? RoomCount { get; set; }
        public string? SpecialRequest { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
    }
}
