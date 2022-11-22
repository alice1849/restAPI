using System;
namespace Books.api.ResponseModels
{
	public class GetCatalogResponseModel
	{
        public List<Book> Catalog { get; set; }

        public bool Status { get; set; }

        public GetCatalogResponseModel(bool status, List<Book> catalog)
		{
			Status = status;
			Catalog = catalog;
		}
	}
}

