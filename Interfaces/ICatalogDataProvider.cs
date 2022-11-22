using System;
namespace Books.api.Interfaces
{
	public interface ICatalogDataProvider
	{
        public List<Book> GetCatalog();

        public int GetCatalogLength();

        public void DeleteBookFromCatalog(int bookId);

    }
}

