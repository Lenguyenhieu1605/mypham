using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMyPham.ApiIntegration;
using WebMyPham.Data.EF;
using WebMyPham.Data.Enums;
using WebMyPham.ViewModels.Catalog.Orders;
using WebMyPham.AdminApp.Models.ViewModel;
using Microsoft.AspNetCore.Authorization;

namespace WebMyPham.AdminApp.Controllers
{
    [Authorize(Roles ="admin, shipper")]
    public class OrderController : Controller
    {
        private readonly IOrderApiClient _orderApiClient;
        private readonly IConfiguration _configuration;
        private readonly WebMyPhamDbContext _dbContext;

        public OrderController(WebMyPhamDbContext dbContext, IOrderApiClient orderApiClient,
            IConfiguration configuration)
        {
            _dbContext = dbContext;
            _orderApiClient = orderApiClient;
            _configuration = configuration;
        }

        public async Task<IActionResult> Index(string name, string keyword, int pageIndex = 1, int pageSize = 8)
        {
            var request = new GetOrderPagingRequest()
            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize
            };

        //    var data = await _orderApiClient.GetOrdersPagings(request);
            var order = _dbContext.Orders;
            var orderViewModelList = new List<OrderViewModel>();
            foreach (var item in order.ToList())
            {
                orderViewModelList.Add(new OrderViewModel()
                {
                    Id = item.Id,
                    ShipName = item.ShipName,
                    ShipAddress = item.ShipAddress,

                    ShipPhoneNumber = item.ShipPhoneNumber,
                    Status = (int) item.Status,

                });
            }

            ViewBag.Keyword = keyword;

            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            return View(orderViewModelList);
        }
        [HttpPost]
        public async Task<IActionResult> Edit (int? Id, int action)
        {
            if(Id == null)
            {
                return NotFound();
            }
            var order = await _dbContext.Orders.FindAsync(Id);
            if(order == null)
            {
                return NotFound();
            }
            order.Status = (OrderStatus)action ;
            var updateOrder = _dbContext.Orders.Update(order);
            if(updateOrder.State == EntityState.Modified)
            {
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }    
            return NotFound();
        }
        [HttpGet]
        public async Task<IActionResult> Detail (int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            var order = await _dbContext.Orders.Include(x => x.OrderDetails).Where(x => x.Id == (int)Id).FirstOrDefaultAsync();
            //var oderDetails = await _dbContext.OrderDetails.Join(_dbContext.ProductDetails
            //    , orderD => orderD.ProductId
            //    , product => product.ProductId
            //    , (orderD, product) => new { orderD, product }


            //    ).Where(order => order.orderD.OrderId == Id).ToListAsync();
               var orderDetails =  _dbContext.OrderDetailsViewModels.FromSqlRaw($"select OrderId, a.ProductId, Quantity, Price, b.Name from dbo.OrderDetails as a, dbo.ProductDetails as b where a.ProductId = b.ProductId  and a.OrderId = { Id}");
            var orderDetailsViewModelList = new List<OrderDetailsViewModel>();
            
            foreach (var item in orderDetails.ToList())
            {
                orderDetailsViewModelList.Add(new OrderDetailsViewModel()
                {
                   
                   OrderId =item.OrderId,
                   ProductId = item.ProductId,
                   Name = item.Name,
                   Quantity = item.Quantity,
                   Price = item.Price,


                });
            }
            var orderProductDetailsViewModel = new OrderProductDetailsViewModel()
            {
                Orders = order,
                OrderDetailsViewModelLists = orderDetailsViewModelList,
               
            };
            orderProductDetailsViewModel.TotalPrice = 0;
            foreach (var item in orderDetailsViewModelList)
            {
                orderProductDetailsViewModel.TotalPrice += item.Price;
            }    
            if (orderProductDetailsViewModel == null)
            {
                return NotFound();
            }
            return View(orderProductDetailsViewModel);
        }
        //get edit
      

    }
}
