#pragma checksum "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b77e4d338817ad88a3df18345ed603c52460e9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\_ViewImports.cshtml"
using WebMyPham.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\_ViewImports.cshtml"
using WebMyPham.WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Home\Index.cshtml"
using WebMyPham.ViewModels.Catalog.Products;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b77e4d338817ad88a3df18345ed603c52460e9e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e015ead6ee395342c241ca3717bf78f082099abc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Trang chủ";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("slider", async() => {
                WriteLiteral("\r\n    <div id=\"carouselBlk\">\r\n        <div id=\"myCarousel\" class=\"carousel slide\">\r\n            <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 12 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Home\Index.cshtml"
                 for (int index = 0; index < Model.Slides.Count; index++)
                {
                    var slide = Model.Slides[index];

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div");
                BeginWriteAttribute("class", " class=\"", 504, "\"", 544, 2);
                WriteAttributeValue("", 512, "item", 512, 4, true);
#nullable restore
#line 15 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 516, index == 0? "active" :"", 517, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"container\">\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 627, "\"", 644, 1);
#nullable restore
#line 17 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 634, slide.Url, 634, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><img style=\"width:100%\"");
                BeginWriteAttribute("src", " src=\"", 669, "\"", 687, 1);
#nullable restore
#line 17 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 675, slide.Image, 675, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 688, "\"", 705, 1);
#nullable restore
#line 17 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 694, slide.Name, 694, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></a>\r\n                            <div class=\"carousel-caption\">\r\n                                <h4>");
#nullable restore
#line 19 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Home\Index.cshtml"
                               Write(slide.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                                <p>");
#nullable restore
#line 20 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Home\Index.cshtml"
                              Write(slide.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 24 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Home\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n            <a class=\"left carousel-control\" href=\"#myCarousel\" data-slide=\"prev\">&lsaquo;</a>\r\n            <a class=\"right carousel-control\" href=\"#myCarousel\" data-slide=\"next\">&rsaquo;</a>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
            WriteLiteral("<h4 localize-content>Sản phẩm mới </h4>\r\n<ul class=\"thumbnails\">\r\n");
#nullable restore
#line 86 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Home\Index.cshtml"
     foreach (var item in Model.LatestProducts)
    {
        var url = $"/{"san-pham"}/{item.Id}";

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"span3\">\r\n            <div class=\"thumbnail\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 4087, "\"", 4098, 1);
#nullable restore
#line 91 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 4094, url, 4094, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 4104, "\"", 4163, 1);
#nullable restore
#line 91 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 4110, Configuration["BaseAddress"] + item.ThumbnailImage, 4110, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4164, "\"", 4180, 1);
#nullable restore
#line 91 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 4170, item.Name, 4170, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                <div class=\"caption\">\r\n                    <h5>");
#nullable restore
#line 93 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Home\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h4 style=\"text-align:center\">\r\n                        <p>\r\n                            <a class=\"btn btn-primary\" href=\"#\">");
#nullable restore
#line 96 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Home\Index.cshtml"
                                                           Write(item.Price.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" &#8363;</a>\r\n                        </p>\r\n                        <a class=\"btn\"");
            BeginWriteAttribute("href", " href=\"", 4523, "\"", 4534, 1);
#nullable restore
#line 98 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 4530, url, 4530, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i class=\"icon-zoom-in\"></i>\r\n                        </a>\r\n                        <a href=\"/cart\" class=\"btn btn-add-cart\" data-id=\"");
#nullable restore
#line 101 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Home\Index.cshtml"
                                                                     Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><localize>Thêm vào</localize> <i class=\"icon-shopping-cart\"></i></a>\r\n                    \r\n                    </h4>\r\n                </div>\r\n            </div>\r\n        </li>\r\n");
#nullable restore
#line 107 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.Extensions.Configuration.IConfiguration Configuration { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
