using DergiBiraz.Entities.Concrete;
using System.Collections.Generic;

namespace DergiBiraz.WebMVC.Models.Users
{
    public class UserListViewModel : BaseViewModel
    {
        public List<User> Users { get; set; }
    }
}
