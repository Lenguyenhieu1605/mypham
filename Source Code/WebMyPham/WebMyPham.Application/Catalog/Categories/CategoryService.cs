using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebMyPham.Data.EF;
using WebMyPham.ViewModels.Catalog.Categories;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebMyPham.Application.Catalog.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly WebMyPhamDbContext _context; //chỉ gán 1 lần
        public CategoryService(WebMyPhamDbContext context)
        {
            _context = context;
        }

        public async Task<List<CategoryViewModel>> GetAll()
        {
            var query = from c in _context.Categories
                        select new { c};
            return await query.Select(x => new CategoryViewModel()
            {
                Id = x.c.Id
                
            }).ToListAsync();
        }
    }
}
