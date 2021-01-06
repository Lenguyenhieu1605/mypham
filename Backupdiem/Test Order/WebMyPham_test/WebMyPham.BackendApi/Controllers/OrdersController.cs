using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMyPham.Application.Catalog.Orders;
using WebMyPham.ViewModels.Catalog.Orders;

namespace WebMyPham.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService manageOrderService)
        {

            _orderService = manageOrderService;
        }


        [HttpGet("paging")]
        public async Task<IActionResult> GetAllPaging([FromQuery] GetOrderPagingRequest request) //chỉ định dc map từ đâu
        {
            var products = await _orderService.GetOrdersPaging(request);
            return Ok(products);
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        [Authorize]
        public async Task<IActionResult> Create([FromForm] OrderCreateRequest request)
        {

            if (!ModelState.IsValid) //ktra =false
            {
                return BadRequest(ModelState); //trả về modelstate, ktra vali ok k
            }
            var orderId = await _orderService.Create(request);
            if (orderId == 0)
                return BadRequest();

            var product = await _orderService.GetById(orderId);

            return CreatedAtAction(nameof(GetById), new { id = orderId }, product);
        }
        [HttpGet("{orderId}")] //routing
        public async Task<IActionResult> GetById(int orderId)
        {
            var order = await _orderService.GetById(orderId);
            if (order == null)
                return BadRequest("Cannot find order");
            return Ok(order);
        }
    }
}
