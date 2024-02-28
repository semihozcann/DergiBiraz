using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DergiBiraz.Entities.Concrete
{
    public class User : IdentityUser<int>
    {

        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;


        [NotMapped]
        //Role:User,Admin 
        public string[] Roles { get; set; }

    }
}
