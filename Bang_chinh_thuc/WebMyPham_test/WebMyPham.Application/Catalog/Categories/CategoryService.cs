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
                        join ct in _context.CategoryTranslations on c.Id equals ct.CategoryId
                        select new { c, ct };
            return await query.Select(x => new CategoryViewModel()
            {
                Id = x.c.Id,
                Name = x.ct.Name,
                ParentId = x.c.ParentId
            }).ToListAsync();
        }

        public async Task<CategoryViewModel> GetById(int id)
        {
            //throw new NotImplementedException();
            var query = from c in _context.Categories
                        join ct in _context.CategoryTranslations on c.Id equals ct.CategoryId
                        where c.Id == id
                        select new { c, ct };
            return await query.Select(x => new CategoryViewModel()
            {
                Id = x.c.Id,
                Name = x.ct.Name,
                ParentId = x.c.ParentId
            }).FirstOrDefaultAsync();
        }

        
    }
}
