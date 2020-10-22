using System;
using System.Collections.Generic;
using System.Text;

namespace WebMyPham.Application.Dtos
{
    public class PagedResult<T>
    {
        public List<T> Items { get; set; } //generic // có thể dùng cho tất cả đối tượng khác nhau
        public int TotalRecord {set;get;}
    }
}
