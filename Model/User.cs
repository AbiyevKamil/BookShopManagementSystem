using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagementSystem.Model
{
    class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public bool IsSeller { get; set; }
        [Required]
        public double Budget { get; set; }


        public List<Book> SellingBooks { get; set; }
        public List<Book> BoughtBooks { get; set; }

    }
}
