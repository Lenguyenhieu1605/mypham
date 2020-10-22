using System;
using System.Collections.Generic;
using System.Text;

namespace WebMyPham.Application.Dtos
{
    public class PagingRequestBase
    {
        public int PageIndex { get; set; }      //lay trang so bao nhieu
        public int PageSize { get; set; }       //kich co cua trang
    }
}
