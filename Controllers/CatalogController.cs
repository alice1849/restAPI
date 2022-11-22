using System;
using Books.api.Interfaces;
using Books.api.ResponseModels;
using Books.api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Books.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        private readonly ICatalogDataProvider _catallogDataProvider;

        private readonly ILogger<CatalogController> _logger;

        public CatalogController(ILogger<CatalogController> logger, ICatalogDataProvider catalog)
        {
            _logger = logger;
            _catallogDataProvider = catalog;
        }

        [HttpGet(Name = "Get")]
        public IActionResult GetCatalog()
        {
            var catalogLength = _catallogDataProvider.GetCatalog().Count();
            var response = _catallogDataProvider.GetCatalog();
            return Ok(new GetCatalogResponseModel(true, response));
        }

        [HttpDelete("{bookId}")]
        public IActionResult DeleteBookFromCatalog(int bookId)
        {
            _catallogDataProvider.DeleteBookFromCatalog(bookId);
            return new ObjectResult(_catallogDataProvider.GetCatalog()[bookId])
            {
                StatusCode = StatusCodes.Status200OK
            };
        }
    }
}
