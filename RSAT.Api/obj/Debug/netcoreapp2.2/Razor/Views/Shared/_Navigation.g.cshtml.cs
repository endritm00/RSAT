#pragma checksum "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Shared/_Navigation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07641eb90f12b1790656b3f8ba963871b925008b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Navigation), @"mvc.1.0.view", @"/Views/Shared/_Navigation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Navigation.cshtml", typeof(AspNetCore.Views_Shared__Navigation))]
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
#line 1 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/_ViewImports.cshtml"
using RSAT.Api;

#line default
#line hidden
#line 2 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/_ViewImports.cshtml"
using RSAT.Api.Data.Models;

#line default
#line hidden
#line 2 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Shared/_Navigation.cshtml"
using RSAT.Api.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07641eb90f12b1790656b3f8ba963871b925008b", @"/Views/Shared/_Navigation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d7efab58f19600ad899d51e353bef788200d6bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Navigation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NovusConsulting.Api.ViewModels.LayoutViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("180"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(78, 283, true);
            WriteLiteral(@"<nav class=""navbar-default navbar-static-side"" role=""navigation"">
    <div class=""sidebar-collapse"">
        <ul class=""nav"" id=""side-menu"">
            <li class=""nav-header"">
                <div class=""dropdown profile-element"">
                    <span>
                        ");
            EndContext();
            BeginContext(361, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "07641eb90f12b1790656b3f8ba963871b925008b5078", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(428, 221, true);
            WriteLiteral("\n                    </span>\n                    <a data-toggle=\"dropdown\" class=\"dropdown-toggle\" href=\"#\">\n                        <span class=\"clear\">\n                            <span class=\"text-muted text-xs block\">");
            EndContext();
            BeginContext(651, 19, false);
#line 13 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Shared/_Navigation.cshtml"
                                                               Write(Model.User.Username);

#line default
#line hidden
            EndContext();
            BeginContext(671, 221, true);
            WriteLiteral(" <b class=\"caret\"></b></span>\n                        </span>\n                    </a>\n                    <ul class=\"dropdown-menu animated fadeInRight m-t-xs\">\n                        <li>\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 892, "\'", 932, 1);
#line 18 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Shared/_Navigation.cshtml"
WriteAttributeValue("", 899, Url.Action("Profile", "Account"), 899, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(933, 223, true);
            WriteLiteral(">Profile</a>\n                        </li>\n                    </ul>\n                </div>\n                <div class=\"logo-element\">\n                    <p>RSAT</p>\n                </div>\n            </li>\n            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1156, "\"", 1205, 1);
#line 26 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Shared/_Navigation.cshtml"
WriteAttributeValue("", 1164, Html.IsSelected(controller: "Dashboard"), 1164, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1206, 156, true);
            WriteLiteral(">\n                <a href=\"#\"><i class=\"fa fa-dashboard\"></i> <span class=\"nav-label\">Dashboard</span><span class=\"fa arrow\"></span></a>\n                <ul");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1362, "\"", 1457, 4);
            WriteAttributeValue("", 1370, "nav", 1370, 3, true);
            WriteAttributeValue(" ", 1373, "nav-second-level", 1374, 17, true);
            WriteAttributeValue(" ", 1390, "collapse", 1391, 9, true);
#line 28 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Shared/_Navigation.cshtml"
WriteAttributeValue(" ", 1399, Html.IsSelected(controller: "Dashboard", cssClass: "in"), 1400, 57, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1458, 25, true);
            WriteLiteral(">\n                    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1483, "\"", 1525, 1);
#line 29 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Shared/_Navigation.cshtml"
WriteAttributeValue("", 1491, Html.IsSelected(action : "Index"), 1491, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1526, 3, true);
            WriteLiteral("><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1529, "\"", 1569, 1);
#line 29 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Shared/_Navigation.cshtml"
WriteAttributeValue("", 1536, Url.Action("Index" ,"Dashboard"), 1536, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1570, 75, true);
            WriteLiteral(">Dashboard</a></li>\n                </ul>\n            </li>\n            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1645, "\"", 1690, 1);
#line 32 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Shared/_Navigation.cshtml"
WriteAttributeValue("", 1653, Html.IsSelected(controller: "Home" ), 1653, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1691, 147, true);
            WriteLiteral(">\n                <a href=\"#\"><i class=\"fa fa-users\"></i> <span class=\"nav-label\">Home</span><span class=\"fa arrow\"></span></a>\n                <ul");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1838, "\"", 1928, 4);
            WriteAttributeValue("", 1846, "nav", 1846, 3, true);
            WriteAttributeValue(" ", 1849, "nav-second-level", 1850, 17, true);
            WriteAttributeValue(" ", 1866, "collapse", 1867, 9, true);
#line 34 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Shared/_Navigation.cshtml"
WriteAttributeValue(" ", 1875, Html.IsSelected(controller: "Home", cssClass: "in"), 1876, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1929, 25, true);
            WriteLiteral(">\n                    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1954, "\"", 1995, 1);
#line 35 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Shared/_Navigation.cshtml"
WriteAttributeValue("", 1962, Html.IsSelected(action: "Index"), 1962, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1996, 3, true);
            WriteLiteral("><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1999, "\"", 2034, 1);
#line 35 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Shared/_Navigation.cshtml"
WriteAttributeValue("", 2006, Url.Action("Index", "Home"), 2006, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2035, 43, true);
            WriteLiteral(">Employees</a></li>\n                    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2078, "\"", 2119, 1);
#line 36 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Shared/_Navigation.cshtml"
WriteAttributeValue("", 2086, Html.IsSelected(action: "About"), 2086, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2120, 3, true);
            WriteLiteral("><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2123, "\"", 2158, 1);
#line 36 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Shared/_Navigation.cshtml"
WriteAttributeValue("", 2130, Url.Action("About", "Home"), 2130, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2159, 39, true);
            WriteLiteral(">About</a></li>\n                    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2198, "\"", 2241, 1);
#line 37 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Shared/_Navigation.cshtml"
WriteAttributeValue("", 2206, Html.IsSelected(action: "Contact"), 2206, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2242, 3, true);
            WriteLiteral("><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2245, "\"", 2282, 1);
#line 37 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Shared/_Navigation.cshtml"
WriteAttributeValue("", 2252, Url.Action("Contact", "Home"), 2252, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2283, 73, true);
            WriteLiteral(">Contact</a></li>\n                </ul>\n            </li>\n            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2356, "\"", 2403, 1);
#line 40 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Shared/_Navigation.cshtml"
WriteAttributeValue("", 2364, Html.IsSelected(controller: "Account"), 2364, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2404, 158, true);
            WriteLiteral(">\n                <a href=\"#\"><i class=\"fa fa-user-circle-o\"></i> <span class=\"nav-label\">Profile</span><span class=\"fa arrow\"></span></a>\n                <ul");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2562, "\"", 2655, 4);
            WriteAttributeValue("", 2570, "nav", 2570, 3, true);
            WriteAttributeValue(" ", 2573, "nav-second-level", 2574, 17, true);
            WriteAttributeValue(" ", 2590, "collapse", 2591, 9, true);
#line 42 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Shared/_Navigation.cshtml"
WriteAttributeValue(" ", 2599, Html.IsSelected(controller: "Profile", cssClass: "in"), 2600, 55, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2656, 25, true);
            WriteLiteral(">\n                    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2681, "\"", 2722, 1);
#line 43 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Shared/_Navigation.cshtml"
WriteAttributeValue("", 2689, Html.IsSelected(action: "Index"), 2689, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2723, 3, true);
            WriteLiteral("><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2726, "\"", 2766, 1);
#line 43 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Shared/_Navigation.cshtml"
WriteAttributeValue("", 2733, Url.Action("Profile", "Account"), 2733, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2767, 73, true);
            WriteLiteral(">Profile</a></li>\n                </ul>\n            </li>\n            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2840, "\"", 2891, 1);
#line 46 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Shared/_Navigation.cshtml"
WriteAttributeValue("", 2848, Html.IsSelected(controller: "NewEmployee"), 2848, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2892, 154, true);
            WriteLiteral(">\n                <a href=\"#\"><i class=\"fa fa-edit\"></i> <span class=\"nav-label\">Add Employee</span><span class=\"fa arrow\"></span></a>\n                <ul");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3046, "\"", 3143, 4);
            WriteAttributeValue("", 3054, "nav", 3054, 3, true);
            WriteAttributeValue(" ", 3057, "nav-second-level", 3058, 17, true);
            WriteAttributeValue(" ", 3074, "collapse", 3075, 9, true);
#line 48 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Shared/_Navigation.cshtml"
WriteAttributeValue(" ", 3083, Html.IsSelected(controller: "NewEmployee", cssClass: "in"), 3084, 59, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3144, 25, true);
            WriteLiteral(">\n                    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3169, "\"", 3211, 1);
#line 49 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Shared/_Navigation.cshtml"
WriteAttributeValue("", 3177, Html.IsSelected(action : "Index"), 3177, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3212, 3, true);
            WriteLiteral("><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3215, "\"", 3257, 1);
#line 49 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Shared/_Navigation.cshtml"
WriteAttributeValue("", 3222, Url.Action("Index" ,"NewEmployee"), 3222, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3258, 78, true);
            WriteLiteral(">Add Employee</a></li>\n                </ul>\n            </li>\n            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3336, "\"", 3381, 1);
#line 52 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Shared/_Navigation.cshtml"
WriteAttributeValue("", 3344, Html.IsSelected(controller: "Chart"), 3344, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3382, 165, true);
            WriteLiteral(">\n                <a href=\"#\"><i class=\"fa fa-area-chart\"></i> <span class=\"nav-label\">Statistika mujore</span><span class=\"fa arrow\"></span></a>\n                <ul");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3547, "\"", 3638, 4);
            WriteAttributeValue("", 3555, "nav", 3555, 3, true);
            WriteAttributeValue(" ", 3558, "nav-second-level", 3559, 17, true);
            WriteAttributeValue(" ", 3575, "collapse", 3576, 9, true);
#line 54 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Shared/_Navigation.cshtml"
WriteAttributeValue(" ", 3584, Html.IsSelected(controller: "Chart", cssClass: "in"), 3585, 53, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3639, 25, true);
            WriteLiteral(">\n                    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3664, "\"", 3706, 1);
#line 55 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Shared/_Navigation.cshtml"
WriteAttributeValue("", 3672, Html.IsSelected(action : "Index"), 3672, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3707, 3, true);
            WriteLiteral("><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3710, "\"", 3746, 1);
#line 55 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Shared/_Navigation.cshtml"
WriteAttributeValue("", 3717, Url.Action("Index" ,"Chart"), 3717, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3747, 92, true);
            WriteLiteral(">Statistika</a></li>\n                </ul>\n            </li>\n        </ul>\n    </div>\n</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NovusConsulting.Api.ViewModels.LayoutViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
