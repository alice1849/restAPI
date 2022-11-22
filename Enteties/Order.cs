using System;
namespace Books.api
{
	public class Order
	{

        public Order(string adress, List<int> booksId)
        {
            //Number = number;
            Adress = adress;
            BooksId = booksId;
            Status = OrderStatus.Created;
        }

        public int Number { get; set; }

        public string Adress { get; set; }

        public List<int> BooksId { get; set; }

        public OrderStatus Status { get; set; }
    }
}
	

