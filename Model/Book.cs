using System;
using System.ComponentModel.DataAnnotations;

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
        [Required]
        public string Category { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime PublishedDate { get; set; }
        //[Required]
        //public byte[] ImageBytes { get; set; }
        [Required]
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

        // Image saving
        public int ImageId { get; set; }
        public ImageModel Image { get; set; }

    }
}
