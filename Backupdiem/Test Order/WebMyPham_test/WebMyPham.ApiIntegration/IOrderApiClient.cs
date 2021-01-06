using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebMyPham.ViewModels.Catalog.Orders;
using WebMyPham.ViewModels.Common;

namespace WebMyPham.ApiIntegration
{
    public interface IOrderApiClient
    {
        Task<ApiResult<PagedResult<OrderViewModel>>> GetOrdersPagings(GetOrderPagingRequest request);

        Task<ApiResult<bool>> CheckoutOrder(OrderCreateRequest request); //nhập vào 1 userregisterrequest
        Task<ApiResult<OrderViewModel>> GetById(Guid id);

    }
}
