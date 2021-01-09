using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebMyPham.ViewModels.Catalog.Orders;
using WebMyPham.ViewModels.Common;

namespace WebMyPham.Application.Catalog.Orders
{
    public interface IOrderService
    {
        Task<int> Create(OrderCreateRequest request); //tạo sp truyền vào product, k cần truyền prod view model// trả về mã sp
        Task<OrderViewModel> GetById(int orderId);
        Task<PagedResult<OrderViewModel>> GetOrdersPaging(GetOrderPagingRequest request);

    }
}
