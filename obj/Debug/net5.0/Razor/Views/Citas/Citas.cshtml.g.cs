#pragma checksum "C:\Users\User\Desktop\Optica\Views\Citas\Citas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42f82b9a7b9760e4f661078ee76cc4b6cac87514"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Citas_Citas), @"mvc.1.0.view", @"/Views/Citas/Citas.cshtml")]
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
#line 1 "C:\Users\User\Desktop\Optica\Views\_ViewImports.cshtml"
using Optica;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Optica\Views\_ViewImports.cshtml"
using Optica.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42f82b9a7b9760e4f661078ee76cc4b6cac87514", @"/Views/Citas/Citas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b007e9c115b60d60ceab9dbbf5ef47811c6b0a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Citas_Citas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Optica.Models.Citas>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NuevaCita", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Citas/BorrarCitas"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExportarExcel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\Desktop\Optica\Views\Citas\Citas.cshtml"
  
    
    Layout="_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Lista Citas</h2>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42f82b9a7b9760e4f661078ee76cc4b6cac875145105", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</p>\n<table class=\"table table-hover\">\n     <thead class=\"thead-dark\">\n        <tr>\n           \n                <th scope=\"col\">\n                    #\n                </th>\n                \n                <th scope=\"col\">\n                    ");
#nullable restore
#line 21 "C:\Users\User\Desktop\Optica\Views\Citas\Citas.cshtml"
               Write(Html.DisplayNameFor(model => model.TipoDeCita));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th scope=\"col\">\n                    ");
#nullable restore
#line 24 "C:\Users\User\Desktop\Optica\Views\Citas\Citas.cshtml"
               Write(Html.DisplayNameFor(model => model.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th scope=\"col\">\n                    ");
#nullable restore
#line 27 "C:\Users\User\Desktop\Optica\Views\Citas\Citas.cshtml"
               Write(Html.DisplayNameFor(model => model.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th scope=\"col\">\n                    ");
#nullable restore
#line 30 "C:\Users\User\Desktop\Optica\Views\Citas\Citas.cshtml"
               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th scope=\"col\">\n                    ");
#nullable restore
#line 33 "C:\Users\User\Desktop\Optica\Views\Citas\Citas.cshtml"
               Write(Html.DisplayNameFor(model => model.Celular));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th scope=\"col\">\n                    ");
#nullable restore
#line 36 "C:\Users\User\Desktop\Optica\Views\Citas\Citas.cshtml"
               Write(Html.DisplayNameFor(model => model.DNI));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th scope=\"col\">\n                    ");
#nullable restore
#line 39 "C:\Users\User\Desktop\Optica\Views\Citas\Citas.cshtml"
               Write(Html.DisplayNameFor(model => model.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                 <th scope=\"col\">\n                    ");
#nullable restore
#line 42 "C:\Users\User\Desktop\Optica\Views\Citas\Citas.cshtml"
               Write(Html.DisplayNameFor(model => model.Hora));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                 \n                 \n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 49 "C:\Users\User\Desktop\Optica\Views\Citas\Citas.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                \n                <th scope=\"row\">\n                    ");
#nullable restore
#line 54 "C:\Users\User\Desktop\Optica\Views\Citas\Citas.cshtml"
               Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \n                </th>\n                <td>\n                    ");
#nullable restore
#line 57 "C:\Users\User\Desktop\Optica\Views\Citas\Citas.cshtml"
               Write(Html.DisplayFor(modelItem => item.TipoDeCita));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 60 "C:\Users\User\Desktop\Optica\Views\Citas\Citas.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                 <td>\n                    ");
#nullable restore
#line 63 "C:\Users\User\Desktop\Optica\Views\Citas\Citas.cshtml"
               Write(Html.DisplayFor(modelItem => item.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                 <td>\n                    ");
#nullable restore
#line 66 "C:\Users\User\Desktop\Optica\Views\Citas\Citas.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                \n                <td>\n                    ");
#nullable restore
#line 70 "C:\Users\User\Desktop\Optica\Views\Citas\Citas.cshtml"
               Write(Html.DisplayFor(modelItem => item.Celular));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 73 "C:\Users\User\Desktop\Optica\Views\Citas\Citas.cshtml"
               Write(Html.DisplayFor(modelItem => item.DNI));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 76 "C:\Users\User\Desktop\Optica\Views\Citas\Citas.cshtml"
               Write(Html.DisplayFor(modelItem => item.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 79 "C:\Users\User\Desktop\Optica\Views\Citas\Citas.cshtml"
               Write(Html.DisplayFor(modelItem => item.Hora));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n\n                <a");
            BeginWriteAttribute("href", " href=\"", 2460, "\"", 2494, 2);
            WriteAttributeValue("", 2467, "/Citas/EditarCitas/", 2467, 19, true);
#nullable restore
#line 83 "C:\Users\User\Desktop\Optica\Views\Citas\Citas.cshtml"
WriteAttributeValue("", 2486, item.id, 2486, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary\">editar</a>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42f82b9a7b9760e4f661078ee76cc4b6cac8751412505", async() => {
                WriteLiteral("\n                <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 2667, "\"", 2683, 1);
#nullable restore
#line 85 "C:\Users\User\Desktop\Optica\Views\Citas\Citas.cshtml"
WriteAttributeValue("", 2675, item.id, 2675, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\n                    <button class=\"btn btn-danger\"> borrar</button>\n\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                \n                  </td>\n            </tr>\n");
#nullable restore
#line 92 "C:\Users\User\Desktop\Optica\Views\Citas\Citas.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42f82b9a7b9760e4f661078ee76cc4b6cac8751414850", async() => {
                WriteLiteral("Exporta a Excel");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Optica.Models.Citas>> Html { get; private set; }
    }
}
#pragma warning restore 1591
