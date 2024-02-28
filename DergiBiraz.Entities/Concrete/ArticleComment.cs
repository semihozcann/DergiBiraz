using DergiBiraz.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DergiBiraz.Entities.Concrete
{
    public class ArticleComment : BaseEntitiy<int>
    {
        public int UserId { get; set; }
        public int ArticleId { get; set; }
        public string Content { get; set; }
        public bool Assent { get; set; } = false;

        public User User { get; set; }
        public Article Article { get; set; }


    }
}
