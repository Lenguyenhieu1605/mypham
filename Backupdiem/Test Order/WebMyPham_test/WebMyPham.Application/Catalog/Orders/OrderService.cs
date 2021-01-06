using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using WebMyPham.Data.EF;
using WebMyPham.Data.Entities;
using WebMyPham.ViewModels.Catalog.Orders;
using WebMyPham.ViewModels.Common;

namespace WebMyPham.Application.Catalog.Orders
{

    public class OrderService : IOrderService
    {
        private readonly WebMyPhamDbContext _context; //chỉ gán 1 lần

        public OrderService(WebMyPhamDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(OrderCreateRequest request)
        {
            var order = new Order()
            {
                ShipName = request.ShipName,
                ShipAddress = request.ShipAddress,
                ShipEmail = request.ShipEmail,
                ShipPhoneNumber = request.ShipPhoneNumber,
                OrderDate = DateTime.Now,
                OrderDetails = new List<OrderDetail>()
                {
                    new OrderDetail()
                    {
                        Price = request.Price
                    }
                }
            };
            _context.Orders.Add(order); //giảm thời gian chờ

            await _context.SaveChangesAsync();  //
            return order.Id;
        }


        public async Task<OrderViewModel> GetById(int orderId)
        {
            var order = await _context.Orders.FindAsync(orderId);
            var orderdetail = await _context.OrderDetails.FirstOrDefaultAsync(x => x.OrderId == orderId);

            var orderViewModel = new OrderViewModel()
            {
                Id = order.Id,
                OrderDate = order.OrderDate,
                Status = (int)order.Status,
                Price = orderdetail.Price,
                Quantity = orderdetail.Quantity,
                ShipName = order.ShipName,
                ShipAddress = order.ShipAddress,
                ShipEmail = order.ShipEmail,
                ShipPhoneNumber = order.ShipPhoneNumber
            };
            return orderViewModel;
        }

        public async Task<PagedResult<OrderViewModel>> GetOrdersPaging(GetOrderPagingRequest request)
        {
            var query = from o in _context.Orders
                        join od in _context.OrderDetails on o.Id equals od.OrderId
                        select new { o, od };

            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new OrderViewModel()     //x là kết quả tìm kiếm được
                {
                    Id = x.o.Id,
                    OrderDate = x.o.OrderDate,
                    Status = (int)x.o.Status,
                    Price = x.od.Price,
                    Quantity = x.od.Quantity,
                    ShipName = x.o.ShipName,
                    ShipAddress = x.o.ShipAddress,
                    ShipPhoneNumber = x.o.ShipPhoneNumber,
                    ShipEmail = x.o.ShipEmail
                }).ToListAsync();

            //Buoc 4: Select and projection
            var pagedResult = new PagedResult<OrderViewModel>()
            {
                TotalRecords = totalRow,
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                Items = data
            };
            return pagedResult;
        }

    }
}
