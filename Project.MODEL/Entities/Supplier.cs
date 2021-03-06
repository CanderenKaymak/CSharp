﻿using Project.MODEL.Entities;
using Project.MODEL.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL
{
  public  class Supplier: BaseEntity
    {
        [Required(ErrorMessage = "{0} alanının girilmesi zorunludur."), MaxLength(16, ErrorMessage = "{0} Alanına maksimum {1} karakter girebilirsiniz."), MinLength(5, ErrorMessage = ""), Display(Name = "Şifre")]
        public string Password { get; set; }
        [Required(ErrorMessage = "{0} alanının girilmesi zorunludur."), MaxLength(30, ErrorMessage = "{0} Alanına maksimum {1} karakter girebilirsiniz."), MinLength(5, ErrorMessage = "{0} minimum {1} karakter girmelisiniz.."), Display(Name = "Ev İsmi ")]
        public string SupplierName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string UrlWebHome { get; set; }
        public Guid? ActivationCode { get; set; }
        public bool IsBanned { get; set; }
        public bool IsActive { get; set; }
        [Required(ErrorMessage = "{0} alanının girilmesi zorunludur."), Compare("Password", ErrorMessage = "Şifreleriniz Uyuşmuyor.."), Display(Name = "Şifre tekrar")]
        public string ConfirmPassword { get; set; }
        public Role UserRole { get; set; }
        public Region SupRegion { get; set; }
        public Rank SupRank { get; set; }
        public Supplier()
        {
            SupRank = 0;
            ActivationCode = Guid.NewGuid();
            UserRole = Role.Manager;
        }

        //relational properties

        public virtual List<Employee> Employees { get; set; }
        public virtual List<Product> Products { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
}
