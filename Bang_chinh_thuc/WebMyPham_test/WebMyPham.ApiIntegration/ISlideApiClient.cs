using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebMyPham.ViewModels.Utilities.Slides;

namespace WebMyPham.ApiIntegration
{
    public interface ISlideApiClient
    {
        Task<List<SlideViewModel>> GetAll();
    }
}
