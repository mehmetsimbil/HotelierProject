using Business.Requests.Subscribe;
using Business.Responses.Subscribe;
using HotelProject.Business.Requests.Subscribe;
using HotelProject.Business.Responses.Subscribe;

namespace HotelProject.Business.Abstracts
{
    public interface ISubscribeService
    {
        public AddSubscribeResponse Add(AddSubscribeRequest request);
        public GetSubscribeListResponse GetList(GetSubscribeListRequest request);
        public UpdateSubscribeResponse Update(UpdateSubscribeRequest request);
        public DeleteSubscribeResponse Delete(DeleteSubscribeRequest request);
        public GetSubscribeByIdResponse GetById(GetSubscribeByIdRequest request);
    }
}
