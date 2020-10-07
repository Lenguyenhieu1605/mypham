using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebMyPham.Application.Catalog.Products.Dtos;
using WebMyPham.Application.Dtos;
using WebMyPham.Data.EF;
using WebMyPham.Data.Entities;

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
        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Price = request.Price,

            };
            _context.Products.Add(product); //giảm thời gian chờ
            return await _context.SaveChangesAsync();  //
        }

        public async Task<int> Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<PagedViewModel<ProductViewModel>> GetAllPaging(string keyword, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(ProductEditRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
