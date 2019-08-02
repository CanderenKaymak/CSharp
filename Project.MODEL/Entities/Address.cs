using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
   public class Address:BaseEntity
    {
        [Required(ErrorMessage = "{0} bu alanın girilmesi zorunludur")]
        public string SentAddress { get; set; }
        [Required(ErrorMessage ="{0} bu alanın girilmesi zorunludur")]
        public string AdressName { get; set; }
        //relational prop 

        public int? UserID { get; set; }
        public virtual User User { get; set; }
        public List<Order> Orders { get; set; }
       


    }
}
