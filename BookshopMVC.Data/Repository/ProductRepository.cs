﻿using BookshopMVC.Data.Repository.IRepository;
using BookshopMVC.Models.Models;

namespace BookshopMVC.Data.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(Product obj)
        {
            _context.Products.Update(obj);
        }
    }
}
