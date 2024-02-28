using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace DergiBiraz.WebMVC.Models.Writers
{
    public class WriterAddViewModel : BaseViewModel
    {
        [Required(ErrorMessage = "Yazarın Adını Yazınız")]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Yazarın Soyadını Yazınız")]
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        [MaxLength(100)]
        public string InstagramUrl { get; set; }
        [MaxLength(100)]
        public string FacebookUrl { get; set; }
        [MaxLength(100)]
        public string TwitterUrl { get; set; }
        [MaxLength(100)]
        public string LinkedInUrl { get; set; }
        [MaxLength(100)]
        public string Job { get; set; }
    }
}
