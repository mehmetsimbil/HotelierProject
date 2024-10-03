using AutoMapper;
using DataAccess.UnitOfWork;
using HotelProject.Business.Abstracts;
using HotelProject.Business.Requests.Contact;
using HotelProject.Business.Responses.Contact;
using HotelProject.Entities.Concrete;

namespace HotelProject.Business.Concretes
{
    public class ContactManager : IContactService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ContactManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public AddContactResponse Add(AddContactRequest request)
        {
            var contactToAdd = _mapper.Map<Contact>(request);
            Contact addedContact = _unitOfWork.ContactDal.Add(contactToAdd);
            var response = _mapper.Map<AddContactResponse>(addedContact);
            _unitOfWork.Save();
            return response;
        }

        public DeleteContactResponse Delete(DeleteContactRequest request)
        {
            Contact? contactToDelete = _unitOfWork.ContactDal.Get(predicate: c => c.Id == request.Id);
            Contact deletedContact = _unitOfWork.ContactDal.Delete(contactToDelete!);
            var response = _mapper.Map<DeleteContactResponse>(deletedContact);
            _unitOfWork.Save();
            return response;
        }

        public GetContactListResponse GetList(GetContactListRequest request)
        {
            IList<Contact> contacts = _unitOfWork.ContactDal.GetList();
            GetContactListResponse response = _mapper.Map<GetContactListResponse>(contacts);
            return response;
        }

        public UpdateContactResponse Update(UpdateContactRequest request)
        {
            Contact? contactToUpdate = _unitOfWork.ContactDal.Get(predicate: c => c.Id == request.Id);
            contactToUpdate = _mapper.Map(request, contactToUpdate);
            Contact updatedContact = _unitOfWork.ContactDal.Update(contactToUpdate!);
            var response = _mapper.Map<UpdateContactResponse>(updatedContact);
            _unitOfWork.Save();
            return response;
        }
    }
}
