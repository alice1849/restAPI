using System;
namespace Books.api.ResponseModels
{
	public class CreateOrderResponseModel
	{
        public Order Order { get; set; }

        public CreateOrderResponseModel(Order order)
		{
			Order = order;
		}
	}
}

