using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMyPham.ViewModels.Catalog.Categories;
using WebMyPham.ViewModels.Common;

namespace WebMyPham.ApiIntegration
{
    public interface ICategoryApiClient
    {
        Task<List<CategoryViewModel>> GetAll();
    }
}
