using AutoMapper;
using Business.Requests.SendMessage;
using Business.Responses.SendMessage;
using DataAccess.UnitOfWork;
using HotelProject.Business.Abstracts;
using HotelProject.Business.Requests.SendMessage;
using HotelProject.Business.Responses.SendMessage;
using HotelProject.Entities.Concrete;

namespace HotelProject.Business.Concretes
{
    public class SendMessageManager : ISendMessageService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SendMessageManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public AddSendMessageResponse Add(AddSendMessageRequest request)
        {
            var sendMessageToAdd = _mapper.Map<SendMessage>(request);
            SendMessage addedSendMessage = _unitOfWork.MessageSendDal.Add(sendMessageToAdd);
            var response = _mapper.Map<AddSendMessageResponse>(addedSendMessage);
            _unitOfWork.Save();
            return response;
        }

        public DeleteSendMessageResponse Delete(DeleteSendMessageRequest request)
        {
            SendMessage? sendMessageToDelete = _unitOfWork.MessageSendDal.Get(predicate: g => g.Id == request.Id);
            if (sendMessageToDelete == null)
            {
                throw new KeyNotFoundException($"No About found with ID {request.Id}");
            }


            sendMessageToDelete.IsDeleted = true;
            SendMessage deletedSendMessage = _unitOfWork.MessageSendDal.Delete(sendMessageToDelete!);
            var response = _mapper.Map<DeleteSendMessageResponse>(deletedSendMessage);
            _unitOfWork.Save();
            return response;
        }

        public GetSendMessageByIdResponse GetById(GetSendMessageByIdRequest request)
        {
            SendMessage? sendMessage = _unitOfWork.MessageSendDal.Get(predicate:sm=> sm.Id==request.Id);
            var response = _mapper.Map<GetSendMessageByIdResponse>(sendMessage);
            return response;
        }

        public GetSendMessageListResponse GetList(GetSendMessageListRequest request)
        {
            IList<SendMessage> sendMessages = _unitOfWork.MessageSendDal.GetList();
            GetSendMessageListResponse response = 
                _mapper.Map<GetSendMessageListResponse>(sendMessages);
            return response;
        }

        public UpdateSendMessageResponse Update(UpdateSendMessageRequest request)
        {
            SendMessage? sendMessageToUpdate = _unitOfWork.MessageSendDal.Get(predicate: g => g.Id == request.Id);
            sendMessageToUpdate = _mapper.Map(request, sendMessageToUpdate);
            SendMessage updatedSendMessage = _unitOfWork.MessageSendDal.Update(sendMessageToUpdate!);
            var response = _mapper.Map<UpdateSendMessageResponse>(updatedSendMessage);
            _unitOfWork.Save();
            return response;
        }
    }
}
