#pragma checksum "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Shared\_AdminPopupLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0554563d2169dc10baf4176cc0e4c4a2b008e011"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__AdminPopupLayout), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_AdminPopupLayout.cshtml")]
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
#line 7 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Shared\_AdminPopupLayout.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Shared\_AdminPopupLayout.cshtml"
using Nop.Web.Framework.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Shared\_AdminPopupLayout.cshtml"
using Nop.Core.Domain.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Shared\_AdminPopupLayout.cshtml"
using Nop.Services.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0554563d2169dc10baf4176cc0e4c4a2b008e011", @"/Areas/Admin/Views/Shared/_AdminPopupLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9afeeb77ddd3a4a2e0698ab1d31f0fa32cb5e81", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__AdminPopupLayout : Nop.Web.Framework.Mvc.Razor.NopRazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition skin-blue sidebar-collapse"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Nop.Web.Framework.TagHelpers.Shared.NopAntiForgeryTokenTagHelper __Nop_Web_Framework_TagHelpers_Shared_NopAntiForgeryTokenTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 12 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Shared\_AdminPopupLayout.cshtml"
  
    //Kendo UI
    var kendoVersion = "2020.1.406";
    var currentKendoCulture = EngineContext.Current.Resolve<IWorkContext>().WorkingLanguage.LanguageCulture;
    var currentCulture = CultureInfo.CurrentCulture;

    //Code to get check if current cultures scripts are exists. If not, select parent cultures scripts
    string GetDefaultLocale()
    {
        var localePattern = NopCommonDefaults.LocalePatternPath;
        var cultureToUse = NopCommonDefaults.DefaultLocalePattern; //Default regionalisation to use

        if (fileProvider.DirectoryExists(fileProvider.Combine(WebHostEnvironment.WebRootPath, string.Format(localePattern, currentCulture.Name))))
            cultureToUse = currentCulture.Name;
        else if (fileProvider.DirectoryExists(fileProvider.Combine(WebHostEnvironment.WebRootPath, string.Format(localePattern, currentCulture.TwoLetterISOLanguageName))))
            cultureToUse = currentCulture.TwoLetterISOLanguageName;

        return cultureToUse;
    }

    var jQueryUI = "1.10.3";

    var supportRtl = workContext.WorkingLanguage.Rtl && !localizationSettings.IgnoreRtlPropertyForAdminArea;

    //CSS resources
    if (supportRtl)
    {
        Html.AppendCssFileParts("~/css/admin/styles.rtl.css");
        Html.AppendCssFileParts("~/lib/adminLTE/css/AdminLTE.rtl.css");
        Html.AppendCssFileParts("~/lib/bootstrap/css/bootstrap.rtl.css");
    }
    else
    {
        Html.AppendCssFileParts("~/css/admin/styles.css");
        Html.AppendCssFileParts("~/lib/adminLTE/css/AdminLTE.min.css");
        Html.AppendCssFileParts("~/lib/bootstrap/css/bootstrap.min.css");
    }

    Html.AppendCssFileParts($"~/lib/datatables/buttons.bootstrap.min.css");
    Html.AppendCssFileParts($"~/lib/datatables/buttons.dataTables.min.css");
    Html.AppendCssFileParts($"~/lib/datatables/datatables.min.css");
    Html.AppendCssFileParts($"~/lib/datatables/css/dataTables.bootstrap.css");
    Html.AppendCssFileParts($"~/lib/kendo/{kendoVersion}/styles/web/kendo.rtl.min.css");
    Html.AppendCssFileParts($"~/lib/kendo/{kendoVersion}/styles/web/kendo.default.min.css");
    Html.AppendCssFileParts($"~/lib/kendo/{kendoVersion}/styles/web/kendo.common.min.css");
    Html.AppendCssFileParts($"~/lib/jquery-ui/jquery-ui-{jQueryUI}/jquery-ui-themes/smoothness/jquery-ui-{jQueryUI}.custom.min.css");
    Html.AppendCssFileParts("~/lib/fontAwesome/css/font-awesome.min.css");
    Html.AppendCssFileParts("~/lib/bootstrap-touchspin/jquery.bootstrap-touchspin.min.css");
    //AdminLTE Skins (choose a skin from the css/skins)
    Html.AppendCssFileParts("~/lib/adminLTE/css/skins/_all-skins.min.css");

    //scripts
    Html.AppendScriptParts($"~/lib/datatables/buttons.bootstrap.min.js");
    Html.AppendScriptParts($"~/lib/datatables/dataTables.buttons.min.js");
    Html.AppendScriptParts($"~/lib/datatables/moment-with-locales-2.22.2.min.js");
    Html.AppendScriptParts($"~/lib/datatables/datatables.min.js");
    Html.AppendScriptParts($"~/lib/datatables/js/dataTables.bootstrap.min.js");
    Html.AppendScriptParts($"~/lib/datatables/js/jquery.dataTables.min.js");
    Html.AppendScriptParts($"~/lib/kendo/{kendoVersion}/js/cultures/kendo.culture.{currentKendoCulture}.min.js");
    Html.AppendScriptParts($"~/lib/kendo/{kendoVersion}/js/messages/kendo.messages.{currentKendoCulture}.min.js");
    Html.AppendScriptParts($"~/lib/kendo/{kendoVersion}/js/kendo.ui.core.min.js");

    Html.AppendScriptParts("~/js/admin.common.js");
    Html.AppendScriptParts("~/lib/jquery-migrate/jquery-migrate-3.1.0.min.js");
    Html.AppendScriptParts($"~/lib/jquery-ui/jquery-ui-{jQueryUI}/jquery-ui-{jQueryUI}.custom.min.js");

    // this file can be downloaded from :
    // https://github.com/johnnyreilly/jquery-validation-globalize
    //Html.AppendScriptParts("https://cdn.jsdelivr.net/gh/johnnyreilly/jquery-validation-globalize@1.0.0/jquery.validate.globalize.min.js");
    Html.AppendScriptParts("~/lib/jquery-validate/jquery.validate.globalize-1.0.0.min.js");

    // globalize scripts
    Html.AppendScriptParts("~/lib/globalize/dist/globalize/currency.min.js");
    Html.AppendScriptParts("~/lib/globalize/dist/globalize/date.min.js");
    Html.AppendScriptParts("~/lib/globalize/dist/globalize/number.min.js");
    Html.AppendScriptParts("~/lib/globalize/dist/globalize.min.js");

    // cldr scripts (needed for globalize)
    Html.AppendScriptParts("~/lib/cldr/dist/cldr/supplemental.min.js");
    Html.AppendScriptParts("~/lib/cldr/dist/cldr/event.min.js");
    Html.AppendScriptParts("~/lib/cldr/dist/cldr.min.js");

    Html.AppendScriptParts("~/lib/jquery-validate/jquery.validate.unobtrusive-v3.2.11/jquery.validate.unobtrusive.min.js");
    Html.AppendScriptParts("~/lib/jquery-validate/jquery.validate-v1.19.1/jquery.validate.min.js");
    Html.AppendScriptParts("~/lib/adminLTE/js/adminlte.min.js");
    Html.AppendScriptParts("~/lib/bootstrap/js/bootstrap.min.js");
    Html.AppendScriptParts("~/lib/bootstrap-touchspin/jquery.bootstrap-touchspin.min.js");
    Html.AppendScriptParts("~/lib/jquery/jquery-3.4.1.min.js");

    //page title
    string adminPageTitle = !string.IsNullOrWhiteSpace(ViewBag.PageTitle) ? ViewBag.PageTitle + " / " : "";
    adminPageTitle += T("Admin.PageTitle").Text;

    //event
    eventPublisher.Publish(new PageRenderingEvent(this.Html));

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html");
            BeginWriteAttribute("lang", " lang=\"", 5914, "\"", 5994, 1);
