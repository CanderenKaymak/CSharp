using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL
{
   public class Employee:BaseSpec
    {
        public string Email { get; set; }
        //relational properties
        public virtual List<Order> Orders { get; set; }
        public int? SupplierID { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
