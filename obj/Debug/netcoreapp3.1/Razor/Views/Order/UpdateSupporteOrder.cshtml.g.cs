#pragma checksum "C:\Users\gabri\source\repos\GDR\GDR\Views\Order\UpdateSupporteOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53bb4a96870ab46026f51a1beadc1915dea852d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_UpdateSupporteOrder), @"mvc.1.0.view", @"/Views/Order/UpdateSupporteOrder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/UpdateSupporteOrder.cshtml", typeof(AspNetCore.Views_Order_UpdateSupporteOrder))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53bb4a96870ab46026f51a1beadc1915dea852d8", @"/Views/Order/UpdateSupporteOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8c019d0c725705bb2e7e3f09db2f72ccb8ac556", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_UpdateSupporteOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\gabri\source\repos\GDR\GDR\Views\Order\UpdateSupporteOrder.cshtml"
  
    ViewData["Title"] = "Complemento suporte tecnico";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(125, 54, true);
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"jumbotron\">\r\n");
            EndContext();
#line 8 "C:\Users\gabri\source\repos\GDR\GDR\Views\Order\UpdateSupporteOrder.cshtml"
         using (Html.BeginForm(method: FormMethod.Post, new { @class = "form" }))
        {

#line default
#line hidden
            BeginContext(273, 110, true);
            WriteLiteral("            <h5>Justificativa</h5>\r\n            <div class=\"form-group\">\r\n                <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 383, "\"", 397, 1);
#line 12 "C:\Users\gabri\source\repos\GDR\GDR\Views\Order\UpdateSupporteOrder.cshtml"
WriteAttributeValue("", 391, Model, 391, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(398, 336, true);
            WriteLiteral(@" name=""id"" id=""id"" />
            </div>
            <div class=""form-group"">
                <textarea name=""description"" class=""form-control"" rows=""5"" cols=""5""></textarea>
            </div>
            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-6"">
                        ");
            EndContext();
            BeginContext(735, 118, false);
#line 20 "C:\Users\gabri\source\repos\GDR\GDR\Views\Order\UpdateSupporteOrder.cshtml"
                   Write(Html.ActionLink("voltar", "ViewOrder", "Order", new { id = Model }, new { @class = "btn btn-secondary form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(853, 243, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-6\">\r\n                        <button type=\"submit\" class=\"btn btn-success form-control\">Enviar</button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 27 "C:\Users\gabri\source\repos\GDR\GDR\Views\Order\UpdateSupporteOrder.cshtml"
        }

#line default
#line hidden
            BeginContext(1107, 20, true);
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591