#pragma checksum "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Affiliate\_CreateOrUpdate.Orders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "582b3e56862422afe93dfeadd2965dc1c3b220a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Affiliate__CreateOrUpdate_Orders), @"mvc.1.0.view", @"/Areas/Admin/Views/Affiliate/_CreateOrUpdate.Orders.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 7 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core.Domain.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Services.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Affiliates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Cms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Customers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Directory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Discounts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.ExternalAuthentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Forums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Messages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Orders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Payments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Plugins;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Plugins.Marketplace;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Polls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Reports;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Security;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Shipping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Stores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Tax;

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Templates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Topics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Vendors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models.DataTables;

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Captcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Honeypot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Themes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"582b3e56862422afe93dfeadd2965dc1c3b220a7", @"/Areas/Admin/Views/Affiliate/_CreateOrUpdate.Orders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9afeeb77ddd3a4a2e0698ab1d31f0fa32cb5e81", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Affiliate__CreateOrUpdate_Orders : Nop.Web.Framework.Mvc.Razor.NopRazorPage<AffiliateModel>
    {
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
        private global::Nop.Web.Framework.TagHelpers.Admin.NopLabelTagHelper __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Admin.NopEditorTagHelper __Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Admin.NopSelectTagHelper __Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""panel-group"">
    <div class=""sub-panel panel-search"">
        <div class=""panel-body"">
            <div class=""row"">
                <div class=""col-md-7"">
                    <div class=""form-group"">
                        <div class=""col-md-5"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "582b3e56862422afe93dfeadd2965dc1c3b220a714277", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopLabelTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper);
#nullable restore
#line 10 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Affiliate\_CreateOrUpdate.Orders.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AffiliatedOrderSearchModel.StartDate);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-5\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-editor", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "582b3e56862422afe93dfeadd2965dc1c3b220a715901", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopEditorTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper);
#nullable restore
#line 13 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Affiliate\_CreateOrUpdate.Orders.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AffiliatedOrderSearchModel.StartDate);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <div class=\"col-md-5\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "582b3e56862422afe93dfeadd2965dc1c3b220a717611", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopLabelTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper);
#nullable restore
#line 18 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Affiliate\_CreateOrUpdate.Orders.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AffiliatedOrderSearchModel.EndDate);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-5\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-editor", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "582b3e56862422afe93dfeadd2965dc1c3b220a719233", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopEditorTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper);
#nullable restore
#line 21 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Affiliate\_CreateOrUpdate.Orders.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AffiliatedOrderSearchModel.EndDate);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-4\">\r\n                    <div class=\"form-group\">\r\n                        <div class=\"col-md-4\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "582b3e56862422afe93dfeadd2965dc1c3b220a721011", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopLabelTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper);
#nullable restore
#line 28 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Affiliate\_CreateOrUpdate.Orders.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AffiliatedOrderSearchModel.OrderStatusId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-8\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "582b3e56862422afe93dfeadd2965dc1c3b220a722639", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopSelectTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper);
#nullable restore
#line 31 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Affiliate\_CreateOrUpdate.Orders.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AffiliatedOrderSearchModel.OrderStatusId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 31 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Affiliate\_CreateOrUpdate.Orders.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper.Items = Model.AffiliatedOrderSearchModel.AvailableOrderStatuses;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <div class=\"col-md-4\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "582b3e56862422afe93dfeadd2965dc1c3b220a724896", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopLabelTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper);
#nullable restore
#line 36 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Affiliate\_CreateOrUpdate.Orders.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AffiliatedOrderSearchModel.PaymentStatusId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-8\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "582b3e56862422afe93dfeadd2965dc1c3b220a726526", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopSelectTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper);
#nullable restore
#line 39 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Affiliate\_CreateOrUpdate.Orders.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AffiliatedOrderSearchModel.PaymentStatusId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 39 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Affiliate\_CreateOrUpdate.Orders.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper.Items = Model.AffiliatedOrderSearchModel.AvailablePaymentStatuses;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <div class=\"col-md-4\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "582b3e56862422afe93dfeadd2965dc1c3b220a728787", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopLabelTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper);
#nullable restore
#line 44 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Affiliate\_CreateOrUpdate.Orders.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AffiliatedOrderSearchModel.ShippingStatusId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-8\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "582b3e56862422afe93dfeadd2965dc1c3b220a730418", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopSelectTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper);
#nullable restore
#line 47 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Affiliate\_CreateOrUpdate.Orders.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AffiliatedOrderSearchModel.ShippingStatusId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 47 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Affiliate\_CreateOrUpdate.Orders.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper.Items = Model.AffiliatedOrderSearchModel.AvailableShippingStatuses;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Nop_Web_Framework_TagHelpers_Admin_NopSelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-8 col-md-offset-5"">
                    <button type=""button"" id=""search-orders"" class=""btn btn-primary btn-search"">
                        <i class=""fa fa-search""></i>
                        ");
#nullable restore
#line 56 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Affiliate\_CreateOrUpdate.Orders.cshtml"
                   Write(T("Admin.Common.Search"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"sub-panel\">\r\n        <div class=\"panel-body\">\r\n            ");
#nullable restore
#line 65 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Affiliate\_CreateOrUpdate.Orders.cshtml"
       Write(await Html.PartialAsync("Table", new DataTablesModel
            {
                Name = "orders-grid",
                UrlRead = new DataUrl("AffiliatedOrderListGrid", "Affiliate", new RouteValueDictionary { [nameof(Model.AffiliatedOrderSearchModel.AffliateId)] = Model.AffiliatedOrderSearchModel.AffliateId }),
                SearchButtonId = "search-orders",
                Length = Model.AffiliatedOrderSearchModel.PageSize,
                LengthMenu = Model.AffiliatedOrderSearchModel.AvailablePageSizes,
                Filters = new List<FilterParameter>
                {
                    new FilterParameter(nameof(Model.AffiliatedOrderSearchModel.StartDate), nameof(AffiliatedOrderSearchModel)),
                    new FilterParameter(nameof(Model.AffiliatedOrderSearchModel.EndDate), nameof(AffiliatedOrderSearchModel)),
                    new FilterParameter(nameof(Model.AffiliatedOrderSearchModel.OrderStatusId), nameof(AffiliatedOrderSearchModel)),
                    new FilterParameter(nameof(Model.AffiliatedOrderSearchModel.PaymentStatusId), nameof(AffiliatedOrderSearchModel)),
                    new FilterParameter(nameof(Model.AffiliatedOrderSearchModel.ShippingStatusId), nameof(AffiliatedOrderSearchModel))
                },
                ColumnCollection = new List<ColumnProperty>
                {
                    new ColumnProperty(nameof(AffiliatedOrderModel.CustomOrderNumber))
                    {
                        Title = T("Admin.Affiliates.Orders.CustomOrderNumber").Text,
                        Width = "200"
                    },
                    new ColumnProperty(nameof(AffiliatedOrderModel.OrderStatus))
                    {
                        Title = T("Admin.Affiliates.Orders.OrderStatus").Text,
                        Render = new RenderCustom("renderOrderStatus")
                    },
                    new ColumnProperty(nameof(AffiliatedOrderModel.PaymentStatus))
                    {
                        Title = T("Admin.Affiliates.Orders.PaymentStatus").Text
                    },
                    new ColumnProperty(nameof(AffiliatedOrderModel.ShippingStatus))
                    {
                        Title = T("Admin.Affiliates.Orders.ShippingStatus").Text
                    },
                    new ColumnProperty(nameof(AffiliatedOrderModel.OrderTotal))
                    {
                        Title = T("Admin.Affiliates.Orders.OrderTotal").Text
                    },
                    new ColumnProperty(nameof(AffiliatedOrderModel.CreatedOn))
                    {
                        Title = T("Admin.Affiliates.Orders.CreatedOn").Text,
                        Render = new RenderDate()
                    },
                    new ColumnProperty(nameof(AffiliatedOrderModel.Id))
                    {
                        Title = T("Admin.Common.View").Text,
                        Width = "150",
                        ClassName = NopColumnClassDefaults.Button,
                        Render = new RenderButtonView(new DataUrl("~/Admin/Order/Edit/", nameof(AffiliatedOrderModel.Id)))
                    }
                }
            }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            <script>
                var selectedIds = [];
                var reportAggregates = """";

                function renderOrderStatus(data, type, row, meta) {

                    var color;
                    switch (row.OrderStatusId) {
                        case 10: color = 'yellow'; break;
                        case 20: color = 'blue'; break;
                        case 30: color = 'green'; break;
                        case 40: color = 'red'; break;
                    }

                    return '<span class=""grid-report-item ' + color + '"">' + data + '</span >';
                }
            </script>
        </div>
    </div>
</div>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IWorkContext workContext { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Nop.Services.Common.IGenericAttributeService genericAttributeService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AffiliateModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
