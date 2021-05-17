using System;
using System.ComponentModel.DataAnnotations;

namespace Acme.BookStore.Books
{
    public class CreateUpdateBookDto
    {
        public Guid AuthorId { get; set; }

        public string Name { get; set; }

        public BookType Type { get; set; } = BookType.Undefined;

        public DateTime PublishDate { get; set; } = DateTime.Now;

        public float Price { get; set; }
    }
}
