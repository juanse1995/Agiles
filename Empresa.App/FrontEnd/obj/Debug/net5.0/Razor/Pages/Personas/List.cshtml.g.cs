#pragma checksum "C:\Users\Lenovo X240\Downloads\EMPRESA\Agiles\empresa.app\frontend\Pages\Personas\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0c2d609e48cafbd09148ffe0e6f50276e984ce1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Frontend.Pages.Personas.Pages_Personas_List), @"mvc.1.0.razor-page", @"/Pages/Personas/List.cshtml")]
namespace Frontend.Pages.Personas
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
#line 1 "C:\Users\Lenovo X240\Downloads\EMPRESA\Agiles\empresa.app\frontend\Pages\_ViewImports.cshtml"
using Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0c2d609e48cafbd09148ffe0e6f50276e984ce1", @"/Pages/Personas/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7e204b5447433fc29832fde3d015c2ce34c8ad9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Personas_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Listado de personas</h1>\r\n\r\n<table class=\"table\">\r\n");
#nullable restore
#line 9 "C:\Users\Lenovo X240\Downloads\EMPRESA\Agiles\empresa.app\frontend\Pages\Personas\List.cshtml"
    foreach (var persona in Model.Persona)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("       <tr>\r\n           <td>");
#nullable restore
#line 12 "C:\Users\Lenovo X240\Downloads\EMPRESA\Agiles\empresa.app\frontend\Pages\Personas\List.cshtml"
          Write(persona.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 13 "C:\Users\Lenovo X240\Downloads\EMPRESA\Agiles\empresa.app\frontend\Pages\Personas\List.cshtml"
          Write(persona.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 14 "C:\Users\Lenovo X240\Downloads\EMPRESA\Agiles\empresa.app\frontend\Pages\Personas\List.cshtml"
          Write(persona.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 15 "C:\Users\Lenovo X240\Downloads\EMPRESA\Agiles\empresa.app\frontend\Pages\Personas\List.cshtml"
          Write(persona.Documento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 16 "C:\Users\Lenovo X240\Downloads\EMPRESA\Agiles\empresa.app\frontend\Pages\Personas\List.cshtml"
          Write(persona.FechaNacimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       </tr> \r\n");
#nullable restore
#line 18 "C:\Users\Lenovo X240\Downloads\EMPRESA\Agiles\empresa.app\frontend\Pages\Personas\List.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Frontend.Pages.ListModelPersonas> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Frontend.Pages.ListModelPersonas> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Frontend.Pages.ListModelPersonas>)PageContext?.ViewData;
        public Frontend.Pages.ListModelPersonas Model => ViewData.Model;
    }
}
#pragma warning restore 1591
