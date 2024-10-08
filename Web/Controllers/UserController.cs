using Business.Requests.User;
using Business.Responses.User;
using HotelProject.Business.Abstracts;
using HotelProject.Business.Requests.User;
using HotelProject.Business.Responses.User;
using HotelProject.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index(GetUserListRequest request)
        {
            GetUserListResponse result = _userService.GetList(request);
            var model = result.Items;
            return View(model);
        }
        [HttpPost]
        public ActionResult AddUser(AddUserRequest request)
        {
            AddUserResponse result = _userService.Add(request);

            return RedirectToAction("Index", "User");
        }
        [HttpGet]
        public IActionResult AddUser()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetById(GetUserByIdRequest request)
        {
            GetUserByIdResponse response = _userService.GetById(request);
            var updateRequest = new UpdateUserRequest
            {
                Id = response.Id,
                Name = response.Name,
                Surname = response.Surname,
                City = response.City,
                Country = response.Country,
                Gender = response.Gender,
                WorkDepartment = response.WorkDepartment,
                WorkLocationID = response.WorkLocationID,
            };
            return View("UpdateUser", updateRequest);
        }
        [HttpPost]
        public ActionResult UpdateUser(UpdateUserRequest request)
        {
            UpdateUserResponse result = _userService.Update(request);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteUser(DeleteUserRequest request)
        {
            DeleteUserResponse result = _userService.Delete(request);
            return RedirectToAction("Index");
        }
    }
}
