#pragma checksum "G:\Biblioteka-master\Biblioteka.Web\Views\Autori\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4686d04d9a3d3eae2562393091ec7cbbc315e284"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Autori_Details), @"mvc.1.0.view", @"/Views/Autori/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Autori/Details.cshtml", typeof(AspNetCore.Views_Autori_Details))]
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
#line 1 "G:\Biblioteka-master\Biblioteka.Web\Views\_ViewImports.cshtml"
using Biblioteka.Web;

#line default
#line hidden
#line 2 "G:\Biblioteka-master\Biblioteka.Web\Views\_ViewImports.cshtml"
using Biblioteka.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4686d04d9a3d3eae2562393091ec7cbbc315e284", @"/Views/Autori/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d6734efa7bf0218c13a61ba2838992916e349d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Autori_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Biblioteka.Web.DAL.Entities.Autor>
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
            BeginContext(41, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "G:\Biblioteka-master\Biblioteka.Web\Views\Autori\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(82, 160, true);
            WriteLiteral("\n<h1>Details</h1>\n<h4>Autor</h4>\n<hr />\n<div class=\"row\">\n    <div class=\"col-sm-6\">\n        <dl class=\"row\">\n            <dt class=\"col-sm-2\">\n                ");
            EndContext();
            BeginContext(243, 39, false);
#line 14 "G:\Biblioteka-master\Biblioteka.Web\Views\Autori\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Ime));

#line default
#line hidden
            EndContext();
            BeginContext(282, 70, true);
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
            EndContext();
            BeginContext(353, 35, false);
#line 17 "G:\Biblioteka-master\Biblioteka.Web\Views\Autori\Details.cshtml"
           Write(Html.DisplayFor(model => model.Ime));

#line default
#line hidden
            EndContext();
            BeginContext(388, 69, true);
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
            EndContext();
            BeginContext(458, 43, false);
#line 20 "G:\Biblioteka-master\Biblioteka.Web\Views\Autori\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Prezime));

#line default
#line hidden
            EndContext();
            BeginContext(501, 70, true);
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
            EndContext();
            BeginContext(572, 39, false);
#line 23 "G:\Biblioteka-master\Biblioteka.Web\Views\Autori\Details.cshtml"
           Write(Html.DisplayFor(model => model.Prezime));

#line default
#line hidden
            EndContext();
            BeginContext(611, 69, true);
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
            EndContext();
            BeginContext(681, 41, false);
#line 26 "G:\Biblioteka-master\Biblioteka.Web\Views\Autori\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(722, 70, true);
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
            EndContext();
            BeginContext(793, 37, false);
#line 29 "G:\Biblioteka-master\Biblioteka.Web\Views\Autori\Details.cshtml"
           Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(830, 69, true);
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
            EndContext();
            BeginContext(900, 46, false);
#line 32 "G:\Biblioteka-master\Biblioteka.Web\Views\Autori\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Biografija));

#line default
#line hidden
            EndContext();
            BeginContext(946, 70, true);
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
            EndContext();
            BeginContext(1017, 42, false);
#line 35 "G:\Biblioteka-master\Biblioteka.Web\Views\Autori\Details.cshtml"
           Write(Html.DisplayFor(model => model.Biografija));

#line default
#line hidden
            EndContext();
            BeginContext(1059, 435, true);
            WriteLiteral(@"
            </dd>

        </dl>
    </div>


    <div class="" col-sm-6"">
        <h4 class=""text-center"">Knjige</h4>
        <table class=""table table-bordered "">

            <thead>
                <tr>
                    <th>
                        Naslov
                    </th>
                    <th>
                        Cijena
                    </th>

                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 58 "G:\Biblioteka-master\Biblioteka.Web\Views\Autori\Details.cshtml"
                 foreach (var item in Model.Knjige)
                {

#line default
#line hidden
            BeginContext(1564, 82, true);
            WriteLiteral("                    <tr>\n                        <td>\n                            ");
            EndContext();
            BeginContext(1647, 48, false);
#line 62 "G:\Biblioteka-master\Biblioteka.Web\Views\Autori\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Knjiga.Naslov));

#line default
#line hidden
            EndContext();
            BeginContext(1695, 88, true);
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(1784, 48, false);
#line 65 "G:\Biblioteka-master\Biblioteka.Web\Views\Autori\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Knjiga.Cijena));

#line default
#line hidden
            EndContext();
            BeginContext(1832, 58, true);
            WriteLiteral("\n                        </td>\n\n                    </tr>\n");
            EndContext();
#line 69 "G:\Biblioteka-master\Biblioteka.Web\Views\Autori\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(1908, 66, true);
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(1974, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4686d04d9a3d3eae2562393091ec7cbbc315e2849398", async() => {
                BeginContext(2021, 4, true);
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
#line 75 "G:\Biblioteka-master\Biblioteka.Web\Views\Autori\Details.cshtml"
                           WriteLiteral(Model.aId);

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
            BeginContext(2029, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(2036, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4686d04d9a3d3eae2562393091ec7cbbc315e28411702", async() => {
                BeginContext(2058, 12, true);
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
            BeginContext(2074, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Biblioteka.Web.DAL.Entities.Autor> Html { get; private set; }
    }
}
#pragma warning restore 1591
