#pragma checksum "C:\Users\Lenovo X240\Downloads\Agiles\Empresa.App\FrontEnd\Pages\Clientes\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "062a1ffae547bd9b9e2e17fa78b8e23a35fef1a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Frontend.Pages.Clientes.Pages_Clientes_List), @"mvc.1.0.razor-page", @"/Pages/Clientes/List.cshtml")]
namespace Frontend.Pages.Clientes
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
#line 1 "C:\Users\Lenovo X240\Downloads\Agiles\Empresa.App\FrontEnd\Pages\_ViewImports.cshtml"
using Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"062a1ffae547bd9b9e2e17fa78b8e23a35fef1a7", @"/Pages/Clientes/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7e204b5447433fc29832fde3d015c2ce34c8ad9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Clientes_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"text-center center\">\r\n    <h1>Listado de clientes</h1>\r\n</div>\r\n\r\n<br/>\r\n<br/>\r\n<br/>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>TELEFONO</th>\r\n        <th>ID EMPRESA</th>\r\n    </tr>\r\n\r\n<table class=\"table\">\r\n");
#nullable restore
#line 22 "C:\Users\Lenovo X240\Downloads\Agiles\Empresa.App\FrontEnd\Pages\Clientes\List.cshtml"
    foreach (var cliente in Model.Clientes)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("       <tr>\r\n           <td>");
#nullable restore
#line 25 "C:\Users\Lenovo X240\Downloads\Agiles\Empresa.App\FrontEnd\Pages\Clientes\List.cshtml"
          Write(cliente.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 26 "C:\Users\Lenovo X240\Downloads\Agiles\Empresa.App\FrontEnd\Pages\Clientes\List.cshtml"
          Write(cliente.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 27 "C:\Users\Lenovo X240\Downloads\Agiles\Empresa.App\FrontEnd\Pages\Clientes\List.cshtml"
          Write(cliente.EsCliente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       </tr> \r\n");
#nullable restore
#line 29 "C:\Users\Lenovo X240\Downloads\Agiles\Empresa.App\FrontEnd\Pages\Clientes\List.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Frontend.Pages.ListModelClientes> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Frontend.Pages.ListModelClientes> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Frontend.Pages.ListModelClientes>)PageContext?.ViewData;
        public Frontend.Pages.ListModelClientes Model => ViewData.Model;
    }
}
#pragma warning restore 1591
