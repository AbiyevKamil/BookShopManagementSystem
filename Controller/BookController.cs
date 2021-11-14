using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    }
}
