using DergiBiraz.WebMVC.Helpers.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace DergiBiraz.WebMVC.Areas.Users.Controllers
{
    public class DashboardController : BaseController
    {
        public DashboardController(IUserAccessor userAccessor) : base(userAccessor)
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
