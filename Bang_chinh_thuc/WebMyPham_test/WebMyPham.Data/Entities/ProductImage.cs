using System;
using System.Collections.Generic;
using System.Text;

namespace WebMyPham.Data.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ImagePath { get; set; }      //đường dẫn ảnh
        public string Caption { get; set; }         //alt
        public bool IsDefaut { get; set; }
        public DateTime DateCreated { get; set; }
        public int SortOrder { get; set; }          //thứ tự ảnh
        public long FileSize { get; set; }
        public Product Product { get; set; }
    }
}
