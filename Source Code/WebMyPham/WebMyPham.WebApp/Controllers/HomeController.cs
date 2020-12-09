using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebMyPham.ApiIntegration;
using WebMyPham.Utilities.Constants;
using WebMyPham.WebApp.Models;
using Microsoft.AspNetCore.Localization;

namespace WebMyPham.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly ISharedCultureLocalizer _loc;
        private readonly ISlideApiClient _slideApiClient;
        private readonly IProductApiClient _productApiClient;
        public HomeController(ILogger<HomeController> logger, ISlideApiClient slideApiClient,
            IProductApiClient productApiClient)
        {
            _logger = logger;
            _slideApiClient = slideApiClient;
            _productApiClient = productApiClient;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new HomeViewModel
            {
                Slides = await _slideApiClient.GetAll(),
                FeaturedProducts = await _productApiClient.GetFearturedProducts(SystemConstants.ProductSettings.NumberOfFeaturedProducts)
            };
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
