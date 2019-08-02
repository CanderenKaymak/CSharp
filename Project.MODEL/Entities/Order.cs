using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL
{
  public  class Order:BaseEntity
    {
       
        public DateTime? RequiredDate { get; set; }
        public DateTime? OrderDate { get; set; }
        [Required(ErrorMessage = "{0} alanının girilmesi Zorunludur"), MaxLength(25, ErrorMessage = "{0} Alanına maksimum {1} karakter girilebilir"), MinLength(5, ErrorMessage = "{0} alanına minimum {1} karakter girmelisiniz"), Display(Name = "Sipariş Adı")]
        public string OrderName { get; set; }
        public string Note { get; set; }

        //relational properties
        public int? UserID { get; set; }
        public virtual User User { get; set; }
        public int? EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }
        public int? AddressID { get; set; }
        public virtual Address Address { get; set; }

    }
}
