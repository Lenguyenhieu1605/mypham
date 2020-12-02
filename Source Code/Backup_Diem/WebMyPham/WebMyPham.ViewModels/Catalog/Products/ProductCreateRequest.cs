using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebMyPham.ViewModels.Catalog.Products
{
    public class ProductCreateRequest
    {
        [Display(Name = "Tên sản phẩm")]
        [Required(ErrorMessage = "Bạn phải nhập tên sản phẩm")]
        public string Name { get; set; }
        [Display(Name = "Mô tả")]
        public string Description { get; set; }
        [Display(Name = "Chi tiết")]
        public string Details { get; set; }
        [Display(Name = "Giá bán")]
        [Required(ErrorMessage = "Bạn phải nhập giá bán sản phẩm")]
        public decimal Price { get; set; }
        [Display(Name = "Giá nhập")]
        [Required(ErrorMessage = "Bạn phải nhập giá nhập sản phẩm")]
        public decimal OriginalPrice { get; set; }
        [Display(Name = "Số lượng tồn kho")]
        [Required(ErrorMessage = "Bạn phải nhập số lượng sản phẩm")]
        public int Stock { get; set; }
        public IFormFile ThumbnailImage { get; set; } //install
    }
}
