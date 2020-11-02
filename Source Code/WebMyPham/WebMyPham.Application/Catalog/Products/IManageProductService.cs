using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebMyPham.ViewModels.Catalog.Products;
using WebMyPham.ViewModels.Catalog.Products.Manage;
using WebMyPham.ViewModels.Common;

namespace WebMyPham.Application.Catalog.Products
{
    public interface IManageProductService
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
        Task<int> AddImages(int productId, List<IFormFile> files);

        Task<int> RemoveImages(int imageId);

        Task<int> UpdateImage(int imageId, string caption, bool isDefault);

        Task<List<ProductImageViewModel>> GetListImage(int productId);

    }
}
