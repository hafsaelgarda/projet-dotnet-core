#pragma checksum "C:\Users\azerty\Documents\GitHub\projet-dotnet-core\projet\Views\chapitres\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d469429720e57f35dc3a0777fd184109ce9d0b67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_chapitres_Index), @"mvc.1.0.view", @"/Views/chapitres/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/chapitres/Index.cshtml", typeof(AspNetCore.Views_chapitres_Index))]
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
#line 1 "C:\Users\azerty\Documents\GitHub\projet-dotnet-core\projet\Views\_ViewImports.cshtml"
using projet;

#line default
#line hidden
#line 2 "C:\Users\azerty\Documents\GitHub\projet-dotnet-core\projet\Views\_ViewImports.cshtml"
using projet.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d469429720e57f35dc3a0777fd184109ce9d0b67", @"/Views/chapitres/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcc0a35fdeccc1df7504aa9b37c5d3fee80035b7", @"/Views/_ViewImports.cshtml")]
    public class Views_chapitres_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<projet.Models.chapitre>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\azerty\Documents\GitHub\projet-dotnet-core\projet\Views\chapitres\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutEnseignant.cshtml";

#line default
#line hidden
            BeginContext(144, 241, true);
            WriteLiteral("\r\n<h1>   Liste Des Chapitres  </h1>\r\n<br />  <br />\r\n<br />  <br /><br />  <br /><br />  <br />\r\n<table class=\"table table-bordered table-hover table-striped\">\r\n    <thead class=\"thead-dark\">\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(386, 40, false);
#line 15 "C:\Users\azerty\Documents\GitHub\projet-dotnet-core\projet\Views\chapitres\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.type));

#line default
#line hidden
            EndContext();
            BeginContext(426, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(482, 43, false);
#line 18 "C:\Users\azerty\Documents\GitHub\projet-dotnet-core\projet\Views\chapitres\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.contenu));

#line default
#line hidden
            EndContext();
            BeginContext(525, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(581, 46, false);
#line 21 "C:\Users\azerty\Documents\GitHub\projet-dotnet-core\projet\Views\chapitres\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.date_depot));

#line default
#line hidden
            EndContext();
            BeginContext(627, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(683, 47, false);
#line 24 "C:\Users\azerty\Documents\GitHub\projet-dotnet-core\projet\Views\chapitres\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.responsable));

#line default
#line hidden
            EndContext();
            BeginContext(730, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(786, 42, false);
#line 27 "C:\Users\azerty\Documents\GitHub\projet-dotnet-core\projet\Views\chapitres\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Module));

#line default
#line hidden
            EndContext();
            BeginContext(828, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 33 "C:\Users\azerty\Documents\GitHub\projet-dotnet-core\projet\Views\chapitres\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(963, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1024, 39, false);
#line 37 "C:\Users\azerty\Documents\GitHub\projet-dotnet-core\projet\Views\chapitres\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.type));

#line default
#line hidden
            EndContext();
            BeginContext(1063, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1131, 42, false);
#line 40 "C:\Users\azerty\Documents\GitHub\projet-dotnet-core\projet\Views\chapitres\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.contenu));

#line default
#line hidden
            EndContext();
            BeginContext(1173, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1241, 45, false);
#line 43 "C:\Users\azerty\Documents\GitHub\projet-dotnet-core\projet\Views\chapitres\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.date_depot));

#line default
#line hidden
            EndContext();
            BeginContext(1286, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1354, 46, false);
#line 46 "C:\Users\azerty\Documents\GitHub\projet-dotnet-core\projet\Views\chapitres\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.responsable));

#line default
#line hidden
            EndContext();
            BeginContext(1400, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1468, 49, false);
#line 49 "C:\Users\azerty\Documents\GitHub\projet-dotnet-core\projet\Views\chapitres\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Module.nom_mod));

#line default
#line hidden
            EndContext();
            BeginContext(1517, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1585, 109, false);
#line 52 "C:\Users\azerty\Documents\GitHub\projet-dotnet-core\projet\Views\chapitres\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = item.id_chap }, new { @class = "btn btn-primary btn-icon-split" }));

#line default
#line hidden
            EndContext();
            BeginContext(1694, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1717, 112, false);
#line 53 "C:\Users\azerty\Documents\GitHub\projet-dotnet-core\projet\Views\chapitres\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = item.id_chap }, new { @class = "btn btn-info btn-icon-split" }));

#line default
#line hidden
            EndContext();
            BeginContext(1829, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1852, 112, false);
#line 54 "C:\Users\azerty\Documents\GitHub\projet-dotnet-core\projet\Views\chapitres\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.id_chap }, new { @class = "btn btn-danger btn-icon-split" }));

#line default
#line hidden
            EndContext();
            BeginContext(1964, 46, true);
            WriteLiteral("\r\n\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 58 "C:\Users\azerty\Documents\GitHub\projet-dotnet-core\projet\Views\chapitres\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2021, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<projet.Models.chapitre>> Html { get; private set; }
    }
}
#pragma warning restore 1591
