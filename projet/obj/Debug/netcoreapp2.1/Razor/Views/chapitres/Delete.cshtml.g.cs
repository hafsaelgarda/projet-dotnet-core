#pragma checksum "C:\Users\hafsa web\Desktop\projet-dotnet-core\projet\Views\chapitres\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93a437743614e957cd98a7fffb95350f74c21c39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_chapitres_Delete), @"mvc.1.0.view", @"/Views/chapitres/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/chapitres/Delete.cshtml", typeof(AspNetCore.Views_chapitres_Delete))]
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
#line 1 "C:\Users\hafsa web\Desktop\projet-dotnet-core\projet\Views\_ViewImports.cshtml"
using projet;

#line default
#line hidden
#line 2 "C:\Users\hafsa web\Desktop\projet-dotnet-core\projet\Views\_ViewImports.cshtml"
using projet.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93a437743614e957cd98a7fffb95350f74c21c39", @"/Views/chapitres/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20aa150e74b17ce214797d1aa823449dfbdbcf15", @"/Views/_ViewImports.cshtml")]
    public class Views_chapitres_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<projet.Models.chapitre>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\hafsa web\Desktop\projet-dotnet-core\projet\Views\chapitres\Delete.cshtml"
      Layout = "~/Views/Shared/_LayoutEnseignant.cshtml";

    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(126, 31, true);
            WriteLiteral("<h2>Supprimer un chapitre</h2>\n");
            EndContext();
#line 8 "C:\Users\hafsa web\Desktop\projet-dotnet-core\projet\Views\chapitres\Delete.cshtml"
 using (Html.BeginForm("Delete", "chapitres", FormMethod.Post, new { id = "popupForm" }))
{
    

#line default
#line hidden
            BeginContext(254, 30, false);
#line 10 "C:\Users\hafsa web\Desktop\projet-dotnet-core\projet\Views\chapitres\Delete.cshtml"
Write(Html.HiddenFor(a => a.id_chap));

#line default
#line hidden
            EndContext();
            BeginContext(285, 82, true);
            WriteLiteral("    <div class=\"form-group\">\n        <label>Numero du chapitre</label>\n        <p>");
            EndContext();
            BeginContext(368, 13, false);
#line 13 "C:\Users\hafsa web\Desktop\projet-dotnet-core\projet\Views\chapitres\Delete.cshtml"
      Write(Model.id_chap);

#line default
#line hidden
            EndContext();
            BeginContext(381, 16, true);
            WriteLiteral("</p>\n    </div>\n");
            EndContext();
            BeginContext(398, 80, true);
            WriteLiteral("    <div class=\"form-group\">\n        <label>Type du chapitre</label>\n        <p>");
            EndContext();
            BeginContext(479, 10, false);
#line 18 "C:\Users\hafsa web\Desktop\projet-dotnet-core\projet\Views\chapitres\Delete.cshtml"
      Write(Model.type);

#line default
#line hidden
            EndContext();
            BeginContext(489, 16, true);
            WriteLiteral("</p>\n    </div>\n");
            EndContext();
            BeginContext(506, 83, true);
            WriteLiteral("    <div class=\"form-group\">\n        <label>Contenu du chapitre</label>\n        <p>");
            EndContext();
            BeginContext(590, 13, false);
#line 23 "C:\Users\hafsa web\Desktop\projet-dotnet-core\projet\Views\chapitres\Delete.cshtml"
      Write(Model.contenu);

#line default
#line hidden
            EndContext();
            BeginContext(603, 94, true);
            WriteLiteral("</p>\n    </div>\n    <div class=\"form-group\">\n        <label>Date du depots</label>\n        <p>");
            EndContext();
            BeginContext(698, 16, false);
#line 27 "C:\Users\hafsa web\Desktop\projet-dotnet-core\projet\Views\chapitres\Delete.cshtml"
      Write(Model.date_depot);

#line default
#line hidden
            EndContext();
            BeginContext(714, 16, true);
            WriteLiteral("</p>\n    </div>\n");
            EndContext();
            BeginContext(731, 75, true);
            WriteLiteral("    <div class=\"form-group\">\n        <label>Responsable</label>\n        <p>");
            EndContext();
            BeginContext(807, 17, false);
#line 32 "C:\Users\hafsa web\Desktop\projet-dotnet-core\projet\Views\chapitres\Delete.cshtml"
      Write(Model.responsable);

#line default
#line hidden
            EndContext();
            BeginContext(824, 96, true);
            WriteLiteral("</p>\n    </div>\n    <div class=\"form-group\">\n        <label>Numero du module</label>\n        <p>");
            EndContext();
            BeginContext(921, 12, false);
#line 36 "C:\Users\hafsa web\Desktop\projet-dotnet-core\projet\Views\chapitres\Delete.cshtml"
      Write(Model.id_mod);

#line default
#line hidden
            EndContext();
            BeginContext(933, 84, true);
            WriteLiteral("</p>\n    </div>\n    <div>\n        <input type=\"submit\" value=\"Delete\" />\n    </div>\n");
            EndContext();
#line 41 "C:\Users\hafsa web\Desktop\projet-dotnet-core\projet\Views\chapitres\Delete.cshtml"
}

#line default
#line hidden
            BeginContext(1019, 4, true);
            WriteLiteral("\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<projet.Models.chapitre> Html { get; private set; }
    }
}
#pragma warning restore 1591
