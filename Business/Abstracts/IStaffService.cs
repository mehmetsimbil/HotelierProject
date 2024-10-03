using HotelProject.Business.Requests.Staff;
using HotelProject.Business.Responses.Staff;

namespace HotelProject.Business.Abstracts
{
    public interface IStaffService
    {
        public AddStaffResponse Add(AddStaffRequest request);
        public GetStaffListResponse GetList(GetStaffListRequest request);
        public UpdateStaffResponse Update(UpdateStaffRequest request);
        public DeleteStaffResponse Delete(DeleteStaffRequest request);
    }
}
