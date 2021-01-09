using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebMyPham.Data.EF;
using WebMyPham.ViewModels.Utilities.Slides;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebMyPham.Application.Utilities.Slides
{
    public class SlideService : ISlideService
    {
        private readonly WebMyPhamDbContext _context;

        public SlideService(WebMyPhamDbContext context)
        {
            _context = context;
        }

        public async Task<List<SlideViewModel>> GetAll()
        {
            var slides = await _context.Slides.OrderBy(x => x.SortOrder)
               .Select(x => new SlideViewModel()
               {
                   Id = x.Id,
                   Name = x.Name,
                   Description = x.Description,
                   Url = x.Url,
                   Image = x.Image
               }).ToListAsync();

            return slides;
        }
    }
}
