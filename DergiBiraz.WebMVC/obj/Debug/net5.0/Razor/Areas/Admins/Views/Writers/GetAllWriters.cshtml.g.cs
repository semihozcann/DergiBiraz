#pragma checksum "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Writers\GetAllWriters.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3826ff70a97bf50de8d2941b8e1a59399cd764aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admins_Views_Writers_GetAllWriters), @"mvc.1.0.view", @"/Areas/Admins/Views/Writers/GetAllWriters.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3826ff70a97bf50de8d2941b8e1a59399cd764aa", @"/Areas/Admins/Views/Writers/GetAllWriters.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dab17f0787b5e46648fddea048862c38759ceb0", @"/Areas/Admins/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admins_Views_Writers_GetAllWriters : DergiBiraz.WebMVC.Helpers.Concrete.BaseViewPage<DergiBiraz.WebMVC.Models.Writers.WriterListViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Writers\GetAllWriters.cshtml"
  
    ViewData["Title"] = "GetAllWriters";
    Layout = "~/Areas/Admins/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main id=""main"" class=""main"">

    <section class=""section"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""card"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Yazarlar Listesi</h5>
");
#nullable restore
#line 16 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Writers\GetAllWriters.cshtml"
                         if (Model != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <!-- Table with stripped rows -->
                            <table class=""table datatable"" id=""writersTable"">
                                <thead>
                                    <tr>
                                        <th scope=""col"">ID</th>
                                        <th scope=""col"">Adı</th>
                                        <th scope=""col"">Soyadı</th>
                                        <th scope=""col"">Açıklaması</th>
                                        <th scope=""col"">Mesleği</th>
                                        <th scope=""col"">Instagram Hesabı</th>
                                        <th scope=""col"">Twitter Hesabı</th>
                                        <th scope=""col"">Facebook Hesabı</th>
                                        <th scope=""col"">LinkedIn Hesabı</th>
                                        <th scope=""col"">Yazarın Eklenme Tarihi</th>
                                        <th scope=""col"">Gün");
            WriteLiteral("celle</th>\r\n                                        <th scope=\"col\">Sil</th>\r\n                                    </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Writers\GetAllWriters.cshtml"
                                     foreach (var writer in Model.Writers)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <th scope=\"row\">");
#nullable restore
#line 40 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Writers\GetAllWriters.cshtml"
                                                       Write(writer.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <td>");
#nullable restore
#line 41 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Writers\GetAllWriters.cshtml"
                                           Write(writer.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 42 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Writers\GetAllWriters.cshtml"
                                           Write(writer.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 43 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Writers\GetAllWriters.cshtml"
                                           Write(writer.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 44 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Writers\GetAllWriters.cshtml"
                                           Write(writer.Job);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td><a");
            BeginWriteAttribute("href", " href=\"", 2329, "\"", 2356, 1);
#nullable restore
#line 45 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Writers\GetAllWriters.cshtml"
WriteAttributeValue("", 2336, writer.InstagramUrl, 2336, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" class=\"instagram\"><i class=\"bi bi-instagram\"></i></a></td>\r\n                                            <td><a");
            BeginWriteAttribute("href", " href=\"", 2484, "\"", 2509, 1);
#nullable restore
#line 46 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Writers\GetAllWriters.cshtml"
WriteAttributeValue("", 2491, writer.TwitterUrl, 2491, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" class=\"twitter\"><i class=\"bi bi-twitter\"></i></a></td>\r\n                                            <td><a");
            BeginWriteAttribute("href", " href=\"", 2633, "\"", 2659, 1);
#nullable restore
#line 47 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Writers\GetAllWriters.cshtml"
WriteAttributeValue("", 2640, writer.FacebookUrl, 2640, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" class=\"facebook\"><i class=\"bi bi-facebook\"></i></a></td>\r\n                                            <td><a");
            BeginWriteAttribute("href", " href=\"", 2785, "\"", 2811, 1);
#nullable restore
#line 48 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Writers\GetAllWriters.cshtml"
WriteAttributeValue("", 2792, writer.LinkedInUrl, 2792, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" class=\"linkedin\"><i class=\"bi bi-linkedin\"></i></a></td>\r\n                                            <td>");
#nullable restore
#line 49 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Writers\GetAllWriters.cshtml"
                                           Write(writer.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td><a type=\"button\"");
            BeginWriteAttribute("href", " href=\"", 3025, "\"", 3065, 2);
            WriteAttributeValue("", 3032, "/Admins/Writers/Update/", 3032, 23, true);
#nullable restore
#line 50 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Writers\GetAllWriters.cshtml"
WriteAttributeValue("", 3055, writer.Id, 3055, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Güncelle</a></td>\r\n                                            <td><a type=\"submit\" onclick=\"submitResult(event)\" data-writer-id=\"");
#nullable restore
#line 51 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Writers\GetAllWriters.cshtml"
                                                                                                          Write(writer.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" id=\"btn-delete\"");
            BeginWriteAttribute("href", " href=\"", 3256, "\"", 3296, 2);
            WriteAttributeValue("", 3263, "/Admins/Writers/Delete/", 3263, 23, true);
#nullable restore
#line 51 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Writers\GetAllWriters.cshtml"
WriteAttributeValue("", 3286, writer.Id, 3286, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                                        </tr>\r\n");
#nullable restore
#line 53 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Writers\GetAllWriters.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                            <!-- End Table with stripped rows -->\r\n");
#nullable restore
#line 57 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Writers\GetAllWriters.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>Hiç Yazar Bulunamadı</p>\r\n");
#nullable restore
#line 61 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Areas\Admins\Views\Writers\GetAllWriters.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
    </section>

    <script>

        function submitResult(e) {
            e.preventDefault();
            const writerId = e.target.getAttribute(""data-writer-id"");
            if (!writerId) {
                console.error(""Veri kimliği alınamadı."");
                return;
            }

            Swal.fire({
                title: 'Yazarı Silmek İstediğinize Emin Misiniz?',
                text: ""Eğer kabul ederseniz seçtiğiniz yazar silinecektir."",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Evet Kabul Ediyorum',
                cancelButtonText: 'Vazgeç',
            }).then((result) => {
                if (result.isConfirmed) {
                    fetch(`/Admins/Writers/Delete/${writerId}`, {
                        method: 'DELETE',
            WriteLiteral(@"
                    });
                    Swal.fire(
                        'Yazar Silindi',
                        'Seçili yazar başarıyla silinmiştir',
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DergiBiraz.WebMVC.Models.Writers.WriterListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591