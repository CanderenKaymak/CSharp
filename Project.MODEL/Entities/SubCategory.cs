using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class SubCategory:BaseEntity
    {
        //
        [Required(ErrorMessage = "{0} alanının girilmesi Zorunludur"), MaxLength(25, ErrorMessage = "{0} Alanına maksimum {1} karakter girilebilir"), MinLength(5, ErrorMessage = "{0} alanına minimum {1} karakter girmelisiniz"), Display(Name = "Alt Kategori Adı")]
        public string SubName { get; set; }
        public string SubDescription { get; set; }
        public string ImagePath { get; set; }
        public SubCategory()
        {
           Products = new List<Product>();
        }

        //relational properties
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
