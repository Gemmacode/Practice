using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPModel.Entities;
using WPModel.Enum;

namespace WPData.DTO
{
    public class OrderDTO
    {
        [Required]
        public List<Product> Products { get; set; }
        [Required]
        public OrderStatus Status { get; set; }
        [Required]
        public decimal TotalAmount { get; set; }
        [Required]
        public PaymentMethod paymentMethod { get; set; }
    }
}
