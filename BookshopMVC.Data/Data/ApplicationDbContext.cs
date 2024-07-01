using Microsoft.EntityFrameworkCore;

namespace BookshopMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        { 
        
        }
    }
}
