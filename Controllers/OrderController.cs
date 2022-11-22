using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.api.Interfaces;
using Books.api.Models.RequestModels;
using Books.api.Models.ResponseModels;
using Books.api.RequestModels;
using Books.api.ResponseModels;
using Books.api.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Books.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderDataProvider _orderDataProvider;

        private readonly ILogger<CatalogController> _logger;

        public OrderController(ILogger<CatalogController> logger, IOrderDataProvider order)
        {
            _logger = logger;
            _orderDataProvider = order;
        }

        [HttpPost]
        public IActionResult CreateOrder([FromBody] CreateOrderRequestModel request)
        {
            var response = _orderDataProvider.CreateOrder(request.Adress, request.BooksId);
            return new ObjectResult(new CreateOrderResponseModel(response))
            {
                StatusCode = StatusCodes.Status201Created
            };
        }

        [HttpPatch]
        public IActionResult UpdateOrderAdress([FromBody] UpdateOrderAdressRequestModel request)
        {
            var response = _orderDataProvider.UpdateOrderAdress(request.Adress, request.OrderNumber);
            return new ObjectResult(new UpdateOrderAdressResponseModel(response))
            {
                StatusCode = StatusCodes.Status200OK
            };
        }

        [HttpDelete ("{orderNumber}")]
        public IActionResult DeleteOrder(int orderNumber)
        {
            _orderDataProvider.DeleteOrder(orderNumber);
            return Ok();
        }

        [HttpGet ("{orderNumber}")]
        public IActionResult GetOrder (int orderNumber)
        {
            var result = _orderDataProvider.GetOrderByNumber(orderNumber);
            return new ObjectResult(result)
            {
                StatusCode = StatusCodes.Status200OK
            };
        }
    }
}