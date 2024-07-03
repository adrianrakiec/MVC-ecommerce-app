﻿using BookshopMVC.Models.Models;

namespace BookshopMVC.Data.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product obj);
    }
}
