using System;
using System.Collections.Generic;
using System.Text;
using WebMyPham.Data.Entities;
using WebMyPham.Data.Enums;

namespace WebMyPham.ViewModels.Catalog.Orders
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; }
        public Order Orders { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int Status { get; set; }
        public string ShipName { get; set; }
        public string ShipEmail { get; set; }
        public string ShipAddress { get; set; }
        public string ShipPhoneNumber { get; set; }
    }
}
