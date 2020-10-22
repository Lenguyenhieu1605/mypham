using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMyPham.Application.Catalog.Products.Dtos;
using WebMyPham.Application.Catalog.Products.Dtos.Manage;
using WebMyPham.Application.Dtos;
using WebMyPham.Data.EF;
using WebMyPham.Data.Entities;
using WebMyPham.Utilities.Exceptions;

namespace WebMyPham.Application.Catalog.Products
{
    //module catalog gồm product và interface
    public class ManageProductService : IManageProductService   //kế thừa từ Imanage
    {
        private readonly WebMyPhamDbContext _context; //chỉ gán 1 lần
        public ManageProductService(WebMyPhamDbContext context)
        {
            _context = context;
        }

        public async Task AddViewCount(int productId)
        {
            var product = await _context.Products.FindAsync(productId);

            product.ViewCount += 1;

            await _context.SaveChangesAsync();
        }

        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Price = request.Price,
                OriginalPrice = request.OriginalPrice,
                Stock = request.Stock,
                ViewCount = 0,
                DateCreated = DateTime.Now,
                ProductDetails = new List<ProductDetail>()
                {
                    new ProductDetail()
                    {
                        Name=request.Name,
                        Description=request.Description,
                        Details=request.Details
                    }
                }
            };

            _context.Products.Add(product); //giảm thời gian chờ

            return await _context.SaveChangesAsync();  //
        }

        public async Task<int> Delete(int productId)
        {
            var product = await _context.Products.FindAsync(productId);

            if (product == null)
                throw new WebMyPhamException($"Cannot find a product: {productId}");

            _context.Products.Remove(product);

            return await _context.SaveChangesAsync();
        }

        public async Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request)
        {
            //Buoc 1: Select join
            var query = from p in _context.Products
                        join pd in _context.ProductDetails on p.Id equals pd.ProductId          
                        join pic in _context.ProductInCategories on p.Id equals pic.ProductId   
                        join c in _context.Categories on pic.ProductId equals c.Id
                        select new { p, pd, pic };

            //Buoc 2: Filter
            if (!string.IsNullOrEmpty(request.Keyword))
                query = query.Where(x => x.pd.Name.Contains(request.Keyword));

            if(request.CategoryIds.Count>0)
            {
                query = query.Where(p => request.CategoryIds.Contains(p.pic.CategoryId));
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

        public async Task<int> Update(ProductUpdateRequest request)
        {
            var product = await _context.Products.FindAsync(request.Id);

            var productDetails = await _context.ProductDetails.FirstOrDefaultAsync(x => x.ProductId == request.Id);

            if (product==null || productDetails ==null)
                throw new WebMyPhamException($"Cannot find a product with Id: {request.Id}");

            productDetails.Name = request.Name;

            productDetails.Description = request.Description;

            productDetails.Details = request.Details;

            return await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdatePrice(int productId, decimal newPrice)
        {
            var product = await _context.Products.FindAsync(productId);

            if (product == null)
                throw new WebMyPhamException($"Cannot find a product with Id: {productId}");

            product.Price = newPrice;

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateStock(int productId, int addedQuantity)
        {
            var product = await _context.Products.FindAsync(productId);

            if (product == null)
                throw new WebMyPhamException($"Cannot find a product with Id: {productId}");

            product.Stock += addedQuantity;

            return await _context.SaveChangesAsync() > 0;
        }

    }
}
