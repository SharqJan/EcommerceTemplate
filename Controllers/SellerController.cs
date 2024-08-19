using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    public class SellerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
