#pragma checksum "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01195461b029f6310c58e4342129ca3f2c002c13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01195461b029f6310c58e4342129ca3f2c002c13", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e015ead6ee395342c241ca3717bf78f082099abc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline navbar-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("products.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Account/Logout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01195461b029f6310c58e4342129ca3f2c002c135252", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <title>");
#nullable restore
#line 7 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 290, "\"", 324, 1);
#nullable restore
#line 9 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 300, ViewData["Description"], 300, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 351, "\"", 361, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <!--Less styles -->
    <!-- Other Less css file //different less files has different color scheam
     <link rel=""stylesheet/less"" type=""text/css"" href=""/themes/less/simplex.less"">
     <link rel=""stylesheet/less"" type=""text/css"" href=""/themes/less/classified.less"">
     <link rel=""stylesheet/less"" type=""text/css"" href=""/themes/less/amelia.less"">  MOVE DOWN TO activate
     -->
    <!--<link rel=""stylesheet/less"" type=""text/css"" href=""/themes/less/bootshop.less"">
    <script src=""/themes/js/less.js"" type=""text/javascript""></script> -->
    <!-- Bootstrap style -->
    <link id=""callCss"" rel=""stylesheet"" href=""/themes/bootshop/bootstrap.min.css"" media=""screen"" />
    <link href=""/themes/css/base.css"" rel=""stylesheet"" media=""screen"" />
    <!-- Bootstrap style responsive -->
    <link href=""/themes/css/bootstrap-responsive.min.css"" rel=""stylesheet"" />
    <link href=""/themes/css/font-awesome.css"" rel=""stylesheet"" type=""text/css"">
    <!-- Google-code-prettify -->
    <link href=""/themes/j");
                WriteLiteral(@"s/google-code-prettify/prettify.css"" rel=""stylesheet"" />
    <!-- fav and touch icons -->
    <link rel=""shortcut icon"" href=""/themes/images/ico/favicon.ico"">
    <link rel=""apple-touch-icon-precomposed"" sizes=""144x144"" href=""/themes/images/ico/apple-touch-icon-144-precomposed.png"">
    <link rel=""apple-touch-icon-precomposed"" sizes=""114x114"" href=""/themes/images/ico/apple-touch-icon-114-precomposed.png"">
    <link rel=""apple-touch-icon-precomposed"" sizes=""72x72"" href=""/themes/images/ico/apple-touch-icon-72-precomposed.png"">
    <link rel=""apple-touch-icon-precomposed"" href=""/themes/images/ico/apple-touch-icon-57-precomposed.png"">
    <style type=""text/css"" id=""enject""></style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01195461b029f6310c58e4342129ca3f2c002c139157", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" id=\"hidBaseAddress\"");
                BeginWriteAttribute("value", " value=\"", 2142, "\"", 2179, 1);
#nullable restore
#line 36 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2150, Configuration["BaseAddress"], 2150, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <div id=\"header\">\r\n        <div class=\"container\">\r\n            <div id=\"welcomeLine\" class=\"row\">\r\n");
#nullable restore
#line 40 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Shared\_Layout.cshtml"
                 if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"span6\">Xin chào!<strong> ");
#nullable restore
#line 42 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Shared\_Layout.cshtml"
                                                    Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong></div>\r\n");
