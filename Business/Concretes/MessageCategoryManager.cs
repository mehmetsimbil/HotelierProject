using AutoMapper;
using DataAccess.UnitOfWork;
using HotelProject.Business.Abstracts;
using HotelProject.Business.Requests.MessageCategory;
using HotelProject.Business.Responses.MessageCategory;
using HotelProject.Entities.Concrete;

namespace HotelProject.Business.Concretes
{
    public class MessageCategoryManager : IMessageCategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MessageCategoryManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public AddMessageCategoryResponse Add(AddMessageCategoryRequest request)
        {
            var messageCategoryToAdd = _mapper.Map<MessageCategory>(request);
            MessageCategory addedMessageCategory = _unitOfWork.MessageCategoryDal.Add(messageCategoryToAdd);
            var response = _mapper.Map<AddMessageCategoryResponse>(addedMessageCategory);
            _unitOfWork.Save();
            return response;
        }

        public DeleteMessageCategoryResponse Delete(DeleteMessageCategoryRequest request)
        {
            MessageCategory? messageCategoryToDelete =
                _unitOfWork.MessageCategoryDal.Get(predicate: mc => mc.Id == request.Id);
            if (messageCategoryToDelete == null)
            {
                throw new KeyNotFoundException($"No About found with ID {request.Id}");
            }


            messageCategoryToDelete.IsDeleted = true;
            MessageCategory deletedMessageCategory = 
                _unitOfWork.MessageCategoryDal.Delete(messageCategoryToDelete!);
            var response = _mapper.Map<DeleteMessageCategoryResponse>(deletedMessageCategory);
            _unitOfWork.Save();
            return response;
        }

        public GetMessageCategoryListResponse GetList(GetMessageCategoryListRequest request)
        {
            IList<MessageCategory> messageCategories = _unitOfWork.MessageCategoryDal.GetList();
            GetMessageCategoryListResponse response = _mapper.Map<GetMessageCategoryListResponse>(messageCategories);
            return response;
        }

        public UpdateMessageCategoryResponse Update(UpdateMessageCategoryRequest request)
        {
            MessageCategory? messageCategoryToUpdate = _unitOfWork.MessageCategoryDal.Get(predicate: mc => mc.Id == request.Id);
            messageCategoryToUpdate = _mapper.Map(request, messageCategoryToUpdate);
            MessageCategory updatedMessageCategory = _unitOfWork.MessageCategoryDal.Update(messageCategoryToUpdate!);
            var response = _mapper.Map<UpdateMessageCategoryResponse>(updatedMessageCategory);
            _unitOfWork.Save();
            return response;
        }
    }
}
