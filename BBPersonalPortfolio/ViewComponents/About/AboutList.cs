using Business.Service;
using Microsoft.AspNetCore.Mvc;

namespace BBPersonalPortfolio.ViewComponents.About
{
    public class AboutList : ViewComponent
    {
        private readonly IAboutService _aboutService;
        AboutList(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _aboutService.TGetAll();
            return View(values);
        }
    }
}
