#pragma checksum "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Agencies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49ae40cee4ccb0f88f592d7fc5dcaf4749449da1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Agencies_Index), @"mvc.1.0.view", @"/Views/Agencies/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Agencies/Index.cshtml", typeof(AspNetCore.Views_Agencies_Index))]
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
#line 1 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\_ViewImports.cshtml"
using TravelExpertsWeb;

#line default
#line hidden
#line 2 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\_ViewImports.cshtml"
using TravelExpertsWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49ae40cee4ccb0f88f592d7fc5dcaf4749449da1", @"/Views/Agencies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64a7dc529f31657fa3adec2076b311a2819c11e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Agencies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TravelExpertsWeb.Models.Agencies>>
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
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Agencies\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(97, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(126, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49ae40cee4ccb0f88f592d7fc5dcaf4749449da14834", async() => {
                BeginContext(149, 10, true);
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
            BeginContext(163, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(256, 48, false);
#line 16 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Agencies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AgncyAddress));

#line default
#line hidden
            EndContext();
            BeginContext(304, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(360, 45, false);
#line 19 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Agencies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AgncyCity));

#line default
#line hidden
            EndContext();
            BeginContext(405, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(461, 45, false);
#line 22 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Agencies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AgncyProv));

#line default
#line hidden
            EndContext();
            BeginContext(506, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(562, 47, false);
#line 25 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Agencies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AgncyPostal));

#line default
#line hidden
            EndContext();
            BeginContext(609, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(665, 48, false);
#line 28 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Agencies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AgncyCountry));

#line default
#line hidden
            EndContext();
            BeginContext(713, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(769, 46, false);
#line 31 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Agencies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AgncyPhone));

#line default
#line hidden
            EndContext();
            BeginContext(815, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(871, 44, false);
#line 34 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Agencies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AgncyFax));

#line default
#line hidden
            EndContext();
            BeginContext(915, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 40 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Agencies\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1033, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1082, 47, false);
#line 43 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Agencies\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AgncyAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1129, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1185, 44, false);
#line 46 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Agencies\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AgncyCity));

#line default
#line hidden
            EndContext();
            BeginContext(1229, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1285, 44, false);
#line 49 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Agencies\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AgncyProv));

#line default
#line hidden
            EndContext();
            BeginContext(1329, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1385, 46, false);
#line 52 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Agencies\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AgncyPostal));

#line default
#line hidden
            EndContext();
            BeginContext(1431, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1487, 47, false);
#line 55 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Agencies\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AgncyCountry));

#line default
#line hidden
            EndContext();
            BeginContext(1534, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1590, 45, false);
#line 58 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Agencies\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AgncyPhone));

#line default
#line hidden
            EndContext();
            BeginContext(1635, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1691, 43, false);
#line 61 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Agencies\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AgncyFax));

#line default
#line hidden
            EndContext();
            BeginContext(1734, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1789, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49ae40cee4ccb0f88f592d7fc5dcaf4749449da112920", async() => {
                BeginContext(1840, 4, true);
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
#line 64 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Agencies\Index.cshtml"
                                       WriteLiteral(item.AgencyId);

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
            BeginContext(1848, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1868, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49ae40cee4ccb0f88f592d7fc5dcaf4749449da115296", async() => {
                BeginContext(1922, 7, true);
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
#line 65 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Agencies\Index.cshtml"
                                          WriteLiteral(item.AgencyId);

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
            BeginContext(1933, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1953, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49ae40cee4ccb0f88f592d7fc5dcaf4749449da117678", async() => {
                BeginContext(2006, 6, true);
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
#line 66 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Agencies\Index.cshtml"
                                         WriteLiteral(item.AgencyId);

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
            BeginContext(2016, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 69 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Agencies\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2055, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TravelExpertsWeb.Models.Agencies>> Html { get; private set; }
    }
}
#pragma warning restore 1591
