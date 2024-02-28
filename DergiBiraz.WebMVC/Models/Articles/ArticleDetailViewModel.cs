using DergiBiraz.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace DergiBiraz.WebMVC.Models.Articles
{
    public class ArticleDetailViewModel : BaseViewModel
    {
        public Article Article { get; set; }
    }
}
