using BookshopMVC.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace BookshopMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        { 
        
        }

        public DbSet<Category> Categories { get; set; }
    }
}
