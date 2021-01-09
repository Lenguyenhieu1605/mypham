using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMyPham.Data.EF;
using WebMyPham.Data.Entities;

namespace WebMyPham.AdminApp.Models.ViewModel
{
    public class OrderProductDetailsViewModel
    {
        public Order Orders { get; set; }
        public List<OrderDetailsViewModel> OrderDetailsViewModelLists {get ;set;}
        public decimal TotalPrice { get; set; }
    }
}
