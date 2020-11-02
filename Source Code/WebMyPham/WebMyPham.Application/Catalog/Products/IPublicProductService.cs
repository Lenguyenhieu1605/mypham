using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebMyPham.ViewModels.Catalog.Products;
using WebMyPham.ViewModels.Common;

namespace WebMyPham.Application.Catalog.Products
{
    //chứa phương thức bên ngoài cho người dùng đọc
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request);
        Task<List<ProductViewModel>> GetAll();
    }
}
