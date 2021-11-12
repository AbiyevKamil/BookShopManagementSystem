using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagementSystem.Model
{
    class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Author { get; set; }
        public string Category { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime PublishedDate { get; set; }
        public string Language { get; set; }
        [Required]
        public DateTime AddedDate { get; set; }
        [Required]
        public int Stock { get; set; }
        [Required]
        public double Price { get; set; }

        //  Seller stuffs here
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
