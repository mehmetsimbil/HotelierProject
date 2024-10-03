using HotelProject.Business.Requests.MessageCategory;
using HotelProject.Business.Responses.MessageCategory;

namespace HotelProject.Business.Abstracts
{
    public interface IMessageCategoryService
    {
        public AddMessageCategoryResponse Add(AddMessageCategoryRequest request);
        public GetMessageCategoryListResponse GetList(GetMessageCategoryListRequest request);
        public UpdateMessageCategoryResponse Update(UpdateMessageCategoryRequest request);
        public DeleteMessageCategoryResponse Delete(DeleteMessageCategoryRequest request);
    }
}
