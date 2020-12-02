using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WebMyPham.Data.EF;
using WebMyPham.Data.Entities;
using WebMyPham.Utilities.Exceptions;
using WebMyPham.ViewModels.Catalog.ProductImages;
using WebMyPham.ViewModels.Catalog.Products;
using WebMyPham.ViewModels.Common;
using WebMyPham.Application.Common;

namespace WebMyPham.Application.Catalog.Products
{
    //module catalog gồm product và interface
    public class ProductService : IProductService   //kế thừa từ Imanage
    {
        private readonly WebMyPhamDbContext _context; //chỉ gán 1 lần
        private readonly IStorageService _storageService;

        public ProductService(WebMyPhamDbContext context, IStorageService storageService)
        {
            _context = context;
            _storageService = storageService;
        }

        public async Task<int> AddImage(int productId, ProductImageCreateRequest request)
        {
            var productImage = new ProductImage()
            {
                Caption = request.Caption,
                DateCreated = DateTime.Now,
                IsDefaut = request.IsDefaut,
                ProductId = productId,
                SortOrder = request.SortOrder
            };
            if (request.ImageFile != null)
            {
                productImage.ImagePath = await this.SaveFile(request.ImageFile);
                productImage.FileSize = request.ImageFile.Length;
            }
            _context.ProductImages.Add(productImage);
            await _context.SaveChangesAsync();
            return productImage.Id;
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
            //save image// save ảnh 
            if (request.ThumbnailImage != null) //kiểm tra khác null thì vào phương thức save file
            {
                product.ProductImages = new List<ProductImage>()
                {
                    new ProductImage()
                    {
                        Caption = "Thumbnail image",
                        DateCreated = DateTime.Now,
                        FileSize = request.ThumbnailImage.Length,
                        ImagePath = await this.SaveFile(request.ThumbnailImage),
                        IsDefaut = true,
                        SortOrder = 1
                    }
                };
            }
            _context.Products.Add(product); //giảm thời gian chờ

            await _context.SaveChangesAsync();  //
            return product.Id;
        }

        public async Task<int> Delete(int productId)
        {
            var product = await _context.Products.FindAsync(productId);

            if (product == null)
                throw new WebMyPhamException($"Cannot find a product: {productId}"); //lấy ds ảnh
            var images = _context.ProductImages.Where(i => i.ProductId == productId);
            foreach (var image in images)
            {
                await _storageService.DeleteFileAsync(image.ImagePath); //nếu còn thì xóa tên ảnh đi
            }
            _context.Products.Remove(product);

            return await _context.SaveChangesAsync();
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
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request)
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

            if (request.CategoryId != null && request.CategoryId != 0)
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
                TotalRecords = totalRow,
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ProductViewModel> GetById(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            var productdetail = await _context.ProductDetails.FindAsync(productId);
            //var productTranslation = await _context.ProductTranslations.FirstOrDefaultAsync(X500DistinguishedName => X500DistinguishedName.ProductId == productId);
            var productViewModel = new ProductViewModel()
            {
                Id = product.Id,
                DateCreated = product.DateCreated,
                //Description = productTranslation !=null ?? productTranslation.Description,
                OriginalPrice = product.OriginalPrice,
                Price = product.Price,
                Stock = product.Stock,
                Name = productdetail.Name,
                ViewCount = product.ViewCount,
                Description = productdetail.Description,
                Details = productdetail.Details


            };
            return productViewModel;
        }

        public async Task<ProductImageViewModel> GetImageById(int imageId)
        {
            var image = await _context.ProductImages.FindAsync(imageId);
            if (image == null)
                throw new WebMyPhamException($"Cannot find an image with id {imageId}");

            var viewModel = new ProductImageViewModel()
            {
                Caption = image.Caption,
                DateCreated = image.DateCreated,
                FileSize = image.FileSize,
                Id = image.Id,
                ImagePath = image.ImagePath,
                IsDefaut = image.IsDefaut,
                ProductId = image.ProductId,
                SortOrder = image.SortOrder
            };
            return viewModel;
        }

        public async Task<List<ProductImageViewModel>> GetListImage(int productId)
        {
            return await _context.ProductImages.Where(x => x.ProductId == productId)
               .Select(i => new ProductImageViewModel()
               {
                   Caption = i.Caption,
                   DateCreated = i.DateCreated,
                   FileSize = i.FileSize,
                   Id = i.Id,
                   ImagePath = i.ImagePath,
                   IsDefaut = i.IsDefaut,
                   ProductId = i.ProductId,
                   SortOrder = i.SortOrder
               }).ToListAsync();
        }

        public async Task<int> RemoveImage(int imageId)
        {
            var productImage = await _context.ProductImages.FindAsync(imageId);
            if (productImage == null) //nếu null
                throw new WebMyPhamException($"Cannot find an image with id {imageId}");
            _context.ProductImages.Remove(productImage); //nếu k null sẽ contexxt
            return await _context.SaveChangesAsync(); //return tổng số bảng ghi
        }

        public async Task<int> Update(ProductUpdateRequest request)
        {
            var product = await _context.Products.FindAsync(request.Id);

            var productDetails = await _context.ProductDetails.FirstOrDefaultAsync(x => x.ProductId == request.Id);

            if (product == null || productDetails == null)
                throw new WebMyPhamException($"Cannot find a product with Id: {request.Id}");

            productDetails.Name = request.Name;

            productDetails.Description = request.Description;

            productDetails.Details = request.Details;
            //save image// save ảnh
            if (request.ThumbnailImage != null)
            {
                var thumbnailImage = await _context.ProductImages.FirstOrDefaultAsync(i => i.IsDefaut == true && i.ProductId == request.Id);
                if (thumbnailImage != null)
                {
                    thumbnailImage.FileSize = request.ThumbnailImage.Length;
                    thumbnailImage.ImagePath = await this.SaveFile(request.ThumbnailImage);
                    _context.ProductImages.Update(thumbnailImage);
                }
            }

            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request)
        {
            var productImage = await _context.ProductImages.FindAsync(imageId); //đọc
            if (productImage == null) //nếu trường hợp productimage =nul  => return ra giá trị
                throw new WebMyPhamException($"Cannot find an image with id {imageId}"); //throw ra exception với imageid truyền vào

            if (request.ImageFile != null) //image khác null 
            {
                productImage.ImagePath = await this.SaveFile(request.ImageFile);
                productImage.FileSize = request.ImageFile.Length;
            }
            _context.ProductImages.Update(productImage);
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
        private async Task<string> SaveFile(IFormFile file)
        {
            //lấy ra dc file name, gọi phương thức storget
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return fileName;
        }
        
    }
}
