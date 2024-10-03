using HotelProject.Business.Requests.Contact;
using HotelProject.Business.Responses.Contact;

namespace HotelProject.Business.Abstracts
{
    public interface IContactService
    {
        public AddContactResponse Add(AddContactRequest request);
        public GetContactListResponse GetList(GetContactListRequest request);
        public UpdateContactResponse Update(UpdateContactRequest request);
        public DeleteContactResponse Delete(DeleteContactRequest request);
    }
}
