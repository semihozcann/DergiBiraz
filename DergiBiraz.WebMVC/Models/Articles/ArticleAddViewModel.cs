using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace DergiBiraz.WebMVC.Models.Articles
{
    public class ArticleAddViewModel : BaseViewModel
    {
        public int WriterId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }


        public string Content { get; set; }
        public IFormFile ImageUrl { get; set; }

        public List<SelectListItem> WritersForDr { get; set; }
        public List<SelectListItem> CategoriesForDr { get; set; }
    }
}
