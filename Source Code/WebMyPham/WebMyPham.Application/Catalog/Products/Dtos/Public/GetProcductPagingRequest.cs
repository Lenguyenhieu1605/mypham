using System;
using System.Collections.Generic;
using System.Text;
using WebMyPham.Application.Dtos;

namespace WebMyPham.Application.Catalog.Products.Dtos.Public
{
    public class GetProcductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
