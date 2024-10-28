using Business.Requests.About;
using Business.Responses.About;
using HotelProject.Business.Requests.About;
using HotelProject.Business.Responses.About;
using HotelProject.Entities.Concrete;

namespace HotelProject.Business.Abstracts
{
    public interface IAboutService
    {
        public AddAboutResponse Add(AddAboutRequest request);
        public GetAboutListResponse GetList(GetAboutListRequest request);
        public UpdateAboutResponse Update(UpdateAboutRequest request);
        public DeleteAboutResponse Delete(DeleteAboutRequest request);
        public GetAboutByIdResponse GetById(GetAboutByIdRequest request);

        public IList<About> GetListToExcel();
    }
}
