#pragma checksum "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Shared/_Footer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c2cbf65c3a3833ba050b15143487c5c87008c61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Footer), @"mvc.1.0.view", @"/Views/Shared/_Footer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Footer.cshtml", typeof(AspNetCore.Views_Shared__Footer))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c2cbf65c3a3833ba050b15143487c5c87008c61", @"/Views/Shared/_Footer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d7efab58f19600ad899d51e353bef788200d6bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Footer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NovusConsulting.Api.ViewModels.LayoutViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 58, true);
            WriteLiteral("<div class=\"footer\">\n    <div class=\"pull-right\">\n        ");
            EndContext();
            BeginContext(113, 19, false);
#line 4 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Shared/_Footer.cshtml"
   Write(Model.User.Username);

#line default
#line hidden
            EndContext();
            BeginContext(132, 56, true);
            WriteLiteral("\n    </div>\n    <div>\n        Novus Consulting <small>© ");
            EndContext();
            BeginContext(189, 17, false);
#line 7 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Shared/_Footer.cshtml"
                             Write(DateTime.Now.Year);

#line default
#line hidden
            EndContext();
            BeginContext(206, 27, true);
            WriteLiteral("</small>\n    </div>\n</div>\n");
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
