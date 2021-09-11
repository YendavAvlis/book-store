using System;
using book_store.Data.DTOs;
using Microsoft.EntityFrameworkCore;

namespace book_store.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Book> Books { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<BookCategory>().HasData(
                new BookCategory
                {
                    BookCategoryId = Guid.Parse("1eab193f-a3ed-cab0-43af-094bb24f24ce"),
                    Name = "Fiction"
                },

                new BookCategory
                {
                    BookCategoryId = Guid.Parse("2efa4bdf-35ad-cdab-42da-ed09edc1aecb"),
                    Name = "Thriller"
                },

                new BookCategory
                {
                    BookCategoryId = Guid.Parse("3d04ccba-9eac-b2ea-bcf3-95feaaedabc4"),
                    Name = "Sci-Fi"
                }
            );

            builder.Entity<Book>().HasData(
                new Book
                {
                    BookId = Guid.Parse("3d04ccba-9eac-b2ea-bcf3-85feaaedabc0"),
                    BookCategoryId = Guid.Parse("2efa4bdf-35ad-cdab-42da-ed09edc1aecb"),
                    Name = "The New Book",
                    Description = "dkjvbksdvlansdl",
                    ISBN = "123456"
                },

                new Book
                {
                    BookId = Guid.Parse("3d04ccba-9eac-b2ea-bcf3-95feaaedabc9"),
                    BookCategoryId = Guid.Parse("1eab193f-a3ed-cab0-43af-094bb24f24ce"),
                    Name = "The Other Book",
                    Description = "dfsdpasdad",
                    ISBN = "8429825"
                },

                new Book
                {
                    BookId = Guid.Parse("3d04ccba-9eac-b2ea-bcf3-95feaaedabc6"),
                    BookCategoryId = Guid.Parse("3d04ccba-9eac-b2ea-bcf3-95feaaedabc4"),
                    Name = "The Life Book",
                    Description = "sdaknvsdioa",
                    ISBN = "25764587"
                }
            );
        }

    }
}