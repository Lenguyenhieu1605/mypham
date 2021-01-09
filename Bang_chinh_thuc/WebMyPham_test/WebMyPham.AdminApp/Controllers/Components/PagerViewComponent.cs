using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMyPham.ViewModels.Common;

namespace WebMyPham.AdminApp.Controllers.Components
{
    public class PagerViewComponent : ViewComponent
    {
        //phương thức trả về component result, tham số đầu vào là dữ liệu
        public Task<IViewComponentResult> InvokeAsync(PagedResultBase result)
        {
            return Task.FromResult((IViewComponentResult)View("Default", result));
        }
    }
}
