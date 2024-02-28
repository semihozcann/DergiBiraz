using DergiBiraz.Business.Abstract;
using DergiBiraz.Entities.Concrete;
using DergiBiraz.WebMVC.Helpers.Abstract;
using DergiBiraz.WebMVC.Models.Users;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DergiBiraz.WebMVC.Areas.Admins.Controllers
{
    public class UsersController : BaseController
    {

        private readonly IUserService _userService;
        private readonly IAuthenticationService _authenticationService;
        public UsersController(IUserAccessor userAccessor, IUserService userService, IAuthenticationService authenticationService) : base(userAccessor)
        {
            _userService = userService;
            _authenticationService = authenticationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetAllUsers(UserListViewModel userListViewModel)
        {
            var result = await _userService.GetAllAsync();

            if (result != null)
            {
                var users = new UserListViewModel
                {
                    Message = result.Message,
                    Users = result.Data
                };

                return View(users);
            }
            return View();
        }


        [HttpGet]
        public IActionResult SignUpForAdmin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUpForAdmin(SignUpAdminViewModel signUpAdminViewModel)
        {
            if (ModelState.IsValid)
            {

                User user = new User
                {
                    Name = signUpAdminViewModel.Name,
                    LastName = signUpAdminViewModel.LastName,
                    UserName = signUpAdminViewModel.Email,
                    Email = signUpAdminViewModel.Email,
                };
                bool result = _authenticationService.CreateUserForAdmin(user, signUpAdminViewModel.Password, signUpAdminViewModel.ComfirmationCode);
                if (result)
                {
                    return RedirectToAction("GetAllUsers");
                }
            }
            return View();
        }




    }
}
