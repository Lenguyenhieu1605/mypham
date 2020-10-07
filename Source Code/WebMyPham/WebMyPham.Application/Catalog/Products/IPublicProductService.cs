using System;
using System.Collections.Generic;
using System.Text;
using WebMyPham.Application.Catalog.Products.Dtos;
using WebMyPham.Application.Dtos;

namespace WebMyPham.Application.Catalog.Products
{
    //chứa phương thức bên ngoài cho người dùng đọc
    public interface IPublicProductService
    {
        PagedViewModel<ProductViewModel> GetAllByCategoryId(int categoryId, int pageIndex, int pageSize);
    }
}
