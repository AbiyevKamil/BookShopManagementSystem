using System;
using System.Collections.Generic;
using System.IO;
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
        private readonly string userFile = "userData.ini";

        public UserController()
        {
            if (!File.Exists(userFile))
            {
                var file = File.Create(userFile);
                file.Close();
            }
        }

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
                IniFile ini = new IniFile(userFile);
                ini.Write("Id", registeredUser.Id.ToString());
                ini.Write("Name", registeredUser.Name);
                ini.Write("Surname", registeredUser.Surname);
                ini.Write("Adress", registeredUser.Adress);
                ini.Write("Email", registeredUser.Email);
                ini.Write("Password", registeredUser.Password);
                ini.Write("IsSeller", registeredUser.IsSeller.ToString());
                ini.Write("KeepMeLoggedIn", lm.KeepMeLoggedIn.ToString());
                return true;
            }

            return false;
        }

        public dynamic GetUserDataFromLocal()
        {
            IniFile ini = new IniFile(userFile);
            string id = ini.Read("Id");
            string name = ini.Read("Name");
            string surname = ini.Read("Surname");
            string email = ini.Read("Email");
            string adress = ini.Read("Adress");
            string password = ini.Read("Password");
            string isSeller = ini.Read("IsSeller");

            if (String.IsNullOrEmpty(id)) return null;

            User user = new User()
            {
                Id = Convert.ToInt32(id),
                Name = name,
                Surname = surname,
                Email = email,
                Adress = adress,
                Password = password,
                IsSeller = Convert.ToBoolean(isSeller)
            };

            return user;
        }

        public void DeleteLocalData()
        {
            IniFile ini = new IniFile(userFile);
            bool keepMeLoggedIn = Convert.ToBoolean(ini.Read("KeepMeLoggedIn"));
            if (File.Exists(userFile) && !keepMeLoggedIn) File.Delete(userFile);
        }
    }
}
