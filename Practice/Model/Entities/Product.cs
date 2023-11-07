using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPModel.Enum;

namespace WPModel.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }
        public Category Category { get; set; }
        public int Quantity { get; set; }
    }
}
