#pragma checksum "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Bookings\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf553e3e465929f22b0288c3e8aa6ae5dbdeffda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bookings_Details), @"mvc.1.0.view", @"/Views/Bookings/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bookings/Details.cshtml", typeof(AspNetCore.Views_Bookings_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf553e3e465929f22b0288c3e8aa6ae5dbdeffda", @"/Views/Bookings/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64a7dc529f31657fa3adec2076b311a2819c11e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Bookings_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TravelExpertsWeb.Models.Bookings>
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
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Bookings\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(86, 131, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Bookings</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(218, 47, false);
#line 14 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Bookings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BookingDate));

#line default
#line hidden
            EndContext();
            BeginContext(265, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(329, 43, false);
#line 17 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Bookings\Details.cshtml"
       Write(Html.DisplayFor(model => model.BookingDate));

#line default
#line hidden
            EndContext();
            BeginContext(372, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(435, 45, false);
#line 20 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Bookings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BookingNo));

#line default
#line hidden
            EndContext();
            BeginContext(480, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(544, 41, false);
#line 23 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Bookings\Details.cshtml"
       Write(Html.DisplayFor(model => model.BookingNo));

#line default
#line hidden
            EndContext();
            BeginContext(585, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(648, 49, false);
#line 26 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Bookings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TravelerCount));

#line default
#line hidden
            EndContext();
            BeginContext(697, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(761, 45, false);
#line 29 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Bookings\Details.cshtml"
       Write(Html.DisplayFor(model => model.TravelerCount));

#line default
#line hidden
            EndContext();
            BeginContext(806, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(869, 46, false);
#line 32 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Bookings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerId));

#line default
#line hidden
            EndContext();
            BeginContext(915, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(979, 42, false);
#line 35 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Bookings\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerId));

#line default
#line hidden
            EndContext();
            BeginContext(1021, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1084, 46, false);
#line 38 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Bookings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TripTypeId));

#line default
#line hidden
            EndContext();
            BeginContext(1130, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1194, 42, false);
#line 41 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Bookings\Details.cshtml"
       Write(Html.DisplayFor(model => model.TripTypeId));

#line default
#line hidden
            EndContext();
            BeginContext(1236, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1299, 45, false);
#line 44 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Bookings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PackageId));

#line default
#line hidden
            EndContext();
            BeginContext(1344, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1408, 41, false);
#line 47 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Bookings\Details.cshtml"
       Write(Html.DisplayFor(model => model.PackageId));

#line default
#line hidden
            EndContext();
            BeginContext(1449, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1496, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf553e3e465929f22b0288c3e8aa6ae5dbdeffda9757", async() => {
                BeginContext(1549, 4, true);
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
#line 52 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Bookings\Details.cshtml"
                           WriteLiteral(Model.BookingId);

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
            BeginContext(1557, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1565, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf553e3e465929f22b0288c3e8aa6ae5dbdeffda12111", async() => {
                BeginContext(1587, 12, true);
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
            BeginContext(1603, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TravelExpertsWeb.Models.Bookings> Html { get; private set; }
    }
}
#pragma warning restore 1591
