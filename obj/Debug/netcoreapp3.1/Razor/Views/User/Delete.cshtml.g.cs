#pragma checksum "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b41db0f97815e1f8f89972ab58a5de995d06efe7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Delete), @"mvc.1.0.view", @"/Views/User/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b41db0f97815e1f8f89972ab58a5de995d06efe7", @"/Views/User/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8c019d0c725705bb2e7e3f09db2f72ccb8ac556", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GDR.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Delete.cshtml"
  
    ViewData["Title"] = "Excluir usuário";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"container\">\r\n");
#nullable restore
#line 8 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Delete.cshtml"
         using (Html.BeginForm(FormMethod.Post))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Delete.cshtml"
       Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Delete.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-warning\" role=\"alert\">\r\n                <span><strong>Exluir usuário ? </strong>Tem certeza que deseja exluir o usuário : ");
#nullable restore
#line 13 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Delete.cshtml"
                                                                                             Write(Html.DisplayFor(model => model.First_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Delete.cshtml"
                                                                                                                                         Write(Html.DisplayFor(model => model.Last_name));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ?</span>\r\n                <div style=\"margin-top: 10px\">\r\n                    ");
#nullable restore
#line 15 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Delete.cshtml"
               Write(Html.ActionLink("Cancelar", "Index", "User", null, new { @class = "btn btn-light", style = "margin-rigth: 5px; width: 100px" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <button type=\"submit\" class=\"btn btn-danger\" style=\"width: 100px\">Exluir</button>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 19 "C:\Users\gabri\source\repos\GDR\GDR\Views\User\Delete.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GDR.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591