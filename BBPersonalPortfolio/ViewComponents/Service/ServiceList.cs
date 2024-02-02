using Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace BBPersonalPortfolio.ViewComponents.Service
{
    public class ServiceList : ViewComponent
    {
        private readonly IServiceService _serviceService;
        ServiceList(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _serviceService.TGetAll();
            return View(values);
        }
        
    }
}
