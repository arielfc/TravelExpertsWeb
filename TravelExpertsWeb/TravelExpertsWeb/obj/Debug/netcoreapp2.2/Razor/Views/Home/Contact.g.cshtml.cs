#pragma checksum "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "398167e6ca9cbf25174c089c04a90ccc5a1fce82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"398167e6ca9cbf25174c089c04a90ccc5a1fce82", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64a7dc529f31657fa3adec2076b311a2819c11e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TravelExpertsWeb.Models.Agencies>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(99, 863, true);
            WriteLiteral(@"
<div class=""hero-wrap js-fullheight"" style=""background-image: url('../images/sandybeach.jpg');"">
    <div class=""overlay""></div>
    <div class=""container"">
        <div class=""row no-gutters slider-text js-fullheight align-items-center justify-content-center"" data-scrollax-parent=""true"">
            <div class=""col-md-9 ftco-animate text-center"" data-scrollax="" properties: { translateY: '70%' }"">
                <p class=""breadcrumbs"" data-scrollax=""properties: { translateY: '30%', opacity: 1.6 }""><span class=""mr-2""><a href=""index.html"">Home</a></span> <span>Contact</span></p>
                <h1 class=""mb-3 bread"" data-scrollax=""properties: { translateY: '30%', opacity: 1.6 }"">Contact Us</h1>
            </div>
        </div>
    </div>
</div>

<section class=""ftco-section contact-section ftco-degree-bg"">
    <div class=""container"">
");
            EndContext();
#line 21 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Home\Contact.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1011, 137, true);
            WriteLiteral("            <div class=\"row d-flex mb-5 contact-info\">\r\n                <div class=\"col-md-12 mb-4\">\r\n                    <h2 class=\"h4\">");
            EndContext();
            BeginContext(1149, 44, false);
#line 25 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Home\Contact.cshtml"
                              Write(Html.DisplayFor(modelItem => item.AgncyCity));

#line default
#line hidden
            EndContext();
            BeginContext(1193, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1196, 44, false);
#line 25 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Home\Contact.cshtml"
                                                                             Write(Html.DisplayFor(modelItem => item.AgncyProv));

#line default
#line hidden
            EndContext();
            BeginContext(1240, 160, true);
            WriteLiteral(" </h2>\r\n                </div>\r\n                <div class=\"w-100\"></div>\r\n                <div class=\"col-md-3\">\r\n                    <p><span>Address:</span> ");
            EndContext();
            BeginContext(1401, 47, false);
#line 29 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Home\Contact.cshtml"
                                        Write(Html.DisplayFor(modelItem => item.AgncyAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1448, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1451, 46, false);
#line 29 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Home\Contact.cshtml"
                                                                                          Write(Html.DisplayFor(modelItem => item.AgncyPostal));

#line default
#line hidden
            EndContext();
            BeginContext(1497, 142, true);
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"col-md-3\">\r\n                    <p><span>Phone:</span> <a href=\"tel://1234567920\">+ ");
            EndContext();
            BeginContext(1640, 45, false);
#line 32 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Home\Contact.cshtml"
                                                                   Write(Html.DisplayFor(modelItem => item.AgncyPhone));

#line default
#line hidden
            EndContext();
            BeginContext(1685, 213, true);
            WriteLiteral("</a></p>\r\n                </div>\r\n                <div class=\"col-md-3\">\r\n                    <p><span>Email:</span> <a href=\"mailto:info@travelexperts.com\">info@travelexperts.com</a></p>\r\n                </div>\r\n");
            EndContext();
            BeginContext(2044, 20, true);
            WriteLiteral("            </div>\r\n");
            EndContext();
#line 41 "C:\Users\ariel\Documents\TravelExpertsWeb\TravelExpertsWeb\TravelExpertsWeb\Views\Home\Contact.cshtml"
        }

#line default
#line hidden
            BeginContext(2075, 107, true);
            WriteLiteral("            <div class=\"row block-9\">\r\n                <div class=\"col-md-6 pr-md-5\">\r\n                    ");
            EndContext();
            BeginContext(2182, 970, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "398167e6ca9cbf25174c089c04a90ccc5a1fce828631", async() => {
                BeginContext(2199, 946, true);
                WriteLiteral(@"
                        <div class=""form-group"">
                            <input type=""text"" class=""form-control"" placeholder=""Your Name"">
                        </div>
                        <div class=""form-group"">
                            <input type=""text"" class=""form-control"" placeholder=""Your Email"">
                        </div>
                        <div class=""form-group"">
                            <input type=""text"" class=""form-control"" placeholder=""Subject"">
                        </div>
                        <div class=""form-group"">
                            <textarea name="""" id="""" cols=""30"" rows=""7"" class=""form-control"" placeholder=""Message""></textarea>
                        </div>
                        <div class=""form-group"">
                            <input type=""submit"" value=""Send Message"" class=""btn btn-primary py-3 px-5"">
                        </div>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3152, 131, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-6\" id=\"map\"></div>\r\n            </div>\r\n        </div>\r\n</section>\r\n\r\n");
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
