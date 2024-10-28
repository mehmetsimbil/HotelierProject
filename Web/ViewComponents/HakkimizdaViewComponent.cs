using Azure.Core;
using HotelProject.Business.Abstracts;
using HotelProject.Business.Requests.About;
using HotelProject.Business.Responses.About;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
    public class HakkimizdaViewComponent : ViewComponent
    {
        private readonly IAboutService _aboutService;

        public HakkimizdaViewComponent(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IViewComponentResult Invoke()
        {
            var req = new GetAboutListRequest();
            GetAboutListResponse result = _aboutService.GetList(req);
            var model = result.Items;
            return View(model);

        }

    }
}
