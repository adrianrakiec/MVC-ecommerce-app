using BookshopMVC.Data.Data;
using BookshopMVC.Data.Repository.IRepository;
using BookshopMVC.Models.Models;

namespace BookshopMVC.Data.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private ApplicationDbContext _context;
        public ApplicationUserRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
