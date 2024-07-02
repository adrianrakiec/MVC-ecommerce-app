using BookshopMVC.Data;
using BookshopMVC.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookshopMVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Category> categories = _context.Categories.ToList();

            return View(categories);
        }
    }
}
