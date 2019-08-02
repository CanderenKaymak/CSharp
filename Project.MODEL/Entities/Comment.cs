using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class Comment:BaseEntity
    {
        [Required(ErrorMessage = "{0} alanının girilmesi Zorunludur"), MaxLength(25, ErrorMessage = "{0} Alanına maksimum {1} karakter girilebilir"), MinLength(5, ErrorMessage = "{0} alanına minimum {1} karakter girmelisiniz"), Display(Name = "Yorum Başlığı")]
        public string ComTitle { get; set; }
        [Required(ErrorMessage = "{0} alanının girilmesi Zorunludur"), MaxLength(200, ErrorMessage = "{0} Alanına maksimum {1} karakter girilebilir"), Display(Name = "Ad")]
        public string ComDescription { get; set; }
        public Comment()
        {
            CreatedDate = DateTime.Now;
        }
        //relational 

        public int? UserID { get; set; }
        public virtual User User { get; set; }
        public int?  SupplierID { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
