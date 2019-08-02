using Project.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
   public class ProductMap : BaseMap<Product>
    {
        public ProductMap()
        {
            Property(x => x.ImagePath).HasColumnName("İmaj Patikası").IsOptional();
            Property(z => z.IsAvailable).HasColumnName("Menüde mi?").IsOptional().HasColumnType("bit");
            Property(z => z.ProductName).HasColumnName("Ürün İsmi").IsRequired().HasMaxLength(50);
            Property(x => x.UnitPrice).HasColumnName("Ürün Fiyatı").IsRequired().HasColumnType("money");
            Property(x => x.UnitsOnOrder).HasColumnName("Gönderimde mi?").HasColumnType("smallint");
            Property(x => x.ProductRegion).HasColumnName("Ürün Bölgesi");
            Property(x => x.ProductContent).HasColumnName("Ürün İçeriği");

            ToTable("Ürünler");


        }
    }
}
