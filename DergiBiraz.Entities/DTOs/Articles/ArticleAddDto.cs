using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DergiBiraz.Entities.DTOs.Articles
{
    public class ArticleAddDto
    {
        public int WriterId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
    }
}
