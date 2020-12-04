using System;
using System.Collections.Generic;
using System.Text;
using WebMyPham.ViewModels.Common;

namespace WebMyPham.ViewModels.Catalog.Products
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

        public int? CategoryId { get; set; }
    }
}
