using System.Collections.Generic;
using System.Threading.Tasks;
using WebMyPham.Data.EF;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebMyPham.ViewModels.Catalog.Products;
using WebMyPham.ViewModels.Common;


namespace WebMyPham.Application.Catalog.Products
{
    public class PublicProductService : IPublicProductService
    {
        private readonly WebMyPhamDbContext _context; //chỉ gán 1 lần
        public PublicProductService(WebMyPhamDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProductViewModel>> GetAll()
        {
            var query = from p in _context.Products
                        join pd in _context.ProductDetails on p.Id equals pd.ProductId
                        join pic in _context.ProductInCategories on p.Id equals pic.ProductId
                        join c in _context.Categories on pic.ProductId equals c.Id
                        select new { p, pd, pic };
            var data = await query.Select(x => new ProductViewModel()     //x là kết quả tìm kiếm được
                {
                    Id = x.p.Id,
                    Name = x.pd.Name,
                    DateCreated = x.p.DateCreated,
                    Description = x.pd.Description,
                    Details = x.pd.Details,
                    OriginalPrice = x.p.OriginalPrice,
                    Price = x.p.Price,
                    Stock = x.p.Stock,
                    ViewCount = x.p.ViewCount
                }).ToListAsync();
            return data;
            //throw new System.NotImplementedException();
        }

        public async Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request)
        {
            //Buoc 1: Select join
            var query = from p in _context.Products
                        join pd in _context.ProductDetails on p.Id equals pd.ProductId
                        join pic in _context.ProductInCategories on p.Id equals pic.ProductId
                        join c in _context.Categories on pic.ProductId equals c.Id
                        select new { p, pd, pic };

            //Buoc 2: Filter
            if (request.CategoryId.HasValue && request.CategoryId.Value > 0) //HasValue = true và Value hớn hơn 0
            {
                query = query.Where(p => p.pic.CategoryId == request.CategoryId);
            }

            //Buoc 3: Paging
            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new ProductViewModel()     //x là kết quả tìm kiếm được
                {
                    Id = x.p.Id,
                    Name = x.pd.Name,
                    DateCreated = x.p.DateCreated,
                    Description = x.pd.Description,
                    Details = x.pd.Details,
                    OriginalPrice = x.p.OriginalPrice,
                    Price = x.p.Price,
                    Stock = x.p.Stock,
                    ViewCount = x.p.ViewCount
                }).ToListAsync();

            //Buoc 4: Select and projection
            var pagedResult = new PagedResult<ProductViewModel>()
            {
                TotalRecord = totalRow,

                Items = data
            };
            return pagedResult;
        }
    }
}
