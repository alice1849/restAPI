using System;
using Books.api.Interfaces;

namespace Books.api.Services
{
	public class OrderDataProvider : IOrderDataProvider
	{
        public List<Order> Orders = new List<Order>();

        private ICatalogDataProvider _catalogDataProvider;

        public OrderDataProvider(ICatalogDataProvider catalog)
		{
            _catalogDataProvider = catalog;
		}

		public Order CreateOrder(string adress, List<int> booksId)
        {
            if(booksId.Exists(c => c > _catalogDataProvider.GetCatalogLength()-1)) 
            {
                throw new OrderException("There is no book with this id in catalog");
            }
            else
            {
                var catalog = _catalogDataProvider.GetCatalog();
                foreach(int id in booksId)
                {
                    if (catalog[id].Status == BookStatus.NotAvailable)
                    {
                        throw new OrderException("This book is unavailable");
                    }
                }

               var order =  new Order(adress, booksId);
               order.Number = this.Orders.Count + 1;
               Orders.Add(order);
               return order;
            }
        }

        public Order UpdateOrderAdress(string newAdress, int orderNumber)
        {
            if (Orders.Exists(o => o.Number == orderNumber))
            {
                var orderToChange = Orders.Find(n => n.Number == orderNumber);
                orderToChange.Adress = newAdress;
                orderToChange.Status = OrderStatus.Updated;
                return orderToChange;
            }
            else
            {
                throw new OrderException("There is no order with this id");
            }
        }

        public void DeleteOrder(int orderNumber)
        {
            if (Orders.Exists(o => o.Number == orderNumber))
            {
                var orderToDelete = Orders.Find(n => n.Number == orderNumber);
                Orders.Remove(orderToDelete);
            }
            else
            {
                throw new OrderException("There is no order with this id");
            }
        }

        public Order GetOrderByNumber(int orderNumber)
        {
            if (Orders.Exists(o => o.Number == orderNumber))
            {
                return Orders.Find(n => n.Number == orderNumber);
            }
            else
            {
                throw new OrderException("There is no order with this id");
            }
        }
    }
}
