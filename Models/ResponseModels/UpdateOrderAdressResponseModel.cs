using System;
namespace Books.api.Models.ResponseModels
{
	public class UpdateOrderAdressResponseModel
	{
        public bool IsUpdated { get; set; }

        public Order UpdatedOrder { get; set; }

        public UpdateOrderAdressResponseModel(Order updatedOrder)
		{
			UpdatedOrder = updatedOrder;
			IsUpdated = true;
		}
	}
}

