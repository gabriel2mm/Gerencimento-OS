#pragma checksum "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "398bda855d433117a234396b8fb65b8f69fba9c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
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
#nullable restore
#line 1 "C:\Users\gabri\source\repos\GDR\GDR\Views\_ViewImports.cshtml"
using GDR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gabri\source\repos\GDR\GDR\Views\_ViewImports.cshtml"
using GDR.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"398bda855d433117a234396b8fb65b8f69fba9c4", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8c019d0c725705bb2e7e3f09db2f72ccb8ac556", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GDR.Models.ModelsForViews.LoginViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"" style=""display: flex; width: 100%; flex-direction: row; justify-content: center; align-items: center"">
        <div class=""col-md-4 col-lg-4 col-sm-12 col-xs-4"">
            <div class=""jumbotron"">
                <h1 class=""display-4"">Login</h1>
");
#nullable restore
#line 11 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Login.cshtml"
                 using (Html.BeginForm("Login", "Account", method: FormMethod.Post))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Login.cshtml"
               Write(Html.HiddenFor(model => model.returnUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 15 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Login.cshtml"
                   Write(Html.LabelFor(model => model.Login));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 16 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Login.cshtml"
                   Write(Html.TextBoxFor(model => model.Login, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <span class=\"text-danger\">");
#nullable restore
#line 17 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Login.cshtml"
                                             Write(Html.ValidationMessageFor(model => model.Login));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n");
            WriteLiteral("                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 21 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Login.cshtml"
                   Write(Html.LabelFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 22 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Login.cshtml"
                   Write(Html.PasswordFor(model => model.Password, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <span class=\"text-danger\">");
#nullable restore
#line 23 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Login.cshtml"
                                             Write(Html.ValidationMessageFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n");
            WriteLiteral("                    <div class=\"form-check\">\r\n                        ");
#nullable restore
#line 27 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Login.cshtml"
                   Write(Html.CheckBoxFor(model => model.RememberMe, new { @class = "form-check-input" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <label class=\"form-check-label\">\r\n                            ");
#nullable restore
#line 29 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Login.cshtml"
                       Write(Html.DisplayNameFor(model => model.RememberMe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </label>\r\n                    </div>\r\n                    <button type=\"submit\" class=\"btn btn-dark form-control\">Entrar</button>\r\n");
#nullable restore
#line 33 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Login.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GDR.Models.ModelsForViews.LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591