using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebMyPham.ViewModels.Catalog.Products.Manage
{
    public class ProductUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public bool? IsFeatured { get; set; }
        public IFormFile ThumbnailImage { get; set; }
    }
}
