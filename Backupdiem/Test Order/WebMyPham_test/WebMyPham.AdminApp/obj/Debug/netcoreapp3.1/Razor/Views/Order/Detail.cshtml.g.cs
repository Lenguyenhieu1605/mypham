#pragma checksum "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db1d60ebe5d905574a0e6d2eb6264b895cf04281"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Detail), @"mvc.1.0.view", @"/Views/Order/Detail.cshtml")]
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
#line 1 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.AdminApp\Views\_ViewImports.cshtml"
using WebMyPham.AdminApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.AdminApp\Views\_ViewImports.cshtml"
using WebMyPham.AdminApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db1d60ebe5d905574a0e6d2eb6264b895cf04281", @"/Views/Order/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4097d376872ac7d114919947daffa5438fd0ea91", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebMyPham.AdminApp.Models.ViewModel.OrderProductDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Detail.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Details</h1>

<div>
    <h4>Product</h4>
    <hr />
    <div class=""row justify-content-center"">
        <div class=""col-5"">
            <dl class=""row"">
                <dt class=""col-sm-3"">
                    Mã số đơn hàng:
                </dt>
                <dd class=""col-sm-9"">
                    ");
#nullable restore
#line 19 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Detail.cshtml"
               Write(Html.DisplayFor(model => model.Orders.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-3\">\r\n                    Tên khách hàng:\r\n                </dt>\r\n                <dd class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 25 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Detail.cshtml"
               Write(Html.DisplayFor(model => model.Orders.ShipName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-3\">\r\n                    Địa chỉ giao hàng:\r\n                </dt>\r\n                <dd class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 31 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Detail.cshtml"
               Write(Html.DisplayFor(model => model.Orders.ShipAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-3\">\r\n                    Số điện thoại:\r\n                </dt>\r\n                <dd class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 37 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Detail.cshtml"
               Write(Html.DisplayFor(model => model.Orders.ShipPhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-3\">\r\n                    Địa chỉ emtail:\r\n                </dt>\r\n                <dd class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 43 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Detail.cshtml"
               Write(Html.DisplayFor(model => model.Orders.ShipEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-3\">\r\n                    Tổng số tiền:\r\n                </dt>\r\n                <dd class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 49 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Detail.cshtml"
               Write(Html.DisplayFor(model => model.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-3\">\r\n                    Trạng thái:\r\n                </dt>\r\n                <dd class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 55 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Detail.cshtml"
               Write(Html.DisplayFor(model => (Enum)model.Orders.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </dd>
            </dl>
        </div>
        <div class=""table-responsive"">
            <table class=""table table-bordered"">

                <thead>
                    <tr class=""table-info text-bold"">
                        <th>
                            Mã sản phẩm
                        </th>
                        <th>
                            Tên sản phẩm
                        </th>
                        <th>
                            Số lượng:
                        </th>
                        <th>
                           Giá tiền
                        </th>


                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 81 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Detail.cshtml"
                     foreach (var item in Model.OrderDetailsViewModelLists)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 85 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Detail.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 88 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Detail.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 91 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Detail.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 94 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Detail.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n\r\n                          \r\n                        </tr>\r\n");
#nullable restore
#line 99 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.AdminApp\Views\Order\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <div class=\"col-5\">\r\n\r\n            <div>\r\n                <div class=\"float-right\">\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db1d60ebe5d905574a0e6d2eb6264b895cf0428111888", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebMyPham.AdminApp.Models.ViewModel.OrderProductDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
