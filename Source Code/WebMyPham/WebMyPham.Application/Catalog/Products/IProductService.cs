using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebMyPham.ViewModels.Catalog.ProductImages;
using WebMyPham.ViewModels.Catalog.Products;
using WebMyPham.ViewModels.Catalog.Products.Manage;
using WebMyPham.ViewModels.Common;

namespace WebMyPham.Application.Catalog.Products
{
    public interface IProductService
    {
        //truyền vào dto
        //sd task để dùng asyn , dể tận dụng dc xử lý nhiều request 1 lúc, thay vì trả về ta trả về task
        Task<int> Create(ProductCreateRequest request); //tạo sp truyền vào product, k cần truyền prod view model// trả về mã sp
        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete(int productId);//truyền prod id
        Task<ProductViewModel> GetById(int productId);
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task<bool> UpdateStock(int productId, int addedQuantity);
        Task AddViewCount(int productId);
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);

        Task<int> AddImage(int productId, ProductImageCreateRequest request);

        Task<int> RemoveImage(int imageId);

        //Task<int> UpdateImage(int imageId, string caption, bool isDefault);
        Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request);
        Task<List<ProductImageViewModel>> GetListImage(int productId);
        Task<ProductImageViewModel> GetImageById(int imageId);
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request);
        Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request);
        Task<List<ProductViewModel>> GetFeaturedProducts(int take);

    }
}
