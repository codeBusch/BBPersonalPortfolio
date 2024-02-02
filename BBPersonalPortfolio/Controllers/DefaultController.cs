using Microsoft.AspNetCore.Mvc;

namespace BBPersonalPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
