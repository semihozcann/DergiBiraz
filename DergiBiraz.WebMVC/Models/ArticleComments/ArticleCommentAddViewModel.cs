using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace DergiBiraz.WebMVC.Models.ArticleComments
{
    public class ArticleCommentAddViewModel : BaseViewModel
    {
        public int UserId { get; set; }
        public int ArticleId { get; set; }
        public string Content { get; set; }

    }
}
