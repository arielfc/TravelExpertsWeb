#pragma checksum "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "659a84078cbd76189062570963ef34093e355b7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Delete), @"mvc.1.0.view", @"/Views/Customers/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customers/Delete.cshtml", typeof(AspNetCore.Views_Customers_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"659a84078cbd76189062570963ef34093e355b7f", @"/Views/Customers/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64a7dc529f31657fa3adec2076b311a2819c11e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TravelExpertsWeb.Models.Customers>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(86, 179, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Customers</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(266, 49, false);
#line 15 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CustFirstName));

#line default
#line hidden
            EndContext();
            BeginContext(315, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(379, 45, false);
#line 18 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CustFirstName));

#line default
#line hidden
            EndContext();
            BeginContext(424, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(487, 48, false);
#line 21 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CustLastName));

#line default
#line hidden
            EndContext();
            BeginContext(535, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(599, 44, false);
#line 24 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CustLastName));

#line default
#line hidden
            EndContext();
            BeginContext(643, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(706, 47, false);
#line 27 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CustAddress));

#line default
#line hidden
            EndContext();
            BeginContext(753, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(817, 43, false);
#line 30 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CustAddress));

#line default
#line hidden
            EndContext();
            BeginContext(860, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(923, 44, false);
#line 33 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CustCity));

#line default
#line hidden
            EndContext();
            BeginContext(967, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1031, 40, false);
#line 36 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CustCity));

#line default
#line hidden
            EndContext();
            BeginContext(1071, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1134, 44, false);
#line 39 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CustProv));

#line default
#line hidden
            EndContext();
            BeginContext(1178, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1242, 40, false);
#line 42 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CustProv));

#line default
#line hidden
            EndContext();
            BeginContext(1282, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1345, 46, false);
#line 45 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CustPostal));

#line default
#line hidden
            EndContext();
            BeginContext(1391, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1455, 42, false);
#line 48 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CustPostal));

#line default
#line hidden
            EndContext();
            BeginContext(1497, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1560, 47, false);
#line 51 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CustCountry));

#line default
#line hidden
            EndContext();
            BeginContext(1607, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1671, 43, false);
#line 54 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CustCountry));

#line default
#line hidden
            EndContext();
            BeginContext(1714, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1777, 49, false);
#line 57 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CustHomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(1826, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1890, 45, false);
#line 60 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CustHomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(1935, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1998, 48, false);
#line 63 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CustBusPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2046, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2110, 44, false);
#line 66 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CustBusPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2154, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2217, 45, false);
#line 69 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CustEmail));

#line default
#line hidden
            EndContext();
            BeginContext(2262, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2326, 41, false);
#line 72 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CustEmail));

#line default
#line hidden
            EndContext();
            BeginContext(2367, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2430, 43, false);
#line 75 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AgentId));

#line default
#line hidden
            EndContext();
            BeginContext(2473, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2537, 39, false);
#line 78 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AgentId));

#line default
#line hidden
            EndContext();
            BeginContext(2576, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2639, 53, false);
#line 81 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PasswordNotHashed));

#line default
#line hidden
            EndContext();
            BeginContext(2692, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2756, 49, false);
#line 84 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PasswordNotHashed));

#line default
#line hidden
            EndContext();
            BeginContext(2805, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2868, 50, false);
#line 87 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PasswordHashed));

#line default
#line hidden
            EndContext();
            BeginContext(2918, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2982, 46, false);
#line 90 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PasswordHashed));

#line default
#line hidden
            EndContext();
            BeginContext(3028, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3091, 48, false);
#line 93 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PasswordSalt));

#line default
#line hidden
            EndContext();
            BeginContext(3139, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3203, 44, false);
#line 96 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PasswordSalt));

#line default
#line hidden
            EndContext();
            BeginContext(3247, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(3285, 214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "659a84078cbd76189062570963ef34093e355b7f17777", async() => {
                BeginContext(3311, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3321, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "659a84078cbd76189062570963ef34093e355b7f18170", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 101 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3365, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(3448, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "659a84078cbd76189062570963ef34093e355b7f20111", async() => {
                    BeginContext(3470, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3486, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3499, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TravelExpertsWeb.Models.Customers> Html { get; private set; }
    }
}
#pragma warning restore 1591