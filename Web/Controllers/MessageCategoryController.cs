using HotelProject.Business.Abstracts;
using HotelProject.Business.Requests.MessageCategory;
using HotelProject.Business.Responses.MessageCategory;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class MessageCategoryController : Controller
    {
        private readonly IMessageCategoryService _messageCategoryService;

        public MessageCategoryController(IMessageCategoryService messageCategoryService)
        {
            _messageCategoryService = messageCategoryService;
        }

        public IActionResult Index(GetMessageCategoryListRequest request)
        {
            GetMessageCategoryListResponse result = _messageCategoryService.GetList(request);
            var model = result.Items;
            return View(model);
        }
        [HttpPost]
        public ActionResult AddMessageCategory(AddMessageCategoryRequest request)
        {
            AddMessageCategoryResponse result = _messageCategoryService.Add(request);

            return RedirectToAction("Index", "MessageCategory");
        }
        [HttpGet]
        public IActionResult AddMessageCategory()
        {
            return View();
        }
      
        [HttpPost]
        public ActionResult UpdateMessageCategory(UpdateMessageCategoryRequest request)
        {
            UpdateMessageCategoryResponse result = _messageCategoryService.Update(request);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteMessageCategory(DeleteMessageCategoryRequest request)
        {
            DeleteMessageCategoryResponse result = _messageCategoryService.Delete(request);
            return RedirectToAction("Index");
        }
    }
}

