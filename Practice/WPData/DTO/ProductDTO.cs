using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPModel.Enum;

namespace WPData.DTO
{
    public class ProductDTO
    {
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public Category Category { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string ImageUrl { get; set; }
    }
}
