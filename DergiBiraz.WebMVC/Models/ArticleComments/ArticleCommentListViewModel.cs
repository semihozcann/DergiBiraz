using DergiBiraz.Entities.Concrete;
using System.Collections.Generic;

namespace DergiBiraz.WebMVC.Models.ArticleComments
{
    public class ArticleCommentListViewModel : BaseViewModel
    {
        public List<ArticleComment> ArticleComments { get; set; }
    }
}
