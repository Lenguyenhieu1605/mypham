using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMyPham.ViewModels.Catalog.Products;
using WebMyPham.ViewModels.Common;

namespace WebMyPham.ApiIntegration
{
    public interface IProductApiClient
    {
        Task<PagedResult<ProductViewModel>> GetPagings(GetManageProductPagingRequest request);

        Task<bool> CreateProduct(ProductCreateRequest request);

        Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request);

        Task<ProductViewModel> GetById(int id);

        Task<List<ProductViewModel>> GetFearturedProducts(int take);
    }
}
