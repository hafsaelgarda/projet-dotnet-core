#pragma checksum "C:\Users\hafsa web\Desktop\projet-dotnet-core\projet\Views\Admins\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbe979c2eef785a750b56bd100d33fd08f918f03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admins_Details), @"mvc.1.0.view", @"/Views/Admins/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admins/Details.cshtml", typeof(AspNetCore.Views_Admins_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbe979c2eef785a750b56bd100d33fd08f918f03", @"/Views/Admins/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20aa150e74b17ce214797d1aa823449dfbdbcf15", @"/Views/_ViewImports.cshtml")]
    public class Views_Admins_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<projet.Models.Admin>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\hafsa web\Desktop\projet-dotnet-core\projet\Views\Admins\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(68, 111, true);
            WriteLiteral("\n<h2>Details</h2>\n\n<div>\n    <h4>Admin</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(180, 39, false);
#line 14 "C:\Users\hafsa web\Desktop\projet-dotnet-core\projet\Views\Admins\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.nom));

#line default
#line hidden
            EndContext();
            BeginContext(219, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(260, 35, false);
#line 17 "C:\Users\hafsa web\Desktop\projet-dotnet-core\projet\Views\Admins\Details.cshtml"
       Write(Html.DisplayFor(model => model.nom));

#line default
#line hidden
            EndContext();
            BeginContext(295, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(336, 42, false);
#line 20 "C:\Users\hafsa web\Desktop\projet-dotnet-core\projet\Views\Admins\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.prenom));

#line default
#line hidden
            EndContext();
            BeginContext(378, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(419, 38, false);
#line 23 "C:\Users\hafsa web\Desktop\projet-dotnet-core\projet\Views\Admins\Details.cshtml"
       Write(Html.DisplayFor(model => model.prenom));

#line default
#line hidden
            EndContext();
            BeginContext(457, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(498, 44, false);
#line 26 "C:\Users\hafsa web\Desktop\projet-dotnet-core\projet\Views\Admins\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.username));

#line default
#line hidden
            EndContext();
            BeginContext(542, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(583, 40, false);
#line 29 "C:\Users\hafsa web\Desktop\projet-dotnet-core\projet\Views\Admins\Details.cshtml"
       Write(Html.DisplayFor(model => model.username));

#line default
#line hidden
            EndContext();
            BeginContext(623, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(664, 39, false);
#line 32 "C:\Users\hafsa web\Desktop\projet-dotnet-core\projet\Views\Admins\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.mdp));

#line default
#line hidden
            EndContext();
            BeginContext(703, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(744, 35, false);
#line 35 "C:\Users\hafsa web\Desktop\projet-dotnet-core\projet\Views\Admins\Details.cshtml"
       Write(Html.DisplayFor(model => model.mdp));

#line default
#line hidden
            EndContext();
            BeginContext(779, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(820, 41, false);
#line 38 "C:\Users\hafsa web\Desktop\projet-dotnet-core\projet\Views\Admins\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(861, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(902, 37, false);
#line 41 "C:\Users\hafsa web\Desktop\projet-dotnet-core\projet\Views\Admins\Details.cshtml"
       Write(Html.DisplayFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(939, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(980, 41, false);
#line 44 "C:\Users\hafsa web\Desktop\projet-dotnet-core\projet\Views\Admins\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.photo));

#line default
#line hidden
            EndContext();
            BeginContext(1021, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1062, 37, false);
#line 47 "C:\Users\hafsa web\Desktop\projet-dotnet-core\projet\Views\Admins\Details.cshtml"
       Write(Html.DisplayFor(model => model.photo));

#line default
#line hidden
            EndContext();
            BeginContext(1099, 42, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(1141, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bdece12375d4756b333ff3d4eb58fb7", async() => {
                BeginContext(1187, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\hafsa web\Desktop\projet-dotnet-core\projet\Views\Admins\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1195, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(1202, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64852d92781948bb8a92a1157111d99d", async() => {
                BeginContext(1224, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1240, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<projet.Models.Admin> Html { get; private set; }
    }
}
#pragma warning restore 1591
