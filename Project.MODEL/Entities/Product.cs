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
    public class Product : BaseEntity
    {
        [Required(ErrorMessage = "{0} alanının girilmesi Zorunludur"), MaxLength(25, ErrorMessage = "{0} Alanına maksimum {1} karakter girilebilir"), MinLength(5, ErrorMessage = "{0} alanına minimum {1} karakter girmelisiniz"), Display(Name = "Ürün Adı")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "{0} alanının girilmesi Zorunludur"), MaxLength(400, ErrorMessage = "{0} Alanına maksimum {1} karakter girilebilir"), MinLength(5, ErrorMessage = "{0} alanına minimum {1} karakter girmelisiniz"), Display(Name = "Ad")]
        public string ProductContent { get; set; }
        public decimal? UnitPrice { get; set; }
        public string ImagePath { get; set; }
        
        public bool? IsAvailable { get; set; }
        public short? UnitsOnOrder { get; set; }
        public Region ProductRegion { get; set; }
        

        //relational properties
        public int? SubCategoryID { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public int? SupplierID { get; set; }
        public virtual Supplier Supplier { get; set; }
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
