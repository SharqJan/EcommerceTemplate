using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(object? productModel)
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            return View();
        }
        public IActionResult Edit(int id)
        {
            return RedirectToAction("Add", new
            {
                Id = 100
            });
        }
    }
}
