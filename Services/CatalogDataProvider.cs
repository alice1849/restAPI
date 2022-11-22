using System;
using Books.api.Interfaces;

namespace Books.api.Services
{
	public class CatalogDataProvider : ICatalogDataProvider
	{
		public CatalogDataProvider()
		{
		}

		private List<Book> _catalog = new List<Book>() {
		new Book(0, 200, "Harry Potter and the Cursed Child" ,"J. K. Rowling"),
		new Book(1, 354, "Flowers for Algernon", "Daniel Keyes"),
		new Book(2, 435, "Pride and Prejudice", "Jane Austen"),
		new Book(3, 635, "Chocolat", "Joanne Harris")
		};

		public List<Book> GetCatalog()
        {
			return _catalog;
        }

		public int GetCatalogLength ()
        {
			return _catalog.Count();
        }

		public void DeleteBookFromCatalog(int bookId)
        {
			_catalog.Find(b => b.Id == bookId).Status = BookStatus.NotAvailable;
        }
	}
}

