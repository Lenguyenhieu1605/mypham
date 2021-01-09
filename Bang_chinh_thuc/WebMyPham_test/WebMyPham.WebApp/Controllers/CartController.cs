using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebMyPham.ApiIntegration;
using WebMyPham.Data.EF;
using WebMyPham.Data.Entities;
using WebMyPham.Utilities.Constants;
using WebMyPham.ViewModels.Catalog.Orders;
using Microsoft.AspNetCore.Identity;
using WebMyPham.ViewModels.Sales;
using WebMyPham.WebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace WebMyPham.WebApp.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductApiClient _productClientApi;
        private readonly WebMyPhamDbContext _dbContext;
      //  private readonly SignInManager<AppUser> _signInManager;
        public CartController(WebMyPhamDbContext context, IProductApiClient productApiClient)
        {
            _dbContext = context;
            _productClientApi = productApiClient;
           

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View(GetCheckoutViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Checkout(CheckoutViewModel request)
        {
            //Guid userIdentity;
            //if( !User.Identity.IsAuthenticated)
            //{
            //    userIdentity 
            //}    
            var model = GetCheckoutViewModel();
            var orderDetailsViewModel = new List<OrderDetailViewModel>();
            foreach (var item in model.CartItems)
            {
                orderDetailsViewModel.Add(new OrderDetailViewModel()
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity
                });
            }
            var checkoutRequest = new CheckoutRequest()
            {
                Address = request.CheckoutModel.Address,
                Name = request.CheckoutModel.Name,
                Email = request.CheckoutModel.Email,
                PhoneNumber = request.CheckoutModel.PhoneNumber,
                OrderDetails = orderDetailsViewModel
            };

            //This is a place to parse OrderDetails from CartItems.
            var orderDetails = new List<OrderDetail>();
            foreach (var item in model.CartItems)
            {
                orderDetails.Add(new OrderDetail()
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    Price = item.Price,
                });
            }
            //Create a new orders
            var order = new Order()
            {
                ShipAddress = request.CheckoutModel.Address,
                ShipName = request.CheckoutModel.Name,
                ShipEmail = request.CheckoutModel.Email,
                ShipPhoneNumber = request.CheckoutModel.PhoneNumber,
                OrderDetails = orderDetails,
            };
            System.Guid guid = System.Guid.Parse("74203a55-4660-4e97-19c1-08d8b4468792");


            order.UserID = guid;
            var createOrder = await _dbContext.Orders.AddAsync(order);
            if(createOrder.State == EntityState.Added)
            {
                await _dbContext.SaveChangesAsync();
                HttpContext.Session.Clear();
                TempData["SuccessMsg"] = "Mua hàng thành công!";
                return View(model);

            }

            //TODO: Add to API
            // return URI of the created resource.
            // HttpClient client = new HttpClient();
            // var department = newDepartment() { DepartmentName = "Test Department" };
            // HttpContent content;



            //    HttpResponseMessage response = await client.PostAsync("/api/Orders", content.CopyToAsync();


            //response.EnsureSuccessStatusCode();
             TempData["SuccessMsg"] = "Thất bại!";
            return View(model);

        }

        [HttpGet]
        public IActionResult GetListItems()
        {
            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            List<CartItemViewModel> currentCart = new List<CartItemViewModel>();
            if (session != null)
            {
                currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);
            }
            
            return Ok(currentCart);
        }

        public async Task<IActionResult> AddToCart(int id)
        {
            var product = await _productClientApi.GetById(id);
            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            List<CartItemViewModel> currentCart = new List<CartItemViewModel>();
            if(session != null)
            {
                currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);
            }
            int quantity = 1; 
            if(currentCart.Any(x => x.ProductId == id))
            {
                quantity = currentCart.First(x => x.ProductId == id).Quantity + 1;
            }
            var cartItem = new CartItemViewModel()
            {
                ProductId = id,
                Description = product.Description,
                Image = product.ThumbnailImage,
                Name = product.Name,
                Price = product.Price,
                Quantity = quantity
            };
            currentCart.Add(cartItem);
            HttpContext.Session.SetString(SystemConstants.CartSession, JsonConvert.SerializeObject(currentCart));

            return Ok(currentCart);
        }

        public IActionResult UpdateCart(int id, int quantity)
        {
            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            List<CartItemViewModel> currentCart = new List<CartItemViewModel>();
            if (session != null)
            {
                currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);
            }
            foreach(var item in currentCart)
            {
                if (item.ProductId == id)
                {
                    if (quantity == 0)
                    {
                        currentCart.Remove(item);
                        break;
                    }
                    item.Quantity = quantity;
                }
            }

            HttpContext.Session.SetString(SystemConstants.CartSession, JsonConvert.SerializeObject(currentCart));
            return Ok(currentCart);
        }

        private CheckoutViewModel GetCheckoutViewModel()
        {
            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            List<CartItemViewModel> currentCart = new List<CartItemViewModel>();
            if (session != null)
            {
                currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);
            }
            var checkoutVm = new CheckoutViewModel()
            {
                CartItems = currentCart,
                CheckoutModel = new CheckoutRequest()
            };
            return checkoutVm;
        }
    }
}
