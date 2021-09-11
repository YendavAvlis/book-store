using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace book_store.Data.DTOs
{
    public class Book
    {
        public Guid BookId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }
        public DateTime ReleaseDate { get; set; }

        [ForeignKey(nameof(BookCategory))]
        public Guid BookCategoryId { get; set; }
        public BookCategory BookCategory { get; set; }


    }
}