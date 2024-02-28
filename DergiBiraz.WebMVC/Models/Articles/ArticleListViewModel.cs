using DergiBiraz.Entities.Concrete;
using System.Collections.Generic;

namespace DergiBiraz.WebMVC.Models.Articles
{
    public class ArticleListViewModel : BaseViewModel
    {
        public List<Article> Articles { get; set; }

        public int Page { get; set; }

        public int TotalPage { get; set; }

    }
}
