using Microsoft.AspNetCore.Mvc;
using web_app.Models;
using WebApp.Data;

namespace web_app.Controllers
{
    public class CategoryController : Controller
    {   
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db) 
        { 
            _db = db;
        } 
        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }

        public IActionResult Create() 
        { 
            return View(); 
        }
    }
}
