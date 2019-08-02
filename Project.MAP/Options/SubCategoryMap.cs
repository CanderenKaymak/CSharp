using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class SubCategoryMap : BaseMap<SubCategory> 
    {
        public SubCategoryMap()
        {
            Property(x => x.ImagePath).HasColumnName("İmaj Patikası").IsOptional();
            Property(x => x.SubDescription).HasColumnName("Alt Kategori Açıklaması").IsRequired().HasMaxLength(200);
            Property(x => x.SubName).HasMaxLength(50).HasColumnName("Alt Kategori Adı").IsRequired();
            ToTable("Alt Kategoriler");
            //Property(x => x.Category.CategoryName).HasMaxLength(100).HasColumnName("Kategorisi").IsOptional();
        }
    }
}
