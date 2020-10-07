using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebMyPham.Application.Catalog.Products.Dtos;
using WebMyPham.Application.Dtos;

namespace WebMyPham.Application.Catalog.Products
{
    public interface IManageProductService
    {
        //truyền vào dto
        //sd task để dùng asyn , dể tận dụng dc xử lý nhiều request 1 lúc, thay vì trả về ta trả về task
        Task<int> Create(ProductCreateRequest request); //tạo sp truyền vào product, k cần truyền prod view model// trả về mã sp
        Task<int> Update(ProductEditRequest request);
        Task<int> Delete(int productId);//truyền prod id
        Task<List<ProductViewModel>> GetAll(); //trả về task
        Task<PagedViewModel<ProductViewModel>> GetAllPaging(string keyword, int pageIndex, int pageSize);
    }
}
