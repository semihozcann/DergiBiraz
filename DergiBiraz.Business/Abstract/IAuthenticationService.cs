using DergiBiraz.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DergiBiraz.Business.Abstract
{
    public interface IAuthenticationService
    {
        bool CreateUser(User user, string password);
        Task<bool> SignOut();
        User AuthenticateUser(string userName, string password);
        User GetUser(string username);

        public bool ComfirmCode(string userCode);

        bool CreateUserForAdmin(User user, string password, string userCode);


    }
}
