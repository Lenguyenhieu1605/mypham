using System;
using System.Collections.Generic;
using System.Text;

namespace WebMyPham.ViewModels.Common
{ 
    public class PagedResult<T>
{
    public List<T> Items { set; get; } //generic // có thể dùng cho tất cả đối tượng khác nhau
    public int TotalRecord { set; get; }
}
}
