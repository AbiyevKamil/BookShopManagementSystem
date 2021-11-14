using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopManagementSystem.Helper;

namespace BookShopManagementSystem.Model
{
    class DbInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            User user = new User()
            {
                Name = "Kamil",
                Surname = "Abiyev",
                Adress = "Baku, Ganjlik",
                Budget = 5000,
                Email = "kamil@gmail.com",
                IsSeller = true,
                Password = "123456"
            };
            context.Users.Add(user);
            context.SaveChanges();

            var bytes = ImageHelper.ImageToByteArray("./helper_images/dune.jpg");
            ImageModel im = new ImageModel()
            {
                Data = bytes,
                ImageFormat = ".jpg",
                Name = "dune",
            };
            context.Images.Add(im);
            context.SaveChanges();

            Book book = new Book()
            {
                Name = "Dune",
                Author = "Frank Herbert",
                AddedDate = DateTime.Now,
                Category = "Fiction",
                Description = "NOW A MAJOR MOTION PICTURE directed by Denis Villeneuve," +
                              " starring Timothée Chalamet, Zendaya, Jason Momoa, Rebecca Ferguson, Oscar Isaac, " +
                              "Josh Brolin, Stellan Skarsgård, Dave Bautista, Stephen McKinley Henderson, " +
                              "Chang Chen, Charlotte Rampling, and Javier Bardem.",
                Language = "English",
                Price = 11.10,
                PublishedDate = Convert.ToDateTime("September 01, 1990"),
                Stock = 5,
                UserId = user.Id,
                User = user,
                ImageId = im.Id,
            };
            context.Books.Add(book);
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
