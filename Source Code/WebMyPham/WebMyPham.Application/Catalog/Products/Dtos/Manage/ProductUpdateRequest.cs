using System;
using System.Collections.Generic;
using System.Text;

namespace WebMyPham.Application.Catalog.Products.Dtos.Manage
{
    public class ProductUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
    }
}
