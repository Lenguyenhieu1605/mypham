#pragma checksum "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Product\Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ff946ce39a8fb314d365ebd4b5252ed9f84db74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Category), @"mvc.1.0.view", @"/Views/Product/Category.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ff946ce39a8fb314d365ebd4b5252ed9f84db74", @"/Views/Product/Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e015ead6ee395342c241ca3717bf78f082099abc", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductCategoryViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal span6"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal qtyFrm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Product\Category.cshtml"
  
    //ViewData["Title"] = Model.Category.Name + (Model.Products.PageIndex == 1 ? "" : " - " + "Page" + " " + Model.Products.PageIndex);
    ViewData["Title"] = "Danh mục sản phẩm";
    ViewData["Description"] = Model.Category.Name + (Model.Products.PageIndex == 1 ? "" : " - " + "Page" + " " + Model.Products.PageIndex);
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<ul class=\"breadcrumb\">\r\n    <li>\r\n<a href=\"index.html\">Trang chủ</a> \r\n<span class=\"divider\">/</span></li>\r\n    <li class=\"active\">Danh mục</li>\r\n</ul>\r\n<h3> ");
#nullable restore
#line 17 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Product\Category.cshtml"
Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n<hr class=\"soft\" />\r\n<hr class=\"soft\" />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ff946ce39a8fb314d365ebd4b5252ed9f84db745368", async() => {
                WriteLiteral("\r\n    <div class=\"control-group\">\r\n        <label class=\"control-label alignL\"><localize>Sắp xếp theo</localize> </label>\r\n        <select>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ff946ce39a8fb314d365ebd4b5252ed9f84db745787", async() => {
                    WriteLiteral("Theo A - Z");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ff946ce39a8fb314d365ebd4b5252ed9f84db746817", async() => {
                    WriteLiteral("Theo Z - A");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ff946ce39a8fb314d365ebd4b5252ed9f84db747847", async() => {
                    WriteLiteral("Giá thấp nhất");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </select>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div id=""myTab"" class=""pull-right"">
    <a href=""#listView"" data-toggle=""tab""><span class=""btn btn-large""><i class=""icon-list""></i></span></a>
    <a href=""#blockView"" data-toggle=""tab""><span class=""btn btn-large btn-primary""><i class=""icon-th-large""></i></span></a>
</div>
<br class=""clr"" />
<div class=""tab-content"">
    <div class=""tab-pane"" id=""listView"">
");
#nullable restore
#line 38 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Product\Category.cshtml"
         for (int i = 0; i < Model.Products.Items.Count; i++)
        {
            var item = Model.Products.Items[i];

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"span2\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1645, "\"", 1706, 2);
#nullable restore
#line 43 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Product\Category.cshtml"
WriteAttributeValue("", 1651, Configuration["BaseAddress"] + @item.ThumbnailImage, 1651, 54, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1705, "", 1706, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1707, "\"", 1723, 1);
#nullable restore
#line 43 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Product\Category.cshtml"
WriteAttributeValue("", 1713, item.Name, 1713, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"span4\">\r\n                    <h3>\r\n<localize>Mới | Có sẵn</localize></h3>\r\n                    <hr class=\"soft\" />\r\n                    <h5>");
#nullable restore
#line 49 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Product\Category.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                    
                    <a class=""btn btn-small pull-right"" href=""product_details.html""><localize>Xem chi tiết</localize></a>
                    <br class=""clr"" />
                </div>
                <div class=""span3 alignR"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ff946ce39a8fb314d365ebd4b5252ed9f84db7412475", async() => {
                WriteLiteral("\r\n                        <h3> ");
#nullable restore
#line 56 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Product\Category.cshtml"
                        Write(item.Price.ToString("N0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" &#8363;</h3>\r\n                        <a");
                BeginWriteAttribute("onclick", " onclick=\"", 2346, "\"", 2376, 3);
                WriteAttributeValue("", 2356, "addToCart1(", 2356, 11, true);
#nullable restore
#line 57 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Product\Category.cshtml"
WriteAttributeValue("", 2367, item.Id, 2367, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2375, ")", 2375, 1, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn\" data-id=\"");
#nullable restore
#line 57 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Product\Category.cshtml"
                                                                          Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"><localize>Thêm vào</localize> <i class=\"icon-shopping-cart\"></i></a>\r\n                        <a href=\"product_details.html\" class=\"btn btn-large\"><i class=\"icon-zoom-in\"></i></a>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <hr class=\"soft\" />\r\n");
#nullable restore
#line 63 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Product\Category.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <div class=\"tab-pane  active\" id=\"blockView\">\r\n        <ul class=\"thumbnails\">\r\n");
#nullable restore
#line 68 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Product\Category.cshtml"
             for (int i = 0; i < Model.Products.Items.Count; i++)
            {
                var item = Model.Products.Items[i];

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"span3\">\r\n                <div class=\"thumbnail\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 3035, "\"", 3060, 2);
            WriteAttributeValue("", 3042, "/san-pham/", 3042, 10, true);
#nullable restore
#line 73 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Product\Category.cshtml"
WriteAttributeValue("", 3052, item.Id, 3052, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 3066, "\"", 3126, 1);
#nullable restore
#line 73 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Product\Category.cshtml"
WriteAttributeValue("", 3072, Configuration["BaseAddress"] + @item.ThumbnailImage, 3072, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3127, "\"", 3143, 1);
#nullable restore
#line 73 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Product\Category.cshtml"
WriteAttributeValue("", 3133, item.Name, 3133, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                    <div class=\"caption\">\r\n                        <h5>");
#nullable restore
#line 75 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Product\Category.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <h4 style=\"text-align:center\">\r\n                            <p>\r\n                                <a class=\"btn btn-primary\" href=\"#\">");
#nullable restore
#line 78 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Product\Category.cshtml"
                                                               Write(item.Price.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" &#8363;</a>\r\n                            </p>\r\n                            <a class=\"btn\"");
            BeginWriteAttribute("href", " href=\"", 3514, "\"", 3539, 2);
            WriteAttributeValue("", 3521, "/san-pham/", 3521, 10, true);
#nullable restore
#line 80 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Product\Category.cshtml"
WriteAttributeValue("", 3531, item.Id, 3531, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <i class=\"icon-zoom-in\"></i>\r\n                            </a>\r\n                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3669, "\"", 3699, 3);
            WriteAttributeValue("", 3679, "addToCart1(", 3679, 11, true);
#nullable restore
#line 83 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Product\Category.cshtml"
WriteAttributeValue("", 3690, item.Id, 3690, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3698, ")", 3698, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn\" data-id=\"");
#nullable restore
#line 83 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Product\Category.cshtml"
                                                                              Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><localize>Thêm vào</localize> <i class=\"icon-shopping-cart\"></i></a>\r\n\r\n                        </h4>\r\n                    </div>\r\n                </div>\r\n            </li>\r\n");
#nullable restore
#line 89 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Product\Category.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n        <hr class=\"soft\" />\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 94 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Product\Category.cshtml"
Write(await Component.InvokeAsync("Pager", Model.Products));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>\r\n    function addToCart1(id) {\r\n        debugger\r\n\r\n        var url = \'");
#nullable restore
#line 99 "D:\nam4\TLCN-Xay-dung-website-ban-my-pham-pham\Bang_chinh_thuc\WebMyPham_test\WebMyPham.WebApp\Views\Product\Category.cshtml"
              Write(Url.Action("AddToCart", "Cart"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
    $.ajax({
        type: ""POST"",
        url: url,
        data: {
            id: id
        },
        success: function (res) {
            $('#lbl_number_items_header').text(res.length);
        },
        error: function (err) {
            console.log(err);
        }
    });
}
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductCategoryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
