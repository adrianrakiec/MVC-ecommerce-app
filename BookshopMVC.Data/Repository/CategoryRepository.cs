﻿using BookshopMVC.Data.Repository.IRepository;
using BookshopMVC.Models.Models;

namespace BookshopMVC.Data.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(Category obj)
        {
            _context.Categories.Update(obj);
        }
    }
}
