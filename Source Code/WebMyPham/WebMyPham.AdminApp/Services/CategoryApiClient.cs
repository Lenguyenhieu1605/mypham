using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebMyPham.ViewModels.Catalog.Categories;
using WebMyPham.ViewModels.Common;

namespace WebMyPham.AdminApp.Services
{
    public class CategoryApiClient : BaseApiClient, ICategoryApiClient
    {
        public CategoryApiClient(IHttpClientFactory httpClientFactory,
            IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {

        }

        public async Task<List<CategoryViewModel>> GetAll()
        {
            return await GetListAsync<CategoryViewModel>("/api/categories");
        }
    }
}
