using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebMyPham.ViewModels.Catalog.Products;
using WebMyPham.ViewModels.Common;

namespace WebMyPham.AdminApp.Services
{
    public class ProductApiClient : BaseApiClient, IProductApiClient
    {
        
        public ProductApiClient(IHttpClientFactory httpClientFactory,
            IHttpContextAccessor httpContextAccessor,
            IConfiguration configuration) 
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            
        }
        public async Task<PagedResult<ProductViewModel>> GetPagings(GetManageProductPagingRequest request)
        {
            var data = await base.GetAsync<PagedResult<ProductViewModel>>(
                $"/api/products/paging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" + 
                $"&keyword={request.Keyword}");
            
            return data;
        }
    }
}
