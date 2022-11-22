using System;
namespace Books.api.Interfaces
{
	public interface IOrderDataProvider
	{
        public Order CreateOrder(string adress, List<int> booksId);

        public Order UpdateOrderAdress(string newAdress, int orderNumber);

        public void DeleteOrder(int orderNumber);

        public Order GetOrderByNumber(int orderNumber);

    }
}

