#pragma checksum "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88c269ad00e9e6f91201fadf0fa0c2a886274cff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88c269ad00e9e6f91201fadf0fa0c2a886274cff", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d7efab58f19600ad899d51e353bef788200d6bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RSAT.Api.Data.ViewModels.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("80px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/employee.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(84, 301, true);
            WriteLiteral(@"<style>
    #Div {
        background-color: red;
    }
</style>
<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""wrapper wrapper-content animated fadeInRight"">

            <div class=""ibox-content m-b-sm border-bottom"">

                <div class=""p-xs"">



                </div>
");
            EndContext();
#line 21 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Home/Index.cshtml"
                  
                    var numberOfColsNeeded = 6;
                    var totalCounter = Model.EmployeeCollection.Count();
                    var itemCounter = 1;
                

#line default
#line hidden
            BeginContext(584, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 26 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Home/Index.cshtml"
                 foreach (var item in Model.EmployeeCollection)
                {
                    {
                        if (itemCounter % numberOfColsNeeded == 1)
                        {

#line default
#line hidden
            BeginContext(781, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(811, 18, true);
            WriteLiteral("<div class=\"row\">\n");
            EndContext();
#line 32 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Home/Index.cshtml"
                            }


#line default
#line hidden
            BeginContext(860, 52, true);
            WriteLiteral("                            <div class=\"col-lg-2\">\n\n");
            EndContext();
#line 36 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Home/Index.cshtml"
                                 if (item.ActualCheckinStatuse != null)
                                {
                                    

#line default
#line hidden
#line 38 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Home/Index.cshtml"
                                     if (item.ActualCheckinStatuse.CheckStatus.Contains("Hyrje"))
                                    {

#line default
#line hidden
            BeginContext(1154, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(1196, 95, true);
            WriteLiteral("<div class=\"contact-box\" style=\"background-color:rgba(63, 191, 63, 0.46);border-radius: 37%;\">\n");
            EndContext();
#line 41 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Home/Index.cshtml"
                                        }

#line default
#line hidden
#line 42 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Home/Index.cshtml"
                                     if (item.ActualCheckinStatuse.CheckStatus.Contains("Dalje"))
                                    {

#line default
#line hidden
            BeginContext(1469, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(1511, 95, true);
            WriteLiteral("<div class=\"contact-box\" style=\"background-color:rgba(219, 81, 81, 0.46);border-radius: 37%;\">\n");
            EndContext();
#line 45 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Home/Index.cshtml"
                                        }

#line default
#line hidden
#line 46 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Home/Index.cshtml"
                                     if (item.ActualCheckinStatuse.CheckStatus.Contains("Takim"))
                                    {

#line default
#line hidden
            BeginContext(1784, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(1826, 96, true);
            WriteLiteral("<div class=\"contact-box\" style=\"background-color:rgba(219, 210, 81, 0.46);border-radius: 37%;\">\n");
            EndContext();
#line 49 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Home/Index.cshtml"
                                        }

#line default
#line hidden
#line 50 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Home/Index.cshtml"
                                     if (item.ActualCheckinStatuse.CheckStatus.Contains("Pauze"))
                                    {

#line default
#line hidden
            BeginContext(2100, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(2142, 96, true);
            WriteLiteral("<div class=\"contact-box\" style=\"background-color:rgba(81, 164, 219, 0.46);border-radius: 37%;\">\n");
            EndContext();
#line 53 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Home/Index.cshtml"
                                        }

#line default
#line hidden
#line 54 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Home/Index.cshtml"
                                     if (item.ActualCheckinStatuse == null)
                                    {

#line default
#line hidden
            BeginContext(2394, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(2436, 77, true);
            WriteLiteral("<div class=\"contact-box\" style=\"background-color:rgba(148, 146, 146, 0.4);\">\n");
            EndContext();
#line 57 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Home/Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(2556, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(2592, 1301, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88c269ad00e9e6f91201fadf0fa0c2a886274cff11279", async() => {
                BeginContext(2644, 131, true);
                WriteLiteral("\n                                        <div class=\"col-4\">\n                                            <div class=\"text-center\">\n");
                EndContext();
#line 62 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Home/Index.cshtml"
                                                 if (item.Picture != null)
                                                {
                                                    var base64 = Convert.ToBase64String(item.Picture);
                                                    var imgSrc = String.Format("data:image/jpg;base64,{0}", base64);


#line default
#line hidden
                BeginContext(3121, 114, true);
                WriteLiteral("                                                    <img alt=\"image\" class=\"img-circle\" width=\"80px\" height=\"80px\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3235, "\"", 3248, 1);
#line 67 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Home/Index.cshtml"
WriteAttributeValue("", 3241, imgSrc, 3241, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3249, 2, true);
                WriteLiteral(">\n");
                EndContext();
#line 68 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Home/Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
                BeginContext(3403, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(3404, 91, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "88c269ad00e9e6f91201fadf0fa0c2a886274cff13279", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
#line 70 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Home/Index.cshtml"
                                                                                                                                             }

#line default
#line hidden
                BeginContext(3497, 278, true);
                WriteLiteral(@"                                            </div>
                                        </div>

                                        <div class=""col-8 text-center"">
                                            <br />
                                            <h3><strong>");
                EndContext();
                BeginContext(3776, 9, false);
#line 76 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Home/Index.cshtml"
                                                   Write(item.Name);

#line default
#line hidden
                EndContext();
                BeginContext(3785, 104, true);
                WriteLiteral("</strong></h3><br />\n                                        </div>\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Home/Index.cshtml"
                                                                  WriteLiteral(item.Id);

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
            BeginContext(3893, 33, true);
            WriteLiteral("\n                                ");
            EndContext();
            BeginContext(3928, 7, true);
            WriteLiteral("</div>\n");
            EndContext();
#line 80 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Home/Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(3965, 35, true);
            WriteLiteral("                            </div>\n");
            EndContext();
#line 82 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Home/Index.cshtml"
                            if ((itemCounter % numberOfColsNeeded == 0) || ((itemCounter) == totalCounter))
                            {

#line default
#line hidden
            BeginContext(4138, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(4168, 7, true);
            WriteLiteral("</div>\n");
            EndContext();
#line 85 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Home/Index.cshtml"
                        }
                        itemCounter++;
                    }
                }

#line default
#line hidden
            BeginContext(4280, 46, true);
            WriteLiteral("            </div>\n        </div>\n    </div>\n\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(4348, 111, true);
                WriteLiteral("\n        <script type=\"text/javascript\">\n            $(document).ready(function () { });\n        </script>\n    ");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RSAT.Api.Data.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
