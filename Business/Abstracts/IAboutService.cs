using HotelProject.Business.Requests.About;
using HotelProject.Business.Responses.About;

namespace HotelProject.Business.Abstracts
{
    public interface IAboutService
    {
        public AddAboutResponse Add(AddAboutRequest request);
        public GetAboutListResponse GetList(GetAboutListRequest request);
        public UpdateAboutResponse Update(UpdateAboutRequest request);
        public DeleteAboutResponse Delete(DeleteAboutRequest request);
    }
}
