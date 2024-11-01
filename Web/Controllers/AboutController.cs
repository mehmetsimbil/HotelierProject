using Business.Requests.About;
using Business.Responses.About;
using HotelProject.Business.Abstracts;
using HotelProject.Business.Requests.About;
using HotelProject.Business.Responses.About;

using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;


namespace Web.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IActionResult Index(GetAboutListRequest request)
        {
            ViewData["Title"] = "About";
            GetAboutListResponse result = _aboutService.GetList(request);
            var model = result.Items;
            return View(model);
        }

        [HttpGet]
        public IActionResult _Hakkimizda(GetAboutListRequest request)
        {
            GetAboutListResponse result = _aboutService.GetList(request);
            var model = result.Items;

            return PartialView("_Hakkimizda", model);
        }


        [HttpPost]
        public ActionResult AddAbout(AddAboutRequest request)
        {
            AddAboutResponse result = _aboutService.Add(request);

            return RedirectToAction("Index", "About");
        }
        [HttpGet]
        public IActionResult AddAbout()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetById(GetAboutByIdRequest request)
        {
            GetAboutByIdResponse response = _aboutService.GetById(request);
            var updateRequest = new UpdateAboutRequest
            {
                Id = response.Id,
                Title1 = response.Title1,
                Title2 = response.Title2,
                Content = response.Content,
                RoomCount = response.RoomCount,
                StaffCount = response.StaffCount,
                CustomerCount = response.CustomerCount
            };
            return View("UpdateAbout", updateRequest);
        }

        [HttpPost]
        public ActionResult UpdateAbout(UpdateAboutRequest request)
        {
            UpdateAboutResponse result = _aboutService.Update(request);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteAbout(DeleteAboutRequest request)
        {
            DeleteAboutResponse result = _aboutService.Delete(request);
            return RedirectToAction("Index");
        }


        public ActionResult ExcelToExport()
        {
            var abouts = _aboutService.GetListToExcel();
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("About");
                worksheet.Cells[1, 1].Value = "Id";
                worksheet.Cells[1, 2].Value = "Title";
                worksheet.Cells[1, 3].Value = "Content";

                for (int i = 0; i < abouts.Count; i++)
                {
                   
                    worksheet.Cells[i + 2, 1].Value = abouts[i].Id;
                    worksheet.Cells[i + 2, 2].Value = abouts[i].Title1;
                    worksheet.Cells[i + 2, 3].Value = abouts[i].Content;
                }

                var stream = new MemoryStream();
                package.SaveAs(stream);
                stream.Position = 0;

                var fileName = "Abouts.xlsx";
                return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
            }

        }
    }
}
