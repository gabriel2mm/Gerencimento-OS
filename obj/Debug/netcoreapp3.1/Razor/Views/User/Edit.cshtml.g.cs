#pragma checksum "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd95f19f49a9488d70f92fee3db83303f75e4d04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Edit), @"mvc.1.0.view", @"/Views/User/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Edit.cshtml", typeof(AspNetCore.Views_User_Edit))]
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
#line 1 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Edit.cshtml"
using GDR.Models.ModelsForViews;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd95f19f49a9488d70f92fee3db83303f75e4d04", @"/Views/User/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8c019d0c725705bb2e7e3f09db2f72ccb8ac556", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(136, 113, true);
            WriteLiteral("\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <h1>Editar usuário</h1>\r\n        </div>\r\n\r\n");
            EndContext();
#line 13 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Edit.cshtml"
         using (Html.BeginForm(FormMethod.Post))
        {
            

#line default
#line hidden
            BeginContext(323, 23, false);
#line 15 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Edit.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(348, 54, true);
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(403, 40, false);
#line 17 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Edit.cshtml"
           Write(Html.LabelFor(model => model.First_Name));

#line default
#line hidden
            EndContext();
            BeginContext(443, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(462, 81, false);
#line 18 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Edit.cshtml"
           Write(Html.TextBoxFor(model => model.First_Name, null, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(543, 44, true);
            WriteLiteral("\r\n                <span class=\"text-danger\">");
            EndContext();
            BeginContext(588, 52, false);
#line 19 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Edit.cshtml"
                                     Write(Html.ValidationMessageFor(model => model.First_Name));

#line default
#line hidden
            EndContext();
            BeginContext(640, 83, true);
            WriteLiteral("</span>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(724, 39, false);
#line 22 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Edit.cshtml"
           Write(Html.LabelFor(model => model.Last_name));

#line default
#line hidden
            EndContext();
            BeginContext(763, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(782, 80, false);
#line 23 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Edit.cshtml"
           Write(Html.TextBoxFor(model => model.Last_name, null, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(862, 44, true);
            WriteLiteral("\r\n                <span class=\"text-danger\">");
            EndContext();
            BeginContext(907, 51, false);
#line 24 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Edit.cshtml"
                                     Write(Html.ValidationMessageFor(model => model.Last_name));

#line default
#line hidden
            EndContext();
            BeginContext(958, 83, true);
            WriteLiteral("</span>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(1042, 35, false);
#line 27 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Edit.cshtml"
           Write(Html.LabelFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1077, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1096, 76, false);
#line 28 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Edit.cshtml"
           Write(Html.TextBoxFor(model => model.Email, null, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1172, 44, true);
            WriteLiteral("\r\n                <span class=\"text-danger\">");
            EndContext();
            BeginContext(1217, 47, false);
#line 29 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Edit.cshtml"
                                     Write(Html.ValidationMessageFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1264, 83, true);
            WriteLiteral("</span>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(1348, 35, false);
#line 32 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Edit.cshtml"
           Write(Html.LabelFor(model => model.Login));

#line default
#line hidden
            EndContext();
            BeginContext(1383, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1402, 76, false);
#line 33 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Edit.cshtml"
           Write(Html.TextBoxFor(model => model.Login, null, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1478, 44, true);
            WriteLiteral("\r\n                <span class=\"text-danger\">");
            EndContext();
            BeginContext(1523, 47, false);
#line 34 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Edit.cshtml"
                                     Write(Html.ValidationMessageFor(model => model.Login));

#line default
#line hidden
            EndContext();
            BeginContext(1570, 29, true);
            WriteLiteral("</span>\r\n            </div>\r\n");
            EndContext();
            BeginContext(1601, 136, true);
            WriteLiteral("            <div class=\"form-group\">\r\n                <div class=\"row\">\r\n                    <div class=\"col\">\r\n                        ");
            EndContext();
            BeginContext(1738, 126, false);
#line 40 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Edit.cshtml"
                   Write(Html.ActionLink("Cancelar", "Index", "User", null, new { @class = "btn btn-light form-control", style = "margin-rigth: 5px" }));

#line default
#line hidden
            EndContext();
            BeginContext(1864, 263, true);
            WriteLiteral(@"
                    </div>
                    <div class=""col"">
                        <button type=""submit"" class=""btn btn-dark form-control"" style=""margin-left: 5px"">Salvar</button>
                    </div>
                </div>
            </div>
");
            EndContext();
#line 47 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Edit.cshtml"
        }

#line default
#line hidden
            BeginContext(2138, 16, true);
            WriteLiteral("\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
