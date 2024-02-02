using Business.Service;
using Microsoft.AspNetCore.Mvc;

namespace BBPersonalPortfolio.ViewComponents.Portfolio
{
    public class PortfolioList : ViewComponent
    {
        private readonly IPortfolioService _portfolioService;
        PortfolioList(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _portfolioService.TGetAll();
            return View(values);
        }
    }
}
