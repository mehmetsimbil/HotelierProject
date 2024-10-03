using HotelProject.Business.Requests.Service;
using HotelProject.Business.Responses.Service;

namespace HotelProject.Business.Abstracts
{
    public interface IServiceService
    {
        public AddServiceResponse Add(AddServiceRequest request);
        public GetServiceListResponse GetList(GetServiceListRequest request);
        public UpdateServiceResponse Update(UpdateServiceRequest request);
        public DeleteServiceResponse Delete(DeleteServiceRequest request);
    }
}
