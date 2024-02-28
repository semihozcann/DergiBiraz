using DergiBiraz.Entities.Concrete;
using System.Collections.Generic;

namespace DergiBiraz.WebMVC.Models.Writers
{
    public class WriterListViewModel : BaseViewModel
    {
        public List<Writer> Writers { get; set; }
    }
}
