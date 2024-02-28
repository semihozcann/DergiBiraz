using System.ComponentModel.DataAnnotations;

namespace DergiBiraz.WebMVC.Models.Users
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Lütfen Eposta hesabınızı yazınız")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi yazınız")]
        public string Password { get; set; }

    }
}
