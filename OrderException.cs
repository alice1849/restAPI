using System;
namespace Books.api
{
	public class OrderException : ArgumentException
    {
		public OrderException(string message)
			: base (message)
		{
		}
	}
}

