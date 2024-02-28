using DergiBiraz.Entities.Concrete;
using System.Collections.Generic;

namespace DergiBiraz.WebMVC.Models.Categories
{
    public class CategoryListViewModel : BaseViewModel
    {
        public List<Category> Categories { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
