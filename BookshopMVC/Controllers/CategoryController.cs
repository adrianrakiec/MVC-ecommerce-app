using BookshopMVC.Data;
using BookshopMVC.Data.Repository.IRepository;
using BookshopMVC.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookshopMVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository context)
        {
            _categoryRepository = context;
        }

        public IActionResult Index()
        {
            List<Category> categories = _categoryRepository.GetAll().ToList();

            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category newCategory)
        {
            if (ModelState.IsValid)
            {
                _categoryRepository.Add(newCategory);
                _categoryRepository.Save();
                TempData["success"] = "Category created successfully";

                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Category? category = _categoryRepository.Get(u => u.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category newCategory)
        {
            if (ModelState.IsValid)
            {
                _categoryRepository.Update(newCategory);
                _categoryRepository.Save();
                TempData["success"] = "Category updated successfully";

                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Category? category = _categoryRepository.Get(u => u.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Category? category = _categoryRepository.Get(u => u.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            _categoryRepository.Remove(category);
            _categoryRepository.Save();
            TempData["success"] = "Category deleted successfully";

            return RedirectToAction("Index");
        }
    }
}
