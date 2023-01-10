using Microsoft.AspNetCore.Mvc;

namespace bookshop.Areas.Manage.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
