using Business.Requests.SendMessage;
using Business.Responses.SendMessage;
using HotelProject.Business.Abstracts;
using HotelProject.Business.Requests.SendMessage;
using HotelProject.Business.Responses.SendMessage;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class SendMessageController : Controller
    {
        private readonly ISendMessageService _sendMessageService;

        public SendMessageController(ISendMessageService sendMessageService)
        {
            _sendMessageService = sendMessageService;
        }

        public IActionResult Index(GetSendMessageListRequest request)
        {
            GetSendMessageListResponse result = _sendMessageService.GetList(request);
            var model = result.Items;
            return View(model);
        }
        [HttpPost]
        public ActionResult AddSendMessage(AddSendMessageRequest request)
        {
            AddSendMessageResponse result = _sendMessageService.Add(request);

            return RedirectToAction("Index", "SendMessage");
        }
        [HttpGet]
        public IActionResult AddSendMessage()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetById(GetSendMessageByIdRequest request)
        {
            GetSendMessageByIdResponse response = _sendMessageService.GetById(request);
            var updateRequest = new UpdateSendMessageRequest
            {
                Id = response.Id,
                ReceiverName = response.ReceiverName,
                ReceiverMail = response.ReceiverMail,
                SenderName = response.SenderName,
                SenderMail  = response.SenderMail,
                Title = response.Title,
                Content = response.Content
            };
            return View("UpdateSendMessage", updateRequest);
        }
        [HttpPost]
        public ActionResult UpdateSendMessage(UpdateSendMessageRequest request)
        {
            UpdateSendMessageResponse result = _sendMessageService.Update(request);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSendMessage(DeleteSendMessageRequest request)
        {
            DeleteSendMessageResponse result = _sendMessageService.Delete(request);
            return RedirectToAction("Index");
        }
    }
}