#nullable restore
#line 109 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Shared\_AdminPopupLayout.cshtml"
WriteAttributeValue("", 5921, languageService.GetTwoLetterIsoLanguageName(workContext.WorkingLanguage), 5921, 73, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 109 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Shared\_AdminPopupLayout.cshtml"
                                                                                   Write(supportRtl ? Html.Raw(" dir=\"rtl\"") : null);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0554563d2169dc10baf4176cc0e4c4a2b008e01121447", async() => {
                WriteLiteral("\r\n    <title>");
#nullable restore
#line 111 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Shared\_AdminPopupLayout.cshtml"
      Write(adminPageTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n    <meta http-equiv=\"Content-type\" content=\"text/html;charset=UTF-8\" />\r\n");
                WriteLiteral("    <link rel=\"stylesheet\" href=\"https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700,300italic,400italic,600italic\">\r\n    <script>\r\n            var rootAppPath = \'");
#nullable restore
#line 116 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Shared\_AdminPopupLayout.cshtml"
                           Write(Url.Content("~/"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\r\n    </script>\r\n    ");
#nullable restore
#line 118 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Shared\_AdminPopupLayout.cshtml"
Write(Html.NopHeadCustom());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 119 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Shared\_AdminPopupLayout.cshtml"
Write(Html.NopCssFiles(ResourceLocation.Head, false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 120 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Shared\_AdminPopupLayout.cshtml"
Write(Html.NopScripts(ResourceLocation.Head, false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0554563d2169dc10baf4176cc0e4c4a2b008e01124142", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n            var culture = \"");
#nullable restore
#line 124 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Shared\_AdminPopupLayout.cshtml"
                      Write(GetDefaultLocale());

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";

            //load cldr for current culture
            $.when(
                $.get(""/lib/cldr-data/supplemental/likelySubtags.json""),
                $.get(""/lib/cldr-data/main/"" + culture + ""/numbers.json""),
                $.get(""/lib/cldr-data/main/"" + culture + ""/currencies.json""),
                $.get(""/lib/cldr-data/supplemental/numberingSystems.json""),
                $.get(""/lib/cldr-data/main/"" + culture + ""/ca-gregorian.json""),
                $.get(""/lib/cldr-data/main/"" + culture + ""/timeZoneNames.json""),
                $.get(""/lib/cldr-data/supplemental/timeData.json""),
                $.get(""/lib/cldr-data/supplemental/weekData.json""),
            ).then(function () {
                // Normalize $.get results, we only need the JSON, not the request statuses.
                return [].slice.apply(arguments, [0]).map(function (result) {
                    return result[0];
                });
            }).then(Globalize.load).then(function () {
                Global");
                WriteLiteral("ize.locale(culture);\r\n            });\r\n    </script>\r\n    <script>\r\n            kendo.culture(\"");
#nullable restore
#line 146 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Shared\_AdminPopupLayout.cshtml"
                       Write(currentKendoCulture);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n    </script>\r\n    <div class=\"wrapper\">\r\n        <div class=\"content-wrapper\">\r\n            ");
#nullable restore
#line 150 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Shared\_AdminPopupLayout.cshtml"
       Write(await Html.PartialAsync("~/Areas/Admin/Views/Shared/Notifications.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <div>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-antiforgery-token", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0554563d2169dc10baf4176cc0e4c4a2b008e01126679", async() => {
                }
                );
                __Nop_Web_Framework_TagHelpers_Shared_NopAntiForgeryTokenTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Shared.NopAntiForgeryTokenTagHelper>();
                __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Shared_NopAntiForgeryTokenTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
#nullable restore
#line 153 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Shared\_AdminPopupLayout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    ");
#nullable restore
#line 157 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Shared\_AdminPopupLayout.cshtml"
Write(Html.NopCssFiles(ResourceLocation.Footer));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 158 "D:\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Shared\_AdminPopupLayout.cshtml"
Write(Html.NopScripts(ResourceLocation.Footer));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            //enable tooltips\r\n            $(\'[data-toggle=\"tooltip\"]\').tooltip();\r\n        });\r\n    </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Nop.Services.Localization.ILanguageService languageService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Hosting.IWebHostEnvironment WebHostEnvironment { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public INopFileProvider fileProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IEventPublisher eventPublisher { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public CommonSettings commonSettings { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LocalizationSettings localizationSettings { get; private set; }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
