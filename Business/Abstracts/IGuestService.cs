using Business.Requests.Guest;
using Business.Responses.Guest;
using HotelProject.Business.Requests.Guest;
using HotelProject.Business.Responses.Guest;

namespace HotelProject.Business.Abstracts
{
    public interface IGuestService
    {
        public AddGuestResponse Add(AddGuestRequest request);
        public GetGuestListResponse GetList(GetGuestListRequest request);
        public UpdateGuestResponse Update(UpdateGuestRequest request);
        public DeleteGuestResponse Delete(DeleteGuestRequest request);
        public GetGuestByIdResponse GetById (GetGuestByIdRequest request);
    }
}
