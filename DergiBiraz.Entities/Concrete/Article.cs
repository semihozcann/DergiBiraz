using DergiBiraz.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DergiBiraz.Entities.Concrete
{
    public class Article : BaseEntitiy<int>
    {
        public int WriterId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }



        public Writer Writer { get; set; }
        public Category Category { get; set; }

        public List<ArticleComment> ArticleComments { get; set; }





    }
}
