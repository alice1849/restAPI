using System;
namespace Books.api.RequestModels
{
	public class CreateOrderRequestModel
	{
        public string Adress { get; set; }

        public List<int> BooksId { get; set; }

        public CreateOrderRequestModel(string adress, List<int> booksId)
		{
			Adress = adress;
			BooksId = booksId;
		}
	}
}

