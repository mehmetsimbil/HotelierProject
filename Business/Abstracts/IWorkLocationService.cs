using HotelProject.Business.Requests.WorkLocation;
using HotelProject.Business.Responses.WorkLocation;

namespace HotelProject.Business.Abstracts
{
    public interface IWorkLocationService
    {
        public AddWorkLocationResponse Add(AddWorkLocationRequest request);
        public GetWorkLocationListResponse Get(GetWorkLocationRequest request);
        public UpdateWorkLocationResponse Update(UpdateWorkLocationRequest request);
        public DeleteWorkLocationResponse Delete(DeleteWorkLocationRequest request);
    }
}
