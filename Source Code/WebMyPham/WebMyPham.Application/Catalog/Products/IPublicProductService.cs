using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebMyPham.Application.Catalog.Products.Dtos;
using WebMyPham.Application.Catalog.Products.Dtos.Public;
using WebMyPham.Application.Dtos;

namespace WebMyPham.Application.Catalog.Products
{
    //chứa phương thức bên ngoài cho người dùng đọc
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProcductPagingRequest request);
    }
}
