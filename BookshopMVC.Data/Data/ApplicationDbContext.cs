using BookshopMVC.Models.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookshopMVC.Data.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Programming", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Business", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Health", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Strategy", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Self-Help", DisplayOrder = 5 }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Clean Code",
                    Description = "A Handbook of Agile Software Craftsmanship",
                    Author = "Robert C. Martin",
                    Price = 35.99,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    Title = "The E-Myth Revisited",
                    Description = "Why Most Small Businesses Don't Work and What to Do About It",
                    Author = "Michael E. Gerber",
                    Price = 29.99,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Title = "The UltraMind Solution",
                    Description = "Fix Your Broken Brain by Healing Your Body First",
                    Author = "Mark Hyman",
                    Price = 24.99,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 4,
                    Title = "The Art of War",
                    Description = "An Ancient Chinese Classic on Military Strategy",
                    Author = "Sun Tzu",
                    Price = 19.99,
                    CategoryId = 4,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 5,
                    Title = "Think and Grow Rich",
                    Description = "The Landmark Bestseller Now Revised and Updated for the 21st Century",
                    Author = "Napoleon Hill",
                    Price = 14.99,
                    CategoryId = 5,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 6,
                    Title = "How to Win Friends and Influence People",
                    Description = "The Only Book You Need to Lead You to Success",
                    Author = "Dale Carnegie",
                    Price = 22.99,
                    CategoryId = 5,
                    ImageUrl = ""
                }
             );
        }
    }
}
