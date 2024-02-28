using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DergiBiraz.Core.Entities
{
    public class BaseEntitiy<T>
    {
        public T Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }

    }
}
