#pragma checksum "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90e6f26a3675cbe9a34412e1c071d003944c442e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Details), @"mvc.1.0.view", @"/Views/Customers/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customers/Details.cshtml", typeof(AspNetCore.Views_Customers_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90e6f26a3675cbe9a34412e1c071d003944c442e", @"/Views/Customers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64a7dc529f31657fa3adec2076b311a2819c11e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TravelExpertsWeb.Models.Customers>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(87, 132, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Customers</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(220, 49, false);
#line 14 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustFirstName));

#line default
#line hidden
            EndContext();
            BeginContext(269, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(333, 45, false);
#line 17 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustFirstName));

#line default
#line hidden
            EndContext();
            BeginContext(378, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(441, 48, false);
#line 20 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustLastName));

#line default
#line hidden
            EndContext();
            BeginContext(489, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(553, 44, false);
#line 23 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustLastName));

#line default
#line hidden
            EndContext();
            BeginContext(597, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(660, 47, false);
#line 26 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustAddress));

#line default
#line hidden
            EndContext();
            BeginContext(707, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(771, 43, false);
#line 29 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustAddress));

#line default
#line hidden
            EndContext();
            BeginContext(814, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(877, 44, false);
#line 32 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustCity));

#line default
#line hidden
            EndContext();
            BeginContext(921, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(985, 40, false);
#line 35 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustCity));

#line default
#line hidden
            EndContext();
            BeginContext(1025, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1088, 44, false);
#line 38 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustProv));

#line default
#line hidden
            EndContext();
            BeginContext(1132, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1196, 40, false);
#line 41 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustProv));

#line default
#line hidden
            EndContext();
            BeginContext(1236, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1299, 46, false);
#line 44 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustPostal));

#line default
#line hidden
            EndContext();
            BeginContext(1345, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1409, 42, false);
#line 47 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustPostal));

#line default
#line hidden
            EndContext();
            BeginContext(1451, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1514, 47, false);
#line 50 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustCountry));

#line default
#line hidden
            EndContext();
            BeginContext(1561, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1625, 43, false);
#line 53 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustCountry));

#line default
#line hidden
            EndContext();
            BeginContext(1668, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1731, 49, false);
#line 56 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustHomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(1780, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1844, 45, false);
#line 59 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustHomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(1889, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1952, 48, false);
#line 62 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustBusPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2000, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2064, 44, false);
#line 65 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustBusPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2108, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2171, 45, false);
#line 68 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustEmail));

#line default
#line hidden
            EndContext();
            BeginContext(2216, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2280, 41, false);
#line 71 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustEmail));

#line default
#line hidden
            EndContext();
            BeginContext(2321, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2384, 43, false);
#line 74 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AgentId));

#line default
#line hidden
            EndContext();
            BeginContext(2427, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2491, 39, false);
#line 77 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.AgentId));

#line default
#line hidden
            EndContext();
            BeginContext(2530, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2593, 53, false);
#line 80 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PasswordNotHashed));

#line default
#line hidden
            EndContext();
            BeginContext(2646, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2710, 49, false);
#line 83 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.PasswordNotHashed));

#line default
#line hidden
            EndContext();
            BeginContext(2759, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2822, 50, false);
#line 86 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PasswordHashed));

#line default
#line hidden
            EndContext();
            BeginContext(2872, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2936, 46, false);
#line 89 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.PasswordHashed));

#line default
#line hidden
            EndContext();
            BeginContext(2982, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3045, 48, false);
#line 92 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PasswordSalt));

#line default
#line hidden
            EndContext();
            BeginContext(3093, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3157, 44, false);
#line 95 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.PasswordSalt));

#line default
#line hidden
            EndContext();
            BeginContext(3201, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3248, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90e6f26a3675cbe9a34412e1c071d003944c442e17065", async() => {
                BeginContext(3302, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 100 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Customers\Details.cshtml"
                           WriteLiteral(Model.CustomerId);

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
            BeginContext(3310, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3318, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90e6f26a3675cbe9a34412e1c071d003944c442e19423", async() => {
                BeginContext(3340, 12, true);
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
            BeginContext(3356, 10, true);
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
