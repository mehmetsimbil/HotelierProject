using Business.Requests.SendMessage;
using Business.Responses.SendMessage;
using HotelProject.Business.Requests.SendMessage;
using HotelProject.Business.Responses.SendMessage;

namespace HotelProject.Business.Abstracts
{
    public interface ISendMessageService
    {
        public AddSendMessageResponse Add(AddSendMessageRequest request);
        public GetSendMessageListResponse GetList(GetSendMessageListRequest request);
        public DeleteSendMessageResponse Delete(DeleteSendMessageRequest request);
        public UpdateSendMessageResponse Update(UpdateSendMessageRequest request);
        public GetSendMessageByIdResponse GetById(GetSendMessageByIdRequest request);
    }
}
