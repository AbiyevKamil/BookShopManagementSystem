using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShopManagementSystem.Helper;
using BookShopManagementSystem.Model;

namespace BookShopManagementSystem.Controller
{
    class BookController
    {
        private readonly DataContext _context = new DataContext();
        private readonly string userFile = "userData.ini";

        public BookController()
        {
            if (!File.Exists(userFile))
            {
                var file = File.Create(userFile);
                file.Close();
            }
        }

        public List<Book> GetAllBooks()
        {
            return _context.Books.Include(i => i.Image).ToList();
        }

        public void AddBook(Book book, ImageModel image)
        {
            book.AddedDate = DateTime.Now;
            _context.Images.Add(image);
            book.ImageId = image.Id;
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public dynamic GetUserBooks()
        {
            int Id;
            IniFile ini = new IniFile(userFile);
            string id = ini.Read("Id");
            if (id != null)
            {
                Id = Convert.ToInt32(id);
                using (var upContext = new DataContext())
                {
                    var books = upContext.Books.Include(i => i.User).Where(i => i.User.Id == Id).Include(i => i.Image).ToList();
                    return books;
                }
            }
            return null;
        }

        public bool UpdateBook(Book book)
        {
            var sb = _context.Books.Include(i => i.Image).Include(i => i.User).FirstOrDefault(i => i.Id == book.Id);
            if (sb != null)
            {
                if (book.Image != null) sb.Image = book.Image;
                sb.Author = sb.Author;
                sb.Name = book.Name;
                sb.Description = book.Description;
                sb.Language = book.Language;
                sb.PublishedDate = book.PublishedDate;
                sb.Stock = book.Stock;
                sb.Price = book.Price;
                sb.Category = book.Category;
                sb.PublishedDate = book.PublishedDate;
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public dynamic GetBookById(int id)
        {
            var book = _context.Books.Include(i => i.User).Include(i => i.Image).FirstOrDefault(i => i.Id == id);
            return book;
        }

        public List<Book> GetBookByQuery(string query, string type, string inStock)
        {
            bool stock = false;
            switch (inStock)
            {
                case "All":
                    if (String.IsNullOrEmpty(query))
                    {
                        return _context.Books.Include(i => i.Image).ToList();
                    }
                    switch (type)
                    {
                        case "Name":
                            return _context.Books.Include(i => i.Image).Where(i => i.Name.Contains(query)).ToList();
                        case "Author":
                            return _context.Books.Include(i => i.Image).Where(i => i.Author.Contains(query)).ToList();
                        case "Category":
                            return _context.Books.Include(i => i.Image).Where(i => i.Category.Contains(query)).ToList();
                        case "Language":
                            return _context.Books.Include(i => i.Image).Where(i => i.Language.Contains(query)).ToList();
                        default:
                            return _context.Books.Include(i => i.Image).ToList();
                    }
                case "In Stock":
                    stock = true;
                    break;
                case "Out of Stock":
                    stock = false;
                    break;
                default:
                    stock = true;
                    break;
            }

            if (String.IsNullOrEmpty(query))
                return _context.Books.Include(i => i.Image)
                                    .Where(i => stock ? i.Stock > 0 : i.Stock == 0)
                                    .ToList();


            switch (type)
            {
                case "Name":
                    return _context.Books.Include(i => i.Image).Where(i => i.Name.Contains(query) && (stock ? i.Stock > 0 : i.Stock == 0)).ToList();
                case "Author":
                    return _context.Books.Include(i => i.Image).Where(i => i.Author.Contains(query) && (stock ? i.Stock > 0 : i.Stock == 0)).ToList();
                case "Category":
                    return _context.Books.Include(i => i.Image).Where(i => i.Category.Contains(query) && (stock ? i.Stock > 0 : i.Stock == 0)).ToList();
                case "Language":
                    return _context.Books.Include(i => i.Image).Where(i => i.Language.Contains(query) && (stock ? i.Stock > 0 : i.Stock == 0)).ToList();
                default:
                    return _context.Books.Include(i => i.Image).Where(i => stock ? i.Stock > 0 : i.Stock == 0).ToList();
            }
        }

        public bool BuyBook(int BookId)
        {
            Book book = _context.Books.Include(i => i.Image)
                                        .Include(i => i.User)
                                        .FirstOrDefault(i => i.Id == BookId);
            if (book == null) return false;
            IniFile ini = new IniFile(userFile);
            string id = ini.Read("Id");
            if (id != null)
            {
                int Id = Convert.ToInt32(id);
                User user = _context.Users.FirstOrDefault(i => i.Id == Id);
                if (user != null)
                {
                    if (book.User.Id != user.Id)
                    {
                        if (user.Budget >= book.Price)
                        {
                            user.Budget -= book.Price;
                            book.Stock -= 1;
                            AddToDesktop(book);
                            _context.SaveChanges();
                            return true;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        public void AddToDesktop(Book book)
        {
            string bookDirectory = $@"C:/Users/{Environment.UserName}/Desktop/BookShop/{book.Name}";
            string bookFile = $@"C:/Users/{Environment.UserName}/Desktop/BookShop/{book.Name}/{book.Name}.txt";
            string bookImg = $@"C:/Users/{Environment.UserName}/Desktop/BookShop/{book.Name}/{book.Name}.{book.Image.ImageFormat}";
            string shopDirectory = $@"C:/Users/{Environment.UserName}/Desktop/BookShop";
            if (!Directory.Exists(shopDirectory))
            {
                Directory.CreateDirectory(shopDirectory);
            }

            if (!Directory.Exists(bookDirectory))
            {
                Directory.CreateDirectory(bookDirectory);
            }
            if (!File.Exists(bookFile))
            {
                var file = File.Create(bookFile);
                file.Close();
            }
            if (!File.Exists(bookImg))
            {
                var file = File.Create(bookImg);
                file.Close();
            }
            string bookData = $"{book.Name}\n{book.Author}\n{book.PublishedDate.ToString("yyyy MMMM dd")}\n{book.Description}";
            File.WriteAllText(bookFile, bookData);
        }

        public bool DeleteBookById(int id)
        {
            var book = _context.Books.FirstOrDefault(i => i.Id == id);
            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }

            return false;
        }


    }
}
