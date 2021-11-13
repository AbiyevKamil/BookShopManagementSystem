using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BookShopManagementSystem.Helper;
using BookShopManagementSystem.Model;

namespace BookShopManagementSystem.Controller
{
    class UserController
    {
        private readonly DataContext _context = new DataContext();
        public bool AddUser(RegisterModel nu)
        {
            var oldUser = _context.Users.FirstOrDefault(i => i.Email == nu.Email);
            if (oldUser != null)
                return false;

            User user = new User()
            {
                Name = nu.Name,
                Surname = nu.Surname,
                Adress = nu.Adress,
                Email = nu.Email,
                Password = nu.Password,
                Budget = 2000,
                IsSeller = nu.IsSeller,
            };
            _context.Users.Add(user);
            _context.SaveChanges();
            return true;
        }

        public bool LoginUser(LoginModel lm)
        {
            User registeredUser = _context.Users.FirstOrDefault(i => i.Email.Equals(lm.Email) && i.Password.Equals(lm.Password));
            if (registeredUser != null)
            {
                IniFile ini = new IniFile("userData.ini");
                ini.Write("Id", registeredUser.Id.ToString());
                ini.Write("Name", registeredUser.Name);
                ini.Write("Surname", registeredUser.Surname);
                ini.Write("Email", registeredUser.Email);
                ini.Write("Password", registeredUser.Password);
                ini.Write("IsSeller", registeredUser.IsSeller.ToString());
                return true;
            }

            return false;
        }
    }
}
