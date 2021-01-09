using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMyPham.ViewModels.Catalog.Products;
using WebMyPham.ViewModels.Catalog.Products.Manage;
using WebMyPham.ViewModels.Common;

namespace WebMyPham.ApiIntegration
{
    public interface IProductApiClient
    {
        Task<PagedResult<ProductViewModel>> GetPagings(GetManageProductPagingRequest request);

        Task<bool> CreateProduct(ProductCreateRequest request);
        Task<bool> UpdateProduct(ProductUpdateRequest request);

        Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request);

        Task<ProductViewModel> GetById(int id);

        Task<List<ProductViewModel>> GetFearturedProducts(int take);
        Task<List<ProductViewModel>> GetLatestProducts(int take);
        //Task<List<ProductViewModel>> GetLatestProducts(string culture, int take);
        Task<bool> DeleteProduct(int id);

    }
}
