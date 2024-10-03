using HotelProject.Entities.Dto_s.ServiceDto;

namespace HotelProject.Business.Responses.Service
{
    public class GetServiceListResponse
    {
        public ICollection<ServiceListItemDto> Items { get; set; }
    }
}
