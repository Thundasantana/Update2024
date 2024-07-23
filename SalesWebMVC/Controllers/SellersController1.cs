using Microsoft.AspNetCore.Mvc;

namespace SalesWebMvc.Controllers
{
    public class SellersController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
