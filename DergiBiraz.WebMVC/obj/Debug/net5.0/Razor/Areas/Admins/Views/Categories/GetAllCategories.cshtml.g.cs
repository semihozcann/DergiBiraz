#pragma checksum "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Categories\GetAllCategories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88b5dc0af1bdb4dfe4153f4962108a83405f326f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admins_Views_Categories_GetAllCategories), @"mvc.1.0.view", @"/Areas/Admins/Views/Categories/GetAllCategories.cshtml")]
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
#line 1 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\_ViewImports.cshtml"
using DergiBiraz.WebMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\_ViewImports.cshtml"
using DergiBiraz.WebMVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\_ViewImports.cshtml"
using DergiBiraz.WebMVC.Helpers.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\_ViewImports.cshtml"
using DergiBiraz.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88b5dc0af1bdb4dfe4153f4962108a83405f326f", @"/Areas/Admins/Views/Categories/GetAllCategories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dab17f0787b5e46648fddea048862c38759ceb0", @"/Areas/Admins/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admins_Views_Categories_GetAllCategories : DergiBiraz.WebMVC.Helpers.Concrete.BaseViewPage<DergiBiraz.WebMVC.Models.Categories.CategoryListViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Kategori Adı"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row g-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Categories", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Yeni Kategori Adı"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Categories\GetAllCategories.cshtml"
  
    ViewData["Title"] = "GetAllCategories";
    Layout = "~/Areas/Admins/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main id=\"main\" class=\"main\">\r\n\r\n");
            WriteLiteral(@"    <div class=""card"">
        <div class=""card-body"">
            <h5 class=""card-title"">Kategori Ekle</h5>
            <p>Yeni Kategori Eklemek İçin Tıklayın</p>

            <!-- Vertically centered Modal -->
            <button type=""button"" class=""btn btn-primary"" data-bs-toggle=""modal"" data-bs-target=""#verticalycentered"">
                Ekle
            </button>
            <div class=""modal fade"" id=""verticalycentered"" tabindex=""-1"" style=""display: none;"" aria-hidden=""true"">
                <div class=""modal-dialog modal-dialog-centered"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h5 class=""modal-title"">Kategori Adını Yazın</h5>
                            <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                        </div>
                        <div class=""modal-body"">
                            <!-- Vertical Form -->
                       ");
            WriteLiteral("     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88b5dc0af1bdb4dfe4153f4962108a83405f326f9800", async() => {
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88b5dc0af1bdb4dfe4153f4962108a83405f326f10090", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 29 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Categories\GetAllCategories.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                <div class=\"col-12\">\r\n                                    <label for=\"inputNanme4\" class=\"form-label\">Kategori Adı</label>\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "88b5dc0af1bdb4dfe4153f4962108a83405f326f11986", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 32 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Categories\GetAllCategories.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88b5dc0af1bdb4dfe4153f4962108a83405f326f14010", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 33 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Categories\GetAllCategories.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </div>
                                <div class=""modal-footer"">
                                    <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Vazgeç</button>
                                    <button type=""submit"" class=""btn btn-primary"" value=""Add"">Ekle</button>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<!-- Vertical Form -->\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div><!-- End Vertically centered Modal-->\r\n\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("    <section class=\"section\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-12\">\r\n                <div class=\"card\">\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">Kategoriler Listesi</h5>\r\n");
#nullable restore
#line 56 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Categories\GetAllCategories.cshtml"
                         if (Model != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <!-- Table with stripped rows -->
                            <table class=""table datatable"" id=""categoriesTable"">
                                <thead>
                                    <tr>
                                        <th scope=""col"">ID</th>
                                        <th scope=""col"">Categori Adı</th>
                                        <th scope=""col"">Eklenme Tarihi</th>
                                        <th scope=""col"">Güncelle</th>
                                        <th scope=""col"">Sil</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 70 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Categories\GetAllCategories.cshtml"
                                     foreach (var category in Model.Categories)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <th scope=\"row\">");
#nullable restore
#line 73 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Categories\GetAllCategories.cshtml"
                                                       Write(category.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <td>");
#nullable restore
#line 74 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Categories\GetAllCategories.cshtml"
                                           Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 75 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Categories\GetAllCategories.cshtml"
                                           Write(category.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td><button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4038, "\"", 4095, 6);
            WriteAttributeValue("", 4048, "showUpdateModal(", 4048, 16, true);
#nullable restore
#line 76 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Categories\GetAllCategories.cshtml"
WriteAttributeValue("", 4064, category.Id, 4064, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4076, ",", 4076, 1, true);
            WriteAttributeValue(" ", 4077, "\'", 4078, 2, true);
#nullable restore
#line 76 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Categories\GetAllCategories.cshtml"
WriteAttributeValue("", 4079, category.Name, 4079, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4093, "\')", 4093, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Güncelle</button></td>\r\n\r\n                                            <td><a type=\"submit\" onclick=\"submitResult(event)\" data-category-id=\"");
#nullable restore
#line 78 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Categories\GetAllCategories.cshtml"
                                                                                                            Write(category.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" id=\"btn-delete\"");
            BeginWriteAttribute("href", " href=\"", 4297, "\"", 4342, 2);
            WriteAttributeValue("", 4304, "/Admins/Categories/Delete/", 4304, 26, true);
#nullable restore
#line 78 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Categories\GetAllCategories.cshtml"
WriteAttributeValue("", 4330, category.Id, 4330, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                                        </tr>\r\n");
#nullable restore
#line 80 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Categories\GetAllCategories.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                            <!-- End Table with stripped rows -->\r\n");
#nullable restore
#line 84 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Categories\GetAllCategories.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>Hiç Yazar Bulunamadı</p>\r\n");
#nullable restore
#line 88 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Categories\GetAllCategories.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"    <div class=""modal fade"" id=""updateCategory"" tabindex=""-1"" style=""display: none;"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Kategorinin Yeni Adını Yazın</h5>
                    <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                </div>
                <div class=""modal-body"">
                    <!-- Vertical Form -->
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88b5dc0af1bdb4dfe4153f4962108a83405f326f24766", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88b5dc0af1bdb4dfe4153f4962108a83405f326f25049", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 109 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Categories\GetAllCategories.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <div class=\"col-12\">\r\n                            <label for=\"inputNanme4\" class=\"form-label\">Yeni Kategori Adı</label>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "88b5dc0af1bdb4dfe4153f4962108a83405f326f26927", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 112 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Categories\GetAllCategories.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88b5dc0af1bdb4dfe4153f4962108a83405f326f28945", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 113 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Categories\GetAllCategories.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Vazgeç</button>
                            <button type=""submit"" class=""btn btn-primary"" value=""Update"">Güncelle</button>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<!-- Vertical Form -->\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div><!-- End Vertically centered Modal-->\r\n");
            WriteLiteral(@"

    <script>

        function showUpdateModal(categoryId, categoryName) {
            debugger;
            // Kategori bilgilerini modal içine doldur
            document.getElementById(""Name"").value = categoryName; // Yeni kategori adı alanına bilgiyi yerleştir
            var updateForm = document.querySelector(""#updateCategory form"");
            updateForm.action = `/Admins/Categories/Update/${categoryId}`; // Formun gönderileceği URL'yi güncelle

            // Modalı göster
            var updateCategoryModal = new bootstrap.Modal(document.getElementById(""updateCategory""));
            updateCategoryModal.show();
        }

        function submitResult(e) {
            e.preventDefault();
            const categoryId = e.target.getAttribute(""data-category-id"");
            if (!categoryId) {
                console.error(""Veri kimliği alınamadı."");
                return;
            }

            Swal.fire({
                title: 'Kategoriyi Silmek İstediğinize Emin Misi");
            WriteLiteral(@"niz?',
                text: ""Eğer kabul ederseniz seçtiğiniz kategori silinecektir."",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Evet Kabul Ediyorum',
                cancelButtonText: 'Vazgeç',
            }).then((result) => {
                if (result.isConfirmed) {
                    fetch(`/Admins/Categories/Delete/${categoryId}`, {
                        method: 'DELETE',
                    });
                    Swal.fire(
                        'Kategori Silindi',
                        'Seçili kategori başarıyla silinmiştir',
                        'success'
                    );
                    location.reload();
                }
            });
        }




    </script>


</main><!-- End #main -->

");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DergiBiraz.WebMVC.Models.Categories.CategoryListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591