using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL
{
   public class UserProfile:BaseSpec
    {
       
        //relational properties
        public virtual User User { get; set; }
    }
}
