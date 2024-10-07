using Business.Requests.Contact;
using Business.Responses.Contact;
using HotelProject.Business.Abstracts;
using HotelProject.Business.Requests.Contact;
using HotelProject.Business.Responses.Contact;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index(GetContactListRequest request)
        {
            GetContactListResponse result = _contactService.GetList(request);
            var model = result.Items;
            return View(model);
        }
        [HttpPost]
        public ActionResult AddContact(AddContactRequest request)
        {
            AddContactResponse result = _contactService.Add(request);

            return RedirectToAction("Index", "Contact");
        }
        [HttpGet]
        public IActionResult AddContact()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetById(GetContactByIdRequest request)
        {
            GetContactByIdResponse response = _contactService.GetById(request);
            var updateRequest = new UpdateContactRequest
            {
                Id = response.Id,
                Name = response.Name,
                Mail = response.Mail,
                Subject = response.Subject,
                Message = response.Message,
                MessageCategoryID = response.MessageCategoryID,
              

            };
            return View("UpdateContact", updateRequest);
        }
        [HttpPost]
        public ActionResult UpdateContact(UpdateContactRequest request)
        {
            UpdateContactResponse result = _contactService.Update(request);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteContact(DeleteContactRequest request)
        {
            DeleteContactResponse result = _contactService.Delete(request);
            return RedirectToAction("Index");
        }
    }
}
