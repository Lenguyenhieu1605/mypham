using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebMyPham.Data.EF
{
   [NotMapped]
        public class OrderDetailsViewModel
        {
            public int OrderId { get; set; }
            public int ProductId { get; set; }

            public string Name { get; set; }
            public int Quantity { get; set; }

            public decimal Price { get; set; }
        }
  
}
