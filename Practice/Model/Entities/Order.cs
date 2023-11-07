using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPModel.Enum;

namespace WPModel.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<Product> Products { get; set; }
        public OrderStatus Status { get; set; }
        public decimal TotalAmount { get; set; }
        public PaymentMethod paymentMethod { get; set; }   
    }
}
