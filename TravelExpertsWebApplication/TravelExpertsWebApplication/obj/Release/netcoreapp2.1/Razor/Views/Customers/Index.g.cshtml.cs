#pragma checksum "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "172bfafd2a7195b2821ec84aa98c3b81af990129"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Index), @"mvc.1.0.view", @"/Views/Customers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customers/Index.cshtml", typeof(AspNetCore.Views_Customers_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"172bfafd2a7195b2821ec84aa98c3b81af990129", @"/Views/Customers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ec27a57c32b3e477a5aaabe6d0a2045105b9f93", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TravelExpertsWebApplication.Models.Customers>>
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
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(109, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(138, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8945fcaa8d2e4980ba4db1940251ec55", async() => {
                BeginContext(161, 10, true);
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
            BeginContext(175, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(268, 49, false);
#line 16 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustFirstName));

#line default
#line hidden
            EndContext();
            BeginContext(317, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(373, 48, false);
#line 19 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustLastName));

#line default
#line hidden
            EndContext();
            BeginContext(421, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(477, 47, false);
#line 22 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustAddress));

#line default
#line hidden
            EndContext();
            BeginContext(524, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(580, 44, false);
#line 25 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustCity));

#line default
#line hidden
            EndContext();
            BeginContext(624, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(680, 44, false);
#line 28 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustProv));

#line default
#line hidden
            EndContext();
            BeginContext(724, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(780, 46, false);
#line 31 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustPostal));

#line default
#line hidden
            EndContext();
            BeginContext(826, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(882, 47, false);
#line 34 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustCountry));

#line default
#line hidden
            EndContext();
            BeginContext(929, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(985, 49, false);
#line 37 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustHomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(1034, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1090, 48, false);
#line 40 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustBusPhone));

#line default
#line hidden
            EndContext();
            BeginContext(1138, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1194, 45, false);
#line 43 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1239, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1295, 53, false);
#line 46 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PasswordNotHashed));

#line default
#line hidden
            EndContext();
            BeginContext(1348, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1404, 50, false);
#line 49 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PasswordHashed));

#line default
#line hidden
            EndContext();
            BeginContext(1454, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1510, 48, false);
#line 52 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PasswordSalt));

#line default
#line hidden
            EndContext();
            BeginContext(1558, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1614, 48, false);
#line 55 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustUserName));

#line default
#line hidden
            EndContext();
            BeginContext(1662, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1718, 41, false);
#line 58 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Agent));

#line default
#line hidden
            EndContext();
            BeginContext(1759, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 64 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1877, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1926, 48, false);
#line 67 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustFirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1974, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2030, 47, false);
#line 70 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustLastName));

#line default
#line hidden
            EndContext();
            BeginContext(2077, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2133, 46, false);
#line 73 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustAddress));

#line default
#line hidden
            EndContext();
            BeginContext(2179, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2235, 43, false);
#line 76 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustCity));

#line default
#line hidden
            EndContext();
            BeginContext(2278, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2334, 43, false);
#line 79 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustProv));

#line default
#line hidden
            EndContext();
            BeginContext(2377, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2433, 45, false);
#line 82 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustPostal));

#line default
#line hidden
            EndContext();
            BeginContext(2478, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2534, 46, false);
#line 85 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustCountry));

#line default
#line hidden
            EndContext();
            BeginContext(2580, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2636, 48, false);
#line 88 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustHomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(2684, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2740, 47, false);
#line 91 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustBusPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2787, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2843, 44, false);
#line 94 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustEmail));

#line default
#line hidden
            EndContext();
            BeginContext(2887, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2943, 52, false);
#line 97 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PasswordNotHashed));

#line default
#line hidden
            EndContext();
            BeginContext(2995, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3051, 49, false);
#line 100 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PasswordHashed));

#line default
#line hidden
            EndContext();
            BeginContext(3100, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3156, 47, false);
#line 103 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PasswordSalt));

#line default
#line hidden
            EndContext();
            BeginContext(3203, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3259, 47, false);
#line 106 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustUserName));

#line default
#line hidden
            EndContext();
            BeginContext(3306, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3362, 48, false);
#line 109 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Agent.AgentId));

#line default
#line hidden
            EndContext();
            BeginContext(3410, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3465, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e78f2421b844ebcbb1b83b63c38d28b", async() => {
                BeginContext(3518, 4, true);
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
#line 112 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
                                       WriteLiteral(item.CustomerId);

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
            BeginContext(3526, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3546, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c20c74e133d4d10b3efccc61e82dea2", async() => {
                BeginContext(3602, 7, true);
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
#line 113 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
                                          WriteLiteral(item.CustomerId);

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
            BeginContext(3613, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3633, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db8cb82b1a584abb99871b442fbdf017", async() => {
                BeginContext(3688, 6, true);
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
#line 114 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
                                         WriteLiteral(item.CustomerId);

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
            BeginContext(3698, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 117 "C:\Users\ariel\OneDrive\Desktop\TravelExpertsWebApplication\TravelExpertsWebApplication\Views\Customers\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3737, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TravelExpertsWebApplication.Models.Customers>> Html { get; private set; }
    }
}
#pragma warning restore 1591
