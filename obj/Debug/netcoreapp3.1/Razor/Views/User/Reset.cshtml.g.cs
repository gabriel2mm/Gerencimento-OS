#pragma checksum "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Reset.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53726dc29d2b59092ce047899af8812a4213e708"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Reset), @"mvc.1.0.view", @"/Views/User/Reset.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Reset.cshtml", typeof(AspNetCore.Views_User_Reset))]
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
#line 1 "C:\Users\gabri\source\repos\GDR\GDR\Views\_ViewImports.cshtml"
using GDR;

#line default
#line hidden
#line 2 "C:\Users\gabri\source\repos\GDR\GDR\Views\_ViewImports.cshtml"
using GDR.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53726dc29d2b59092ce047899af8812a4213e708", @"/Views/User/Reset.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8c019d0c725705bb2e7e3f09db2f72ccb8ac556", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Reset : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GDR.Models.ModelsForViews.ResetPassword>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Reset.cshtml"
  
    ViewData["Title"] = "Reset";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(136, 74, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h3 class=\"display-3\">Trocar senha</h3>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Reset.cshtml"
     if (ViewBag.resetError != null)
    {

#line default
#line hidden
            BeginContext(255, 117, true);
            WriteLiteral("        <div class=\"alert alert-danger alert-dismissible fade show\" role=\"alert\">\r\n            <strong>Ops!</strong> ");
            EndContext();
            BeginContext(373, 18, false);
#line 13 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Reset.cshtml"
                             Write(ViewBag.resetError);

#line default
#line hidden
            EndContext();
            BeginContext(391, 188, true);
            WriteLiteral("\r\n            <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n                <span aria-hidden=\"true\">&times;</span>\r\n            </button>\r\n        </div>\r\n");
            EndContext();
#line 18 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Reset.cshtml"
    }

#line default
#line hidden
            BeginContext(586, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 21 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Reset.cshtml"
     using (Html.BeginForm(FormMethod.Post))
    {
        

#line default
#line hidden
            BeginContext(652, 23, false);
#line 23 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Reset.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(686, 33, false);
#line 24 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Reset.cshtml"
   Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(721, 46, true);
            WriteLiteral("        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(768, 45, false);
#line 26 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Reset.cshtml"
       Write(Html.LabelFor(model => model.CurrentPassword));

#line default
#line hidden
            EndContext();
            BeginContext(813, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(828, 81, false);
#line 27 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Reset.cshtml"
       Write(Html.PasswordFor(model => model.CurrentPassword, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(909, 40, true);
            WriteLiteral("\r\n            <span class=\"text-danger\">");
            EndContext();
            BeginContext(950, 57, false);
#line 28 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Reset.cshtml"
                                 Write(Html.ValidationMessageFor(model => model.CurrentPassword));

#line default
#line hidden
            EndContext();
            BeginContext(1007, 71, true);
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1079, 38, false);
#line 31 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Reset.cshtml"
       Write(Html.LabelFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(1117, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1132, 74, false);
#line 32 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Reset.cshtml"
       Write(Html.PasswordFor(model => model.Password, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1206, 40, true);
            WriteLiteral("\r\n            <span class=\"text-danger\">");
            EndContext();
            BeginContext(1247, 50, false);
#line 33 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Reset.cshtml"
                                 Write(Html.ValidationMessageFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(1297, 71, true);
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1369, 45, false);
#line 36 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Reset.cshtml"
       Write(Html.LabelFor(model => model.PasswordConfirm));

#line default
#line hidden
            EndContext();
            BeginContext(1414, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1429, 81, false);
#line 37 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Reset.cshtml"
       Write(Html.PasswordFor(model => model.PasswordConfirm, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1510, 40, true);
            WriteLiteral("\r\n            <span class=\"text-danger\">");
            EndContext();
            BeginContext(1551, 57, false);
#line 38 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Reset.cshtml"
                                 Write(Html.ValidationMessageFor(model => model.PasswordConfirm));

#line default
#line hidden
            EndContext();
            BeginContext(1608, 25, true);
            WriteLiteral("</span>\r\n        </div>\r\n");
            EndContext();
            BeginContext(1635, 74, true);
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col\">\r\n                ");
            EndContext();
            BeginContext(1710, 126, false);
#line 43 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Reset.cshtml"
           Write(Html.ActionLink("Cancelar", "Index", "User", null, new { @class = "btn btn-light form-control", style = "margin-rigth: 5px" }));

#line default
#line hidden
            EndContext();
            BeginContext(1836, 209, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col\">\r\n                <button type=\"submit\" class=\"btn btn-dark form-control\" style=\"margin-left: 5px\">Trocar senha</button>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 49 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Reset.cshtml"
    }

#line default
#line hidden
            BeginContext(2052, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GDR.Models.ModelsForViews.ResetPassword> Html { get; private set; }
    }
}
#pragma warning restore 1591
