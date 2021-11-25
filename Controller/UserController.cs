using System;
using System.Collections.Generic;
using System.Data.Entity;
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
                Address = nu.Adress,
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
                ini.Write("Budget", registeredUser.Budget.ToString());
                ini.Write("Address", registeredUser.Address);
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
            string budget = ini.Read("Budget");
            string email = ini.Read("Email");
            string address = ini.Read("Address");
            string password = ini.Read("Password");
            string isSeller = ini.Read("IsSeller");

            if (String.IsNullOrEmpty(id)) return null;
            int Id = Convert.ToInt32(id);
            using (var tempContext = new DataContext())
            {
                User updatedUser = tempContext.Users.FirstOrDefault(i => i.Id == Id);
                ini.Write("Budget", updatedUser != null ? updatedUser.Budget.ToString() : budget);
                User user = new User()
                {
                    Id = Id,
                    Name = name,
                    Surname = surname,
                    Email = email,
                    Budget = updatedUser != null ? updatedUser.Budget : Convert.ToDouble(budget),
                    Address = address,
                    Password = password,
                    IsSeller = Convert.ToBoolean(isSeller),
                };

                return user;
            }
        }

        public void DeleteLocalData()
        {
            IniFile ini = new IniFile(userFile);
            if (File.Exists(userFile))
            {
                string logCondition = ini.Read("KeepMeLoggedIn");
                bool keepMeLoggedIn = Convert.ToBoolean(String.IsNullOrEmpty(logCondition) ? "false" : logCondition);
                if (!keepMeLoggedIn) File.Delete(userFile);
            }
        }

        public void Logout()
        {
            if (File.Exists(userFile)) File.Delete(userFile);
        }

        public void DeleteUser()
        {
            IniFile ini = new IniFile(userFile);
            string id = ini.Read("Id");
            int Id = Convert.ToInt32(id);
            var user = _context.Users.FirstOrDefault(i => i.Id == Id);
            if (user != null)
            {
                var books = _context.Books.Include(i => i.User).Include(i => i.Image).Where(i => i.UserId == user.Id).ToList();
                foreach (var book in books)
                {
                    _context.Images.Remove(book.Image);
                    _context.Books.Remove(book);
                }

                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }

        public void Terminate()
        {
            _context.Dispose();
        }
    }
}
