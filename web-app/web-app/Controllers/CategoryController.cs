using Microsoft.AspNetCore.Mvc;

namespace web_app.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
