using DergiBiraz.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DergiBiraz.Entities.Concrete
{
    public class Writer : BaseEntitiy<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string InstagramUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string LinkedInUrl { get; set; }
        public string Job { get; set; }
        public string ImageUrl { get; set; }



        public List<Article> Articles { get; set; }



    }
}
