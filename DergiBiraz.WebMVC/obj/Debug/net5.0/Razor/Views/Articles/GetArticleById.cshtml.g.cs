#pragma checksum "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Views\Articles\GetArticleById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39c35a47fdf223bcf1cfbdb1a4cac35cd6a055c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Articles_GetArticleById), @"mvc.1.0.view", @"/Views/Articles/GetArticleById.cshtml")]
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
#line 1 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Views\_ViewImports.cshtml"
using DergiBiraz.WebMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Views\_ViewImports.cshtml"
using DergiBiraz.WebMVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Views\_ViewImports.cshtml"
using DergiBiraz.WebMVC.Helpers.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Views\_ViewImports.cshtml"
using DergiBiraz.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c35a47fdf223bcf1cfbdb1a4cac35cd6a055c0", @"/Views/Articles/GetArticleById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a510c576420d63530b513dffc80185a1099b655", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Articles_GetArticleById : DergiBiraz.WebMVC.Helpers.Concrete.BaseViewPage<DergiBiraz.WebMVC.Models.Articles.ArticleDetailViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Views\Articles\GetArticleById.cshtml"
  
    ViewData["Title"] = "GetArticleById";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"tada-container content-posts post post-full-width\">\r\n\r\n\r\n    <!-- CONTENT -->\r\n    <div class=\"content col-xs-12\">\r\n\r\n\r\n        <!-- ARTICLE 1 -->\r\n        <article>\r\n");
#nullable restore
#line 16 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Views\Articles\GetArticleById.cshtml"
             if (Model.Article.ImageUrl != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"post-image\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 478, "\"", 507, 1);
#nullable restore
#line 19 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Views\Articles\GetArticleById.cshtml"
WriteAttributeValue("", 484, Model.Article.ImageUrl, 484, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"post image 1\">\r\n                </div>\r\n");
#nullable restore
#line 21 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Views\Articles\GetArticleById.cshtml"
                
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"category\">\r\n                <a href=\"#\">");
#nullable restore
#line 24 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Views\Articles\GetArticleById.cshtml"
                       Write(Model.Article.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </div>\r\n            <div class=\"post-text\">\r\n                <span class=\"date\">");
#nullable restore
#line 27 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Views\Articles\GetArticleById.cshtml"
                              Write(Model.Article.CreatedDate.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                <h2>");
#nullable restore
#line 28 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Views\Articles\GetArticleById.cshtml"
               Write(Model.Article.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            </div>\r\n            <div class=\"post-text text-content\">\r\n                <div class=\"post-by\">Yazar: ");
#nullable restore
#line 31 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Views\Articles\GetArticleById.cshtml"
                                       Write(Model.Article.Writer.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 31 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Views\Articles\GetArticleById.cshtml"
                                                                       Write(Model.Article.Writer.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"text\">\r\n                    <p>");
#nullable restore
#line 33 "C:\Users\semih\Desktop\DergiBiraz\DergiBiraz.WebMVC\Views\Articles\GetArticleById.cshtml"
                  Write(Html.Raw(Model.Article.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

                    <div class=""clearfix""></div>
                </div>
            </div>
            <div class=""social-post"">
                <a href=""#""><i class=""icon-facebook5""></i></a>
                <a href=""#""><i class=""icon-twitter4""></i></a>
                <a href=""#""><i class=""icon-google-plus""></i></a>
                <a href=""#""><i class=""icon-vimeo4""></i></a>
                <a href=""#""><i class=""icon-linkedin2""></i></a>
            </div>


            <!-- NAVIGATION POST -->
            <div class=""navigation-post"">
                <div class=""prev-post"">
                    <img src=""img/prev-post.jpg"">
                    <a href=""#"" class=""prev"">
                        <i class=""icon-arrow-left8""></i> Previous Posts
                        <span class=""name-post"">DUIS FACILISIS AUGUE VITAE</span>
                    </a>
                    <div class=""clearfix""></div>
                </div>
                <div class=""next-post"">
                    <a h");
            WriteLiteral(@"ref=""#"" class=""next"">
                        Next Posts <i class=""icon-arrow-right8""></i>
                        <span class=""name-post"">DUIS FACILISIS AUGUE VITAE</span>
                    </a>
                    <img src=""img/next-post.jpg"">
                    <div class=""clearfix""></div>
                </div>
                <div class=""clearfix""></div>
            </div>

            <!-- COMMENTS -->
            <div class=""comments"">
                <h3>3 Comments</h3>
                <div class=""comments-list"">
                    <div class=""main-comment"">
                        <div class=""comment-info"">
                            <div class=""comment-name-date""><span class=""comment-name"">LUCAS NEWAR</span><span class=""comment-date"">June 2, 2016</span><div class=""clearfix""></div></div>
                            <span class=""comment-description"">Morbi gravida, sem non egestas ullamcorper, tellus ante laoreet nisl, id iaculis urna eros vel turpis curabitur. Donec in dui vitae ");
            WriteLiteral(@"tellus sodales dapibus non quis libero. Quisque nec tortor ac ligula sagittis rutrum in a felis. <i class=""icon-arrow-right2""></i></span>
                        </div>
                        <div class=""clearfix""></div>
                    </div>
                </div>
            </div>
        </article>
    </div>
</section>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DergiBiraz.WebMVC.Models.Articles.ArticleDetailViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
