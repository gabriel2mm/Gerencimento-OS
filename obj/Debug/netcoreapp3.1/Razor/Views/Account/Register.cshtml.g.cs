#pragma checksum "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6e11849e3f2ce669c8ed4beb910b3aa6d4f0f03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6e11849e3f2ce669c8ed4beb910b3aa6d4f0f03", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8c019d0c725705bb2e7e3f09db2f72ccb8ac556", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GDR.Models.ModelsForViews.RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Register.cshtml"
  
    ViewData["Title"] = "Registrar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"jumbotron\">\r\n    <h1 class=\"display-4\"> Adicionar usuário</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Register.cshtml"
     if (ViewData != null && ViewData["error"] != null && !String.IsNullOrEmpty(ViewData["error"].ToString()))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-danger alert-dismissible fade show\" role=\"alert\">\r\n            <span>");
#nullable restore
#line 12 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Register.cshtml"
             Write(ViewData["error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n                <span aria-hidden=\"true\">&times;</span>\r\n            </button>\r\n        </div>\r\n");
#nullable restore
#line 17 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Register.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Register.cshtml"
     using (Html.BeginForm("Register", "Account", method: FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 22 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Register.cshtml"
       Write(Html.LabelFor(model => model.First_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 23 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Register.cshtml"
       Write(Html.TextBoxFor(model => model.First_Name, null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <span class=\"text-danger\">");
#nullable restore
#line 24 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Register.cshtml"
                                 Write(Html.ValidationMessageFor(model => model.First_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 27 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Register.cshtml"
       Write(Html.LabelFor(model => model.Last_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 28 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Register.cshtml"
       Write(Html.TextBoxFor(model => model.Last_name, null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <span class=\"text-danger\">");
#nullable restore
#line 29 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Register.cshtml"
                                 Write(Html.ValidationMessageFor(model => model.Last_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 32 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Register.cshtml"
       Write(Html.LabelFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 33 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Register.cshtml"
       Write(Html.TextBoxFor(model => model.Email, null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <span class=\"text-danger\">");
#nullable restore
#line 34 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Register.cshtml"
                                 Write(Html.ValidationMessageFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 37 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Register.cshtml"
       Write(Html.LabelFor(model => model.Login));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 38 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Register.cshtml"
       Write(Html.TextBoxFor(model => model.Login, null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <span class=\"text-danger\">");
#nullable restore
#line 39 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Register.cshtml"
                                 Write(Html.ValidationMessageFor(model => model.Login));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 42 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Register.cshtml"
       Write(Html.LabelFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 43 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Register.cshtml"
       Write(Html.PasswordFor(model => model.Password, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <span class=\"text-danger\">");
#nullable restore
#line 44 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Register.cshtml"
                                 Write(Html.ValidationMessageFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 47 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Register.cshtml"
       Write(Html.LabelFor(model => model.PasswordConfirm));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 48 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Register.cshtml"
       Write(Html.PasswordFor(model => model.PasswordConfirm, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <span class=\"text-danger\">");
#nullable restore
#line 49 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Register.cshtml"
                                 Write(Html.ValidationMessageFor(model => model.PasswordConfirm));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"form-group\">\r\n            <button type=\"submit\" class=\"btn btn-dark form-control\">Adicionar</button>\r\n        </div>\r\n");
#nullable restore
#line 55 "C:\Users\gabri\source\repos\GDR\GDR\Views\Account\Register.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GDR.Models.ModelsForViews.RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591