#pragma checksum "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Account/Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "887dba539c28761708eced19aca4e68464ca2c0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Profile), @"mvc.1.0.view", @"/Views/Account/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Profile.cshtml", typeof(AspNetCore.Views_Account_Profile))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"887dba539c28761708eced19aca4e68464ca2c0a", @"/Views/Account/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d7efab58f19600ad899d51e353bef788200d6bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NovusConsulting.Api.ViewModels.LayoutViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Account/Profile.cshtml"
  
    ViewData["Title"] = "Profile";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(140, 2721, true);
            WriteLiteral(@"
<div class=""wrapper wrapper-content animated fadeIn"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""ibox"">
                <div class=""ibox-content"">
                    <div class=""sk-spinner sk-spinner-circle"">
                        <div class=""sk-circle1 sk-circle""></div>
                        <div class=""sk-circle2 sk-circle""></div>
                        <div class=""sk-circle3 sk-circle""></div>
                        <div class=""sk-circle4 sk-circle""></div>
                        <div class=""sk-circle5 sk-circle""></div>
                        <div class=""sk-circle6 sk-circle""></div>
                        <div class=""sk-circle7 sk-circle""></div>
                        <div class=""sk-circle8 sk-circle""></div>
                        <div class=""sk-circle9 sk-circle""></div>
                        <div class=""sk-circle10 sk-circle""></div>
                        <div class=""sk-circle11 sk-circle""></div>
                        <div class=""sk-circle12 sk-circle""></");
            WriteLiteral(@"div>
                    </div>
                    <div class=""p-xs"">
                        <div class=""pull-left m-r-md"">
                            <i class=""fa fa-user-circle-o text-navy mid-icon""></i>
                        </div>
                        <h2>Profile</h2>
                        <span>Manage your profile</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""ibox"">
                <div class=""ibox-title"">
                    <h5>Options</h5>
                </div>
                <div class=""ibox-content"">
                    <div class=""sk-spinner sk-spinner-circle"">
                        <div class=""sk-circle1 sk-circle""></div>
                        <div class=""sk-circle2 sk-circle""></div>
                        <div class=""sk-circle3 sk-circle""></div>
                        <div class=""sk-circle4 sk-circle""></div>
                        <div class=""sk-");
            WriteLiteral(@"circle5 sk-circle""></div>
                        <div class=""sk-circle6 sk-circle""></div>
                        <div class=""sk-circle7 sk-circle""></div>
                        <div class=""sk-circle8 sk-circle""></div>
                        <div class=""sk-circle9 sk-circle""></div>
                        <div class=""sk-circle10 sk-circle""></div>
                        <div class=""sk-circle11 sk-circle""></div>
                        <div class=""sk-circle12 sk-circle""></div>
                    </div>
                    <div class=""form-group"">
                        <label>#</label>
                        <input id=""txtId"" type=""number"" class=""form-control""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2861, "\"", 2883, 1);
#line 60 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Account/Profile.cshtml"
WriteAttributeValue("", 2869, Model.User.Id, 2869, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2884, 205, true);
            WriteLiteral(" disabled />\n                    </div>\n                    <div class=\"form-group\">\n                        <label>Name</label>\n                        <input id=\"txtName\" type=\"text\" class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3089, "\"", 3113, 1);
#line 64 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Account/Profile.cshtml"
WriteAttributeValue("", 3097, Model.User.Name, 3097, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3114, 202, true);
            WriteLiteral(" />\n                    </div>\n                    <div class=\"form-group\">\n                        <label>Surname</label>\n                        <input id=\"txtSurname\" type=\"text\" class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3316, "\"", 3343, 1);
#line 68 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Account/Profile.cshtml"
WriteAttributeValue("", 3324, Model.User.Surname, 3324, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3344, 199, true);
            WriteLiteral(" />\n                    </div>\n                    <div class=\"form-group\">\n                        <label>Email</label>\n                        <input id=\"txtEmail\" type=\"email\" class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3543, "\"", 3568, 1);
#line 72 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Account/Profile.cshtml"
WriteAttributeValue("", 3551, Model.User.Email, 3551, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3569, 204, true);
            WriteLiteral(" />\n                    </div>\n                    <div class=\"form-group\">\n                        <label>Username</label>\n                        <input id=\"txtUsername\" type=\"text\" class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3773, "\"", 3801, 1);
#line 76 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Account/Profile.cshtml"
WriteAttributeValue("", 3781, Model.User.Username, 3781, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3802, 880, true);
            WriteLiteral(@" disabled />
                    </div>
                    <div class=""form-group"">
                        <label>Password</label>
                        <input id=""txtPassword"" type=""password"" class=""form-control"" value="""" />
                    </div>
                    <div class=""form-group"">
                        <label>Confirm Password</label>
                        <input id=""txtConfirmPassword"" type=""password"" class=""form-control"" value="""" />
                    </div>
                </div>
                <div class=""ibox-footer"">
                    <button type=""button"" class=""btn btn-white"" onclick=""home();""><i class=""fa fa-home""></i> Home</button>
                    <button type=""button"" class=""btn btn-white"" onclick=""saveUser();""><i class=""fa fa-save""></i> Save</button>
                </div>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(4700, 94, true);
                WriteLiteral("\n    <script type=\"text/javascript\">\n        function home() {\n            window.location = \'");
                EndContext();
                BeginContext(4795, 27, false);
#line 99 "/Users/Endrit/Desktop/RSAT/wetransfer-12416b/RSAT/RSAT.Api/Views/Account/Profile.cshtml"
                          Write(Url.Action("Index", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(4822, 3010, true);
                WriteLiteral(@"';
        }
        function saveUser() {
            if ($(""#txtName"").val().trim().length == 0) {
                swal(""Information"", ""Name is required."", ""info"");
                $(""#txtName"").focus();
                return;
            }
            if ($(""#txtSurname"").val().trim().length == 0) {
                swal(""Information"", ""Surname is required."", ""info"");
                $(""#txtSurname"").focus();
                return;
            }
            if ($(""#txtEmail"").val().trim().length == 0) {
                swal(""Information"", ""Email is required."", ""info"");
                $(""#txtEmail"").focus();
                return;
            }
            if ($(""#txtUsername"").val().trim().length == 0) {
                swal(""Information"", ""Username is required."", ""info"");
                $(""#txtUsername"").focus();
                return;
            }
            if ($(""#txtPassword"").val().trim().length == 0) {
                swal(""Information"", ""Password is required."", ""info"");
                $(""#t");
                WriteLiteral(@"xtPassword"").focus();
                return;
            }
            if ($(""#txtConfirmPassword"").val().trim().length == 0) {
                swal(""Information"", ""Confirmation password is required."", ""info"");
                $(""#txtConfirmPassword"").focus();
                return;
            }
            if ($(""#txtPassword"").val() != $(""#txtConfirmPassword"").val()) {
                swal(""Information"", ""Passwords must match."", ""info"");
                $(""#txtPassword"").focus();
                return;
            }
            var id = 0;
            if ($(""#txtId"").val().trim().length > 0) {
                id = parseInt($(""#txtId"").val());
            }
            var profile =
                {
                    Name: $(""#txtName"").val(),
                    Surname: $(""#txtSurname"").val(),
                    Email: $(""#txtEmail"").val(),
                    Password: $(""#txtPassword"").val(),
                };
            $.ajax({
                url: ACCOUNT_PROFILE_URL,
                type: """);
                WriteLiteral(@"POST"",
                dataType: 'json',
                contentType: 'application/json',
                data: JSON.stringify(profile),
                statusCode: {
                    200: function () {
                        swal(""Success"", ""Profile saved successfully."", ""success"");
                    },
                    400: function (data) {
                        swal(""Error"", ""Bad request error (HTTP 400)."", ""error"");
                    },
                    401: function () {
                        swal(""Error"", ""Unauthorized error (HTTP 401)"", ""error"");
                    },
                    500: function (data) {
                        swal(""Error"", ""Internal server error (HTTP 500)"", ""error"");
                    }
                },
                error: function (request, status, error) {
                    swal(""Error"", request.status + "": "" + error, ""error"");
                }
            });
        }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NovusConsulting.Api.ViewModels.LayoutViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
