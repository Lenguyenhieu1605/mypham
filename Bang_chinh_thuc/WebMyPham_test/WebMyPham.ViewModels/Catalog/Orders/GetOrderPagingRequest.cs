using System;
using System.Collections.Generic;
using System.Text;
using WebMyPham.ViewModels.Common;

namespace WebMyPham.ViewModels.Catalog.Orders
{
    public class GetOrderPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
