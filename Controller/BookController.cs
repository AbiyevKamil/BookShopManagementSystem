using System;
using System.Collections.Generic;
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

        public void AddBook(Book book, ImageModel image)
        {
            book.AddedDate = DateTime.Now;
            _context.Images.Add(image);
            book.ImageId = image.Id;
            _context.Books.Add(book);
            _context.SaveChanges();
        }

    }
}
