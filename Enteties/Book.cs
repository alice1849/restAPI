using System;
namespace Books.api
{
	public class Book
	{
        public Book(int id, int pages, string name, string author)
        {
            Id = id;
            PagesAmount = pages;
            Name = name;
            Author = author;
            Status = BookStatus.Available;

        }
        public int Id { get; set; }

        public int PagesAmount { get; set; }

        public string? Name { get; set; }

        public string? Author { get; set; }

        public BookStatus Status { get; set; }
    }
}

