using BookshopMVC.Models.Models;

namespace BookshopMVC.Data.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category obj);
    }
}
