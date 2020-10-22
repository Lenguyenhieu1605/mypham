using System.Threading.Tasks;
using WebMyPham.Application.Catalog.Products.Dtos;
using WebMyPham.Application.Catalog.Products.Dtos.Manage;
using WebMyPham.Application.Dtos;

namespace WebMyPham.Application.Catalog.Products
{
    public interface IManageProductService
    {
        //truyền vào dto
        //sd task để dùng asyn , dể tận dụng dc xử lý nhiều request 1 lúc, thay vì trả về ta trả về task
        Task<int> Create(ProductCreateRequest request); //tạo sp truyền vào product, k cần truyền prod view model// trả về mã sp
        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete(int productId);//truyền prod id
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task<bool> UpdateStock(int productId, int addedQuantity);
        Task AddViewCount(int productId);
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);
    }
}
