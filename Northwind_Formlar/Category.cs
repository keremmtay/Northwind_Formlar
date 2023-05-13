using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind_Formlar
{
    public class Category
    {

        // Bu class Entity Class olarak adlandırılır. Verileri bir yerden başka bir yere taşırken kullanılır.

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }


    }
}
