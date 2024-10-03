using HotelProject.Entities.Dto_s.WorkLocationDto;

namespace HotelProject.Business.Responses.WorkLocation
{
    public class GetWorkLocationListResponse
    {
        public ICollection<WorkLocationListItemDto> Items { get; set; }
    }
}
