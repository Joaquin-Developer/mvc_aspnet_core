#pragma checksum "/home/joaquin/Documentos/ProyectosPersonales/api_aspnet_core/Views/School/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f17106246bc6cd8c2610fdd615d673578778fd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_School_Index), @"mvc.1.0.view", @"/Views/School/Index.cshtml")]
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
#line 1 "/home/joaquin/Documentos/ProyectosPersonales/api_aspnet_core/Views/_ViewImports.cshtml"
using api_aspnet_core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/joaquin/Documentos/ProyectosPersonales/api_aspnet_core/Views/_ViewImports.cshtml"
using api_aspnet_core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f17106246bc6cd8c2610fdd615d673578778fd2", @"/Views/School/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1db77120c64173c0a3dc3a2140eca39f9074d6c", @"/Views/_ViewImports.cshtml")]
    public class Views_School_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/joaquin/Documentos/ProyectosPersonales/api_aspnet_core/Views/School/Index.cshtml"
  
    ViewData["Title"] = "School Info";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Mi Escuela</h1>\r\n<h2>Nombre: ");
#nullable restore
#line 6 "/home/joaquin/Documentos/ProyectosPersonales/api_aspnet_core/Views/School/Index.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<p><strong>Año funcación: ");
#nullable restore
#line 7 "/home/joaquin/Documentos/ProyectosPersonales/api_aspnet_core/Views/School/Index.cshtml"
                     Write(Model.FoundationYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n\r\n");
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
