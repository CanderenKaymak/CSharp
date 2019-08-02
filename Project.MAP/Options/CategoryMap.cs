using Project.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
   public class CategoryMap:BaseMap<Category>
    {
        public CategoryMap()
        {
            Property(x => x.CategoryName).HasColumnName("Kategori Adı").HasMaxLength(30).IsRequired();
            Property(x => x.Description).HasColumnName("Açıklama").HasMaxLength(200).IsRequired();
            Property(x => x.ImagePath).HasColumnName("İmaj Patikası").IsOptional();
            ToTable("Kategoriler");
            
        }
    }
}