#nullable restore
#line 43 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Shared\_Layout.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"span6\">Xin chào!<strong> Guest!</strong></div>\r\n");
#nullable restore
#line 47 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Shared\_Layout.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <div class=""span6"">
                    <div class=""pull-right"">
                        <a href=""/cart"">
                            <span class=""btn btn-mini btn-primary""><i class=""icon-shopping-cart icon-white""></i> [ <span id=""lbl_number_items_header""></span> ] sản phẩm trong giỏ hàng </span>
                        </a>
                    </div>
                </div>
            </div>
            <!-- Navbar ================================================== -->
            <div id=""logoArea"" class=""navbar"">
                <a id=""smallScreen"" data-target=""#topMenu"" data-toggle=""collapse"" class=""btn btn-navbar"">
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                </a>
                <div class=""navbar-inner"">
                    <a class=""brand"" href=""/""><img src=""/themes/images/LogoCircle.png"" alt=""HADIshop"" /></a>
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01195461b029f6310c58e4342129ca3f2c002c1312527", async() => {
                    WriteLiteral("\r\n                        <input id=\"srchFld\" class=\"srchTxt\" type=\"text\" />\r\n                        <select class=\"srchTxt\">\r\n                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01195461b029f6310c58e4342129ca3f2c002c1312960", async() => {
                        WriteLiteral("SON MÔI ");
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
                    WriteLiteral("\r\n                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01195461b029f6310c58e4342129ca3f2c002c1314061", async() => {
                        WriteLiteral("PHẤN NƯỚC ");
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
                    WriteLiteral("\r\n                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01195461b029f6310c58e4342129ca3f2c002c1315164", async() => {
                        WriteLiteral("CHÌ KẺ MÀY ");
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
                    WriteLiteral("\r\n                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01195461b029f6310c58e4342129ca3f2c002c1316268", async() => {
                        WriteLiteral("KEM CHE KHUYẾT ĐIỂM ");
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
                    WriteLiteral("\r\n                        </select>\r\n                        <button type=\"submit\" id=\"submitButton\" class=\"btn btn-primary\">Tìm</button>\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <ul id=\"topMenu\" class=\"nav pull-right\">\r\n                        <li");
                BeginWriteAttribute("class", " class=\"", 4317, "\"", 4325, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 77 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Shared\_Layout.cshtml"
                             if (User.Identity.IsAuthenticated)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01195461b029f6310c58e4342129ca3f2c002c1319573", async() => {
                    WriteLiteral(@"
                                    <button type=""submit"" style=""padding-right:0; margin-top:10px; margin-bottom:0px; background:transparent;border:none"">
                                        <span class=""btn btn-large btn-success"">Đăng xuất</span>
                                    </button>
                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 84 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Shared\_Layout.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <a href=\"/Account/Login\" style=\"padding-right:0\">\r\n                                    <span class=\"btn btn-large btn-success\">Đăng nhập</span>\r\n                                </a>\r\n");
#nullable restore
#line 90 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Shared\_Layout.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- Header End====================================================================== -->\r\n    ");
#nullable restore
#line 98 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Shared\_Layout.cshtml"
Write(RenderSection("slider", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <div id=""mainBody"">
        <div class=""container"">
            <div class=""row"">
                <!-- Sidebar ================================================== -->
                <div id=""mainBody"">
                    <div class=""container"">
                        <div class=""row"">
                            <!-- Sidebar ================================================== -->
                            ");
#nullable restore
#line 107 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Shared\_Layout.cshtml"
                       Write(await Component.InvokeAsync("SideBar"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <!-- Sidebar end=============================================== -->\r\n                            <div class=\"span9\">\r\n                                ");
#nullable restore
#line 110 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Shared\_Layout.cshtml"
                           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Footer ================================================================== -->
                <div id=""footerSection"">
                    <div class=""container"">
                        <div class=""row"">
                            <div class=""span3"">
                                <h5>TÀI KHOẢN</h5>
                                <a href=""login.html"">Tài khoản của bạn</a>
                                <a href=""login.html"">Thông tin cá nhân</a>
                                <a href=""login.html"">Địa chỉ</a>
                            </div>
                            <div class=""span3"">
                                <h5>THÔNG TIN</h5>
                                <a href=""contact.html"">Liên hệ</a>
                                <a href=""register.html"">Đăng ký</a>
                                <a href=""tac.html"">Các điều khoản dịch vụ</a>
");
                WriteLiteral(@"                            </div>
                            <div id=""socialMedia"" class=""span3 pull-right"">
                                <h5>MẠNG XÃ HỘI </h5>
                                <a href=""#""><img width=""60"" height=""60"" src=""/themes/images/facebook.png"" title=""facebook"" alt=""facebook"" /></a>
                                <a href=""#""><img width=""60"" height=""60"" src=""/themes/images/twitter.png"" title=""twitter"" alt=""twitter"" /></a>
                            </div>
                        </div>
                        <p class=""pull-right"">&copy; HADIshop</p>
                    </div><!-- Container End -->
                </div>
                <!-- Placed at the end of the document so the pages load faster ============================================= -->
                <script src=""/themes/js/jquery.js"" type=""text/javascript""></script>
                <script src=""/themes/js/bootstrap.min.js"" type=""text/javascript""></script>
                <script src=""/themes/js/google-cod");
                WriteLiteral(@"e-prettify/prettify.js""></script>

                <script src=""/themes/js/bootshop.js""></script>
                <script src=""/themes/js/jquery.lightbox-0.5.js""></script>
                <script src=""/js/site.js""></script>
                <script>
                    var site = new SiteController();
                    site.initialize();
                </script>
                ");
#nullable restore
#line 152 "D:\TaiLieuHocTap\Nam 4\Diem\TLCN-Xay-dung-website-ban-my-pham\Backupdiem\Test Order\WebMyPham_test\WebMyPham.WebApp\Views\Shared\_Layout.cshtml"
           Write(RenderSection("scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                
                <!-- /themes switcher section ============================================================================================= -->
                <div id=""secectionBox"">
                    <link rel=""stylesheet"" href=""/themes/switch//themeswitch.css"" type=""text/css"" media=""screen"" />
                    <script src=""/themes/switch/theamswitcher.js"" type=""text/javascript"" charset=""utf-8""></script>
                    <div id=""themeContainer"">
                        <div id=""hideme"" class=""themeTitle"">Style Selector</div>
                        <div class=""themeName"">Oregional Skin</div>
                        <div class=""images style"">
                            <a href=""/themes/css/#"" name=""bootshop""><img src=""/themes/switch/images/clr/bootshop.png"" alt=""bootstrap business templates"" class=""active""></a>
                            <a href=""/themes/css/#"" name=""businessltd""><img src=""/themes/switch/images/clr/businessltd.png"" alt=""bootstrap business templates"" cl");
                WriteLiteral(@"ass=""active""></a>
                        </div>
                        <div class=""themeName"">Bootswatch Skins (11)</div>
                        <div class=""images style"">
                            <a href=""/themes/css/#"" name=""amelia"" title=""Amelia""><img src=""/themes/switch/images/clr/amelia.png"" alt=""bootstrap business templates""></a>
                            <a href=""/themes/css/#"" name=""spruce"" title=""Spruce""><img src=""/themes/switch/images/clr/spruce.png"" alt=""bootstrap business templates""></a>
                            <a href=""/themes/css/#"" name=""superhero"" title=""Superhero""><img src=""/themes/switch/images/clr/superhero.png"" alt=""bootstrap business templates""></a>
                            <a href=""/themes/css/#"" name=""cyborg""><img src=""/themes/switch/images/clr/cyborg.png"" alt=""bootstrap business templates""></a>
                            <a href=""/themes/css/#"" name=""cerulean""><img src=""/themes/switch/images/clr/cerulean.png"" alt=""bootstrap business templates""></a>
            ");
                WriteLiteral(@"                <a href=""/themes/css/#"" name=""journal""><img src=""/themes/switch/images/clr/journal.png"" alt=""bootstrap business templates""></a>
                            <a href=""/themes/css/#"" name=""readable""><img src=""/themes/switch/images/clr/readable.png"" alt=""bootstrap business templates""></a>
                            <a href=""/themes/css/#"" name=""simplex""><img src=""/themes/switch/images/clr/simplex.png"" alt=""bootstrap business templates""></a>
                            <a href=""/themes/css/#"" name=""slate""><img src=""/themes/switch/images/clr/slate.png"" alt=""bootstrap business templates""></a>
                            <a href=""/themes/css/#"" name=""spacelab""><img src=""/themes/switch/images/clr/spacelab.png"" alt=""bootstrap business templates""></a>
                            <a href=""/themes/css/#"" name=""united""><img src=""/themes/switch/images/clr/united.png"" alt=""bootstrap business templates""></a>
                            <p style=""margin:0;line-height:normal;margin-left:-10px;display:none");
                WriteLiteral(@";""><small>These are just examples and you can build your own color scheme in the backend.</small></p>
                        </div>
                        <div class=""themeName"">Background Patterns </div>
                        <div class=""images patterns"">
                            <a href=""/themes/css/#"" name=""pattern1""><img src=""/themes/switch/images/pattern/pattern1.png"" alt=""bootstrap business templates"" class=""active""></a>
                            <a href=""/themes/css/#"" name=""pattern2""><img src=""/themes/switch/images/pattern/pattern2.png"" alt=""bootstrap business templates""></a>
                            <a href=""/themes/css/#"" name=""pattern3""><img src=""/themes/switch/images/pattern/pattern3.png"" alt=""bootstrap business templates""></a>
                            <a href=""/themes/css/#"" name=""pattern4""><img src=""/themes/switch/images/pattern/pattern4.png"" alt=""bootstrap business templates""></a>
                            <a href=""/themes/css/#"" name=""pattern5""><img src=""/themes/switch");
                WriteLiteral(@"/images/pattern/pattern5.png"" alt=""bootstrap business templates""></a>
                            <a href=""/themes/css/#"" name=""pattern6""><img src=""/themes/switch/images/pattern/pattern6.png"" alt=""bootstrap business templates""></a>
                            <a href=""/themes/css/#"" name=""pattern7""><img src=""/themes/switch/images/pattern/pattern7.png"" alt=""bootstrap business templates""></a>
                            <a href=""/themes/css/#"" name=""pattern8""><img src=""/themes/switch/images/pattern/pattern8.png"" alt=""bootstrap business templates""></a>
                            <a href=""/themes/css/#"" name=""pattern9""><img src=""/themes/switch/images/pattern/pattern9.png"" alt=""bootstrap business templates""></a>
                            <a href=""/themes/css/#"" name=""pattern10""><img src=""/themes/switch/images/pattern/pattern10.png"" alt=""bootstrap business templates""></a>

                            <a href=""/themes/css/#"" name=""pattern11""><img src=""/themes/switch/images/pattern/pattern11.png"" alt=""boots");
                WriteLiteral(@"trap business templates""></a>
                            <a href=""/themes/css/#"" name=""pattern12""><img src=""/themes/switch/images/pattern/pattern12.png"" alt=""bootstrap business templates""></a>
                            <a href=""/themes/css/#"" name=""pattern13""><img src=""/themes/switch/images/pattern/pattern13.png"" alt=""bootstrap business templates""></a>
                            <a href=""/themes/css/#"" name=""pattern14""><img src=""/themes/switch/images/pattern/pattern14.png"" alt=""bootstrap business templates""></a>
                            <a href=""/themes/css/#"" name=""pattern15""><img src=""/themes/switch/images/pattern/pattern15.png"" alt=""bootstrap business templates""></a>

                            <a href=""/themes/css/#"" name=""pattern16""><img src=""/themes/switch/images/pattern/pattern16.png"" alt=""bootstrap business templates""></a>
                            <a href=""/themes/css/#"" name=""pattern17""><img src=""/themes/switch/images/pattern/pattern17.png"" alt=""bootstrap business templates""></a>
 ");
                WriteLiteral(@"                           <a href=""/themes/css/#"" name=""pattern18""><img src=""/themes/switch/images/pattern/pattern18.png"" alt=""bootstrap business templates""></a>
                            <a href=""/themes/css/#"" name=""pattern19""><img src=""/themes/switch/images/pattern/pattern19.png"" alt=""bootstrap business templates""></a>
                            <a href=""/themes/css/#"" name=""pattern20""><img src=""/themes/switch/images/pattern/pattern20.png"" alt=""bootstrap business templates""></a>

                        </div>
                    </div>
                </div>
                <span id=""/themesBtn""></span>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
