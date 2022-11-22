using System;
namespace Books.api.Models.RequestModels
{
	public class UpdateOrderAdressRequestModel
	{
        public string Adress { get; set; }

        public int OrderNumber { get; set; }

        public UpdateOrderAdressRequestModel(string adress, int orderNumber)
		{
			Adress = adress;
			OrderNumber = orderNumber;
		}
	}
}

