using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Models
{
    public class BlogDB:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public string DbName = "Blog.db";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = Path.Combine(Application.StartupPath, DbName);
            optionsBuilder.UseSqlite($"Data source={path}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { id = 1, name = "Technology", DateCreated = DateTime.Now },
                new Category { id = 2, name = "Science", DateCreated = DateTime.Now },
                new Category { id = 3, name = "Media", DateCreated = DateTime.Now },
                new Category { id = 4, name = "Secret", DateCreated = DateTime.Now },
                new Category { id = 5, name = "Sound effect", DateCreated = DateTime.Now }
            );

            // Seed Articles
            modelBuilder.Entity<Article>().HasData(
                new Article
                {
                    Id = 1,
                    Title = "Introduction to EF Core",
                    Content = "Entity Framework Core is an ORM framework...",
                    Author = "John Doe",
                    DateCreated = DateTime.Now,
                    IdCategory = 1
                },
                new Article
                {
                    Id = 2,
                    Title = "Advancements in AI",
                    Content = "Artificial Intelligence is reshaping industries...",
                    Author = "Jane Smith",
                    DateCreated = DateTime.Now,
                    IdCategory = 2
                },
                new Article
                {
                    Id = 3,
                    Title = "Advancements in AI",
                    Content = "Artificial Intelligence is reshaping industries...",
                    Author = "Jane Smith",
                    DateCreated = DateTime.Now,
                    IdCategory = 2
                },
                new Article
                {
                    Id = 4,
                    Title = "Advancements",
                    Content = "Artificial Intelligence is reshaping industries...",
                    Author = "Jane Smith",
                    DateCreated = DateTime.Now,
                    IdCategory = 4
                }
                ,
                new Article
                {
                    Id =5,
                    Title = "Advancements",
                    Content = "Artificial Intelligence is reshaping industries...",
                    Author = "Jane Smith",
                    DateCreated = DateTime.Now,
                    IdCategory = 5
                }

            );
        }
    }
}
