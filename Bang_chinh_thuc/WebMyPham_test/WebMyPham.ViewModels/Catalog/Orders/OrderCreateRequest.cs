using System;
using System.Collections.Generic;
using System.Text;
using WebMyPham.Data.Entities;
using WebMyPham.Data.Enums;

namespace WebMyPham.ViewModels.Catalog.Orders
{
    public class OrderCreateRequest
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipName { get; set; }
        public string ShipEmail { get; set; }
        public string ShipAddress { get; set; }
        public string ShipPhoneNumber { get; set; }
        public decimal Price { get; set; }
        public OrderStatus Status { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

    }
}
