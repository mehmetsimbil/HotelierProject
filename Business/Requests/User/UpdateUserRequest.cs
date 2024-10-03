﻿namespace HotelProject.Business.Requests.User
{
    public class UpdateUserRequest
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? Gender { get; set; }
        public string? WorkDepartment { get; set; }
        public int WorkLocationID { get; set; }
    }
}
