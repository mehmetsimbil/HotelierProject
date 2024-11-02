using HotelProject.Business.Abstracts;
using HotelProject.Business.Requests.Service;
using HotelProject.Business.Responses.Service;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
    public class ServislerimizViewComponent : ViewComponent
    {
        private readonly IServiceService _serviceService;

        public ServislerimizViewComponent(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IViewComponentResult Invoke()
        {
            var req = new GetServiceListRequest();
            GetServiceListResponse result = _serviceService.GetList(req);
            var model = result.Items;
            return View(model);

        }
    }
}
