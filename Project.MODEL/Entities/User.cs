using Project.MODEL.Entities;
using Project.MODEL.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL
{
   public class User:BaseEntity
    {
        [Required(ErrorMessage = "{0} alanının girilmesi zorunludur."), MaxLength(30, ErrorMessage = "{0} Alanına maksimum {1} karakter girebilirsiniz."), MinLength(5, ErrorMessage = "{0} minimum {1} karakter girmelisiniz.."), Display(Name = "Kullanıcı İsmi ")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "{0} alanının girilmesi zorunludur."), MaxLength(10, ErrorMessage = "{0} Alanına maksimum {1} karakter girebilirsiniz."), Display(Name = "Şifre")]
        public string  Password { get; set; }
        public Role? UserRole { get; set; }
        public bool IsBanned { get; set; }
        public bool IsActive { get; set; }
        public string  Email { get; set; }
        public Guid? ActivationCode { get; set; }
        [Required(ErrorMessage = "{0} alanının girilmesi zorunludur."), Compare("PassWord", ErrorMessage = "Şifreleriniz Uyuşmuyor.."), Display(Name = "Şifre tekrar")]
        public string ConfirmPassword { get; set; }
        public User()
        {
            UserRole = Role.Customer;
            ActivationCode = Guid.NewGuid();

        }


        // relational properties
        public virtual UserProfile UserProfile { get; set; }
        public  virtual List<Order> Orders { get; set; }
        public virtual List<Comment > Comments { get; set; }
        public virtual List<Address> Addresses { get; set; }

    }
}
