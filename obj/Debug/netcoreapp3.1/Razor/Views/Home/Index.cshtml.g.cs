#pragma checksum "C:\Users\gabri\source\repos\GDR\GDR\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc0707faf49026d239d0ddef404494a18674420d"
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
#line 1 "C:\Users\gabri\source\repos\GDR\GDR\Views\_ViewImports.cshtml"
using GDR;

#line default
#line hidden
#line 2 "C:\Users\gabri\source\repos\GDR\GDR\Views\_ViewImports.cshtml"
using GDR.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc0707faf49026d239d0ddef404494a18674420d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8c019d0c725705bb2e7e3f09db2f72ccb8ac556", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\gabri\source\repos\GDR\GDR\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Solicitações";

#line default
#line hidden
            BeginContext(48, 340, true);
            WriteLiteral(@"
<style>
    .nav-item {
        margin: 5px;
    }
</style>

<div class=""container"">
    <div class=""row"">
        <div class=""col"">
            <div class=""card"">                
                <div class=""card-body"">
                    <ul class=""nav nav-pills mb-3"" id=""pills-tab"" role=""tablist"">
                        ");
            EndContext();
            BeginContext(389, 66, false);
#line 17 "C:\Users\gabri\source\repos\GDR\GDR\Views\Home\Index.cshtml"
                   Write(await Html.PartialAsync("~/Views/Fragments/ActionsByUsers.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(455, 771, true);
            WriteLiteral(@"
                        <li class=""nav-item"">
                            <a class=""btn btn-secondary"" id=""solicitacoes-tab"" data-toggle=""pill"" href=""#solicitacoes"" role=""tab"" aria-controls=""solicitacoes"" aria-selected=""true"">Minhas Solicitações</a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""container"" style=""margin-top: 30px"">
    <div class=""tab-content"" id=""pills-tabContent"">
        <div class=""tab-pane fade show active"" id=""solicitacoes"" role=""tabpanel"" aria-labelledby=""solicitacoes-tab"">
            <div class=""jumbotron"">
                <h5 class=""display-3"">Minhas Solicitações</h5>
                <div class=""row"">
                    ");
            EndContext();
            BeginContext(1227, 62, false);
#line 34 "C:\Users\gabri\source\repos\GDR\GDR\Views\Home\Index.cshtml"
               Write(await Html.PartialAsync("~/Views/Fragments/OrderTable.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(1289, 323, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <div class=""tab-pane fade"" id=""requisicoes"" role=""tabpanel"" aria-labelledby=""pills-profile-tab"">
            <div class=""jumbotron"">
                <h5 class=""display-3"">Minhas Requisições</h5>
                <div class=""row"">
                    ");
            EndContext();
            BeginContext(1613, 64, false);
#line 42 "C:\Users\gabri\source\repos\GDR\GDR\Views\Home\Index.cshtml"
               Write(await Html.PartialAsync("~/Views/Fragments/RequestTable.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(1677, 80, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
