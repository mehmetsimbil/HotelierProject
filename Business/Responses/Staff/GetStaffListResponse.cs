using HotelProject.Entities.Dto_s.StaffDto;

namespace HotelProject.Business.Responses.Staff
{
    public class GetStaffListResponse
    {
        public ICollection<StaffListItemDto> Items { get; set; }
    }
}
