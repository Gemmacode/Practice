using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPModel.Enum;

namespace WPModel.Entities
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }  
        public string Email { get; set; }
        public UserType UserType { get; set; }
    }
}
