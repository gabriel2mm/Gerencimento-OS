#pragma checksum "C:\Users\gabri\source\repos\GDR\GDR\Views\Home\CreateRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a73a714575a0a3cb23e89486a066416192d7e880"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CreateRequest), @"mvc.1.0.view", @"/Views/Home/CreateRequest.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CreateRequest.cshtml", typeof(AspNetCore.Views_Home_CreateRequest))]
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
#line 1 "C:\Users\gabri\source\repos\GDR\GDR\Views\Home\CreateRequest.cshtml"
using GDR.Enumerators;

#line default
#line hidden
#line 2 "C:\Users\gabri\source\repos\GDR\GDR\Views\Home\CreateRequest.cshtml"
using GDR.Models.ModelsForViews;

#line default
#line hidden
#line 3 "C:\Users\gabri\source\repos\GDR\GDR\Views\Home\CreateRequest.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "C:\Users\gabri\source\repos\GDR\GDR\Views\Home\CreateRequest.cshtml"
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a73a714575a0a3cb23e89486a066416192d7e880", @"/Views/Home/CreateRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8c019d0c725705bb2e7e3f09db2f72ccb8ac556", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CreateRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RequestViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(154, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\gabri\source\repos\GDR\GDR\Views\Home\CreateRequest.cshtml"
  
    ViewData["Title"] = "Criar requisição";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(320, 140, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"jumbotron\">\r\n        <div class=\"row\">\r\n            <h1>Criar Requisição</h1>\r\n        </div>\r\n\r\n");
            EndContext();
#line 19 "C:\Users\gabri\source\repos\GDR\GDR\Views\Home\CreateRequest.cshtml"
         using (Html.BeginForm())
        {
            Html.AntiForgeryToken();


#line default
#line hidden
            BeginContext(546, 86, true);
            WriteLiteral("            <div class=\"form-group\">\r\n                <label>Requisição para usuário: ");
            EndContext();
            BeginContext(633, 44, false);
#line 24 "C:\Users\gabri\source\repos\GDR\GDR\Views\Home\CreateRequest.cshtml"
                                           Write(_userManager.GetUserAsync(User).Result.Login);

#line default
#line hidden
            EndContext();
            BeginContext(677, 30, true);
            WriteLiteral("</label>\r\n            </div>\r\n");
            EndContext();
            BeginContext(709, 54, true);
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(764, 34, false);
#line 28 "C:\Users\gabri\source\repos\GDR\GDR\Views\Home\CreateRequest.cshtml"
           Write(Html.LabelFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(798, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(817, 113, false);
#line 29 "C:\Users\gabri\source\repos\GDR\GDR\Views\Home\CreateRequest.cshtml"
           Write(Html.DropDownListFor(model => model.Type, Html.GetEnumSelectList<Types>(), null, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(930, 44, true);
            WriteLiteral("\r\n                <span class=\"text-danger\">");
            EndContext();
            BeginContext(975, 46, false);
#line 30 "C:\Users\gabri\source\repos\GDR\GDR\Views\Home\CreateRequest.cshtml"
                                     Write(Html.ValidationMessageFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(1021, 29, true);
            WriteLiteral("</span>\r\n            </div>\r\n");
            EndContext();
            BeginContext(1052, 54, true);
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(1107, 40, false);
#line 34 "C:\Users\gabri\source\repos\GDR\GDR\Views\Home\CreateRequest.cshtml"
           Write(Html.LabelFor(model => model.Equipament));

#line default
#line hidden
            EndContext();
            BeginContext(1147, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1166, 79, false);
#line 35 "C:\Users\gabri\source\repos\GDR\GDR\Views\Home\CreateRequest.cshtml"
           Write(Html.TextBoxFor(model => model.Equipament, "", new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1245, 44, true);
            WriteLiteral("\r\n                <span class=\"text-danger\">");
            EndContext();
            BeginContext(1290, 52, false);
#line 36 "C:\Users\gabri\source\repos\GDR\GDR\Views\Home\CreateRequest.cshtml"
                                     Write(Html.ValidationMessageFor(model => model.Equipament));

#line default
#line hidden
            EndContext();
            BeginContext(1342, 29, true);
            WriteLiteral("</span>\r\n            </div>\r\n");
            EndContext();
            BeginContext(1373, 54, true);
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(1428, 41, false);
#line 40 "C:\Users\gabri\source\repos\GDR\GDR\Views\Home\CreateRequest.cshtml"
           Write(Html.LabelFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1469, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1488, 83, false);
#line 41 "C:\Users\gabri\source\repos\GDR\GDR\Views\Home\CreateRequest.cshtml"
           Write(Html.TextAreaFor(model => model.Description, 5, 5, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1571, 44, true);
            WriteLiteral("\r\n                <span class=\"text-danger\">");
            EndContext();
            BeginContext(1616, 53, false);
#line 42 "C:\Users\gabri\source\repos\GDR\GDR\Views\Home\CreateRequest.cshtml"
                                     Write(Html.ValidationMessageFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1669, 29, true);
            WriteLiteral("</span>\r\n            </div>\r\n");
            EndContext();
            BeginContext(1702, 88, true);
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-6\">\r\n                    ");
            EndContext();
            BeginContext(1791, 99, false);
#line 48 "C:\Users\gabri\source\repos\GDR\GDR\Views\Home\CreateRequest.cshtml"
               Write(Html.ActionLink("Voltar", "Index", "Home", null, new { @class = "btn btn-secondary form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1890, 213, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-6\">\r\n                    <button type=\"submit\" class=\"btn btn-success form-control\">Criar Requisição</button>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 54 "C:\Users\gabri\source\repos\GDR\GDR\Views\Home\CreateRequest.cshtml"
            
        }

#line default
#line hidden
            BeginContext(2128, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> _userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RequestViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
