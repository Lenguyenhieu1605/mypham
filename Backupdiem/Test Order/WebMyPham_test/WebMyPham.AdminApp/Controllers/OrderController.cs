using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMyPham.ApiIntegration;
using WebMyPham.ViewModels.Catalog.Orders;

namespace WebMyPham.AdminApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderApiClient _orderApiClient;
        private readonly IConfiguration _configuration;

        public OrderController(IOrderApiClient orderApiClient,
            IConfiguration configuration)
        {
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

            var data = await _orderApiClient.GetOrdersPagings(request);
            ViewBag.Keyword = keyword;

            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            return View(data);
        }


    }
}
