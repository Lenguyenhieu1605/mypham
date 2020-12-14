using System;
using System.Collections.Generic;
using System.Text;

namespace WebMyPham.Data.Entities
{
    public class ProductDetail
    {
        public int Id { set; get; }
        public int ProductId { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Details { set; get; }
        public Product Product { get; set; }
    }
}
