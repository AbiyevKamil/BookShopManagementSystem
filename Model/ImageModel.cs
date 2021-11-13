using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagementSystem.Model
{
    class ImageModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ImageFormat { get; set; }
        [Required]
        public byte[] Data { get; set; }
    }
}
