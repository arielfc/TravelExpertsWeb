#pragma checksum "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Packages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d54179669ccb830824b7460f54b71683da8a633"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Packages_Index), @"mvc.1.0.view", @"/Views/Packages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Packages/Index.cshtml", typeof(AspNetCore.Views_Packages_Index))]
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
#line 1 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\_ViewImports.cshtml"
using TravelExpertsWebApplication;

#line default
#line hidden
#line 2 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\_ViewImports.cshtml"
using TravelExpertsWebApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d54179669ccb830824b7460f54b71683da8a633", @"/Views/Packages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ec27a57c32b3e477a5aaabe6d0a2045105b9f93", @"/Views/_ViewImports.cshtml")]
    public class Views_Packages_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TravelExpertsWebApplication.Models.Packages>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Packages\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(108, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(137, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fd61a38642445ea90e6e7a82273a56d", async() => {
                BeginContext(160, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(174, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(267, 43, false);
#line 16 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Packages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PkgName));

#line default
#line hidden
            EndContext();
            BeginContext(310, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(366, 48, false);
#line 19 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Packages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PkgStartDate));

#line default
#line hidden
            EndContext();
            BeginContext(414, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(470, 46, false);
#line 22 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Packages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PkgEndDate));

#line default
#line hidden
            EndContext();
            BeginContext(516, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(572, 43, false);
#line 25 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Packages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PkgDesc));

#line default
#line hidden
            EndContext();
            BeginContext(615, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(671, 48, false);
#line 28 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Packages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PkgBasePrice));

#line default
#line hidden
            EndContext();
            BeginContext(719, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(775, 55, false);
#line 31 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Packages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PkgAgencyCommission));

#line default
#line hidden
            EndContext();
            BeginContext(830, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(886, 42, false);
#line 34 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Packages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PkgImg));

#line default
#line hidden
            EndContext();
            BeginContext(928, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 40 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Packages\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1046, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1095, 42, false);
#line 43 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Packages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PkgName));

#line default
#line hidden
            EndContext();
            BeginContext(1137, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1193, 47, false);
#line 46 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Packages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PkgStartDate));

#line default
#line hidden
            EndContext();
            BeginContext(1240, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1296, 45, false);
#line 49 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Packages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PkgEndDate));

#line default
#line hidden
            EndContext();
            BeginContext(1341, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1397, 42, false);
#line 52 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Packages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PkgDesc));

#line default
#line hidden
            EndContext();
            BeginContext(1439, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1495, 47, false);
#line 55 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Packages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PkgBasePrice));

#line default
#line hidden
            EndContext();
            BeginContext(1542, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1598, 54, false);
#line 58 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Packages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PkgAgencyCommission));

#line default
#line hidden
            EndContext();
            BeginContext(1652, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1708, 41, false);
#line 61 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Packages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PkgImg));

#line default
#line hidden
            EndContext();
            BeginContext(1749, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1804, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c4d1648d8674db3bed269033c2f7087", async() => {
                BeginContext(1856, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Packages\Index.cshtml"
                                       WriteLiteral(item.PackageId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1864, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1884, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a2a1a7ba6de40d78ce7a0d0cf31937b", async() => {
                BeginContext(1939, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Packages\Index.cshtml"
                                          WriteLiteral(item.PackageId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1950, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1970, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc839bec86a04580b2f2d74cbde38ff9", async() => {
                BeginContext(2024, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 66 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Packages\Index.cshtml"
                                         WriteLiteral(item.PackageId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2034, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 69 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Packages\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2073, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TravelExpertsWebApplication.Models.Packages>> Html { get; private set; }
    }
}
#pragma warning restore 1591
