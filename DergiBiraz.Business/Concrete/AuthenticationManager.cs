﻿using DergiBiraz.Business.Abstract;
using DergiBiraz.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DergiBiraz.Business.Concrete
{
    public class AuthenticationManager : IAuthenticationService
    {
        protected SignInManager<User> _singManager;
        protected UserManager<User> _userManager;
        protected RoleManager<Role> _roleManager;


        public AuthenticationManager(SignInManager<User> singManager, UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            _singManager = singManager;
            _userManager = userManager;
            _roleManager = roleManager;
        }


        public User AuthenticateUser(string userName, string password)
        {

            var result = _singManager.PasswordSignInAsync(userName, password, false, lockoutOnFailure: false).Result;

            if (result.Succeeded)
            {
                var user = _userManager.FindByNameAsync(userName).Result;
                var roles = _userManager.GetRolesAsync(user).Result;
                user.Roles = roles.ToArray();
                return user;
            }
            return null;

        }

        public bool ComfirmCode(string userCode)
        {
            var comfirmationCode = "2242348";

            for (int i = 0; i < userCode.Length; i++)
            {
                if (comfirmationCode[i] != userCode[i])
                {
                    return false;
                }
            }
            return true;


        }

        //todo: ıdentity yapısı düzgün calısmamaktadır. login haric diğer tüm metotları refactoring yapılmalıdır. 

        public bool CreateUser(User user, string password)
        {
            var result = _userManager.CreateAsync(user, password).Result;
            if (result.Succeeded)
            {

                var res = _userManager.AddToRoleAsync(user, "User").Result;
                if (res.Succeeded)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CreateUserForAdmin(User user, string password, string userCode)
        {
            var userCodeResult =  ComfirmCode(userCode);

            if (userCodeResult != false)
            {
                var result = _userManager.CreateAsync(user, password).Result;
                if (result.Succeeded)
                {

                    var res = _userManager.AddToRoleAsync(user, "Admin").Result;
                    if (res.Succeeded)
                    {
                        return true;
                    }
                }
                return false;
            }
            return false;
        }



        public User GetUser(string username)
        {
            return _userManager.FindByNameAsync(username).Result;

        }

        public async Task<bool> SignOut()
        {
            //SingOut yapısı hata mekanızması gonderir hale getirmelidir. geriye muhakak bir değer donmelidir. ve bu değer işlemin hatalı oldugunu göstermelidir. 

            await _singManager.SignOutAsync();
            return true;


        }
    }
}
