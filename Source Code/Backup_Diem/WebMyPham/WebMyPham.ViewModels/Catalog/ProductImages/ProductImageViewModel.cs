using System;
using System.Collections.Generic;
using System.Text;

namespace WebMyPham.ViewModels.Catalog.ProductImages
{
    public class ProductImageViewModel
    {
        //public int Id { get; set; }

        //public string FilePath { get; set; }

        //public bool IsDefault { get; set; }

        //public long FileSize { get; set; }
        //public IFormFile  ImageFile { get; set; }
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ImagePath { get; set; }      //đường dẫn ảnh
        public string Caption { get; set; }         //alt
        public bool IsDefaut { get; set; }
        public DateTime DateCreated { get; set; }
        public int SortOrder { get; set; }          //thứ tự ảnh
        public long FileSize { get; set; }
    }
}
