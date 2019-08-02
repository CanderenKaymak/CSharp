using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL
{
   public class Category:BaseEntity
    {   [Required(ErrorMessage ="{0} Kategori ismi girilmek zorundadır"),MaxLength(35,ErrorMessage ="{0} Alanına maksimum {1} karakter girilebilir"),MinLength(5,ErrorMessage ="{0} alanına minimum {1} girilmek zorundadır"),Display(Name ="Kategori İsmi")]
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public Category()
        {
            SubCategories = new List<SubCategory>();
        }

        //relational Properties

        public virtual List<SubCategory> SubCategories { get; set; }

        public virtual List<Product> Products { get; set; }

       
    }
}
