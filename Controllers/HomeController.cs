using Microsoft.AspNetCore.Mvc;

namespace bookshop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contact()
        { return View(); }
        public IActionResult Product_detail ()
        { return View(); }
        public IActionResult product_listing()
        { return View(); }
        public IActionResult shop_cart()
        { return View(); }


    }
}
