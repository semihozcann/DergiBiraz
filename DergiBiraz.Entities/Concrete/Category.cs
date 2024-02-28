using DergiBiraz.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DergiBiraz.Entities.Concrete
{
    public class Category : BaseEntitiy<int>
    {
        public string Name { get; set; }

        public List<Article> Articles { get; set; }


    }
}
