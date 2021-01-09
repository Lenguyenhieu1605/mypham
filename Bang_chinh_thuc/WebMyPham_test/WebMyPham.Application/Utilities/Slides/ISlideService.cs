using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebMyPham.ViewModels.Utilities.Slides;

namespace WebMyPham.Application.Utilities.Slides
{
    public interface ISlideService
    {
        Task<List<SlideViewModel>> GetAll();
    }
}
