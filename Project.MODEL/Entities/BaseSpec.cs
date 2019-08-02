using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL
{
  public abstract  class BaseSpec:BaseEntity
    {
        [Required(ErrorMessage ="{0} alanının girilmesi Zorunludur"),MaxLength(25,ErrorMessage ="{0} Alanına maksimum {1} karakter girilebilir"),MinLength(5,ErrorMessage ="{0} alanına minimum {1} karakter girmelisiniz"),Display(Name ="Ad")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "{0} alanının girilmesi Zorunludur"), MaxLength(35, ErrorMessage = "{0} Alanına maksimum {1} karakter girilebilir"), MinLength(5, ErrorMessage = "{0} alanına minimum {1} karakter girmelisiniz"), Display(Name = "Soyad")]
        public string  LastName { get; set; }

        public string Address { get; set; }
        
        public string Country { get; set; }
        public string  City { get; set; }
        public string Phone { get; set; }
        public DateTime? BirthDate { get; set; }
        public string ImagePath { get; set; }
        


    }
}
