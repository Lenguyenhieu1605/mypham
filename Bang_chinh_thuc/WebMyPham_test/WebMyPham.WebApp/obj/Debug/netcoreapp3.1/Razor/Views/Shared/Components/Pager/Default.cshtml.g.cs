#pragma checksum "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Shared\Components\Pager\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af11fc763629baa717e87dbd597e9a4567c0a9eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Pager_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Pager/Default.cshtml")]
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
#line 1 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\_ViewImports.cshtml"
using WebMyPham.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\_ViewImports.cshtml"
using WebMyPham.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af11fc763629baa717e87dbd597e9a4567c0a9eb", @"/Views/Shared/Components/Pager/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e015ead6ee395342c241ca3717bf78f082099abc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Pager_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebMyPham.ViewModels.Common.PagedResultBase>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Shared\Components\Pager\Default.cshtml"
  
    //pageIndex=?&keyword=?
    var urlTemplate = Url.Action() + "?page={0}";
    var request = ViewContext.HttpContext.Request;
    foreach (var key in request.Query.Keys)
    {
        if (key == "page")
        {
            continue;
        }
        if (request.Query[key].Count > 1)
        {
            foreach (var item in (string[])request.Query[key])
            {
                urlTemplate += "&" + key + "=" + item;
            }
        }
        else
        {
            urlTemplate += "&" + key + "=" + request.Query[key];
        }
    }

    var startIndex = Math.Max(Model.PageIndex - 4, 1);
    var finishIndex = Math.Min(Model.PageIndex + 4, Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 29 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Shared\Components\Pager\Default.cshtml"
 if (Model.PageCount > 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul class=\"pagination\">\r\n");
#nullable restore
#line 32 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Shared\Components\Pager\Default.cshtml"
         if (Model.PageIndex != startIndex)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n                <a class=\"page-link\" title=\"1\"");
            BeginWriteAttribute("href", " href=\"", 968, "\"", 1007, 1);
#nullable restore
#line 35 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 975, urlTemplate.Replace("{0}", "1"), 975, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Đầu</a>\r\n            </li>\r\n            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1109, "\"", 1175, 1);
#nullable restore
#line 38 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1116, urlTemplate.Replace("{0}", (Model.PageIndex-1).ToString()), 1116, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Trước</a>\r\n            </li>\r\n");
#nullable restore
#line 40 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Shared\Components\Pager\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Shared\Components\Pager\Default.cshtml"
         for (var i = startIndex; i <= finishIndex; i++)
        {
            if (i == Model.PageIndex)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item active\">\r\n                    <a class=\"page-link\" href=\"#\">");
#nullable restore
#line 46 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Shared\Components\Pager\Default.cshtml"
                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"sr-only\">(current)</span></a>\r\n                </li>\r\n");
#nullable restore
#line 48 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Shared\Components\Pager\Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("title", " title=\"", 1614, "\"", 1641, 2);
            WriteAttributeValue("", 1622, "Trang", 1622, 5, true);
#nullable restore
#line 51 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue(" ", 1627, i.ToString(), 1628, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1642, "\"", 1690, 1);
#nullable restore
#line 51 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1649, urlTemplate.Replace("{0}", i.ToString()), 1649, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 51 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Shared\Components\Pager\Default.cshtml"
                                                                                                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 52 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Shared\Components\Pager\Default.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Shared\Components\Pager\Default.cshtml"
         if (Model.PageIndex != finishIndex)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("title", " title=\"", 1860, "\"", 1895, 1);
#nullable restore
#line 57 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1868, Model.PageCount.ToString(), 1868, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1896, "\"", 1962, 1);
#nullable restore
#line 57 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1903, urlTemplate.Replace("{0}", (Model.PageIndex+1).ToString()), 1903, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sau</a>\r\n            </li>\r\n            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2064, "\"", 2126, 1);
#nullable restore
#line 60 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 2071, urlTemplate.Replace("{0}", Model.PageCount.ToString()), 2071, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Cuối</a>\r\n            </li>\r\n");
#nullable restore
#line 62 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Shared\Components\Pager\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 64 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Shared\Components\Pager\Default.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebMyPham.ViewModels.Common.PagedResultBase> Html { get; private set; }
    }
}
#pragma warning restore 1591
