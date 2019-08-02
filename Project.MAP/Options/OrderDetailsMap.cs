using Project.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
   public class OrderDetailsMap:BaseMap<OrderDetail>
    {
        public OrderDetailsMap()
        {
            Property(x => x.Discount).HasColumnName("Uygulanan İndirim").HasColumnType("real").IsOptional();
            Property(x => x.Quantity).HasColumnName("Miktar").HasColumnType("smallint").IsOptional();
            Property(x => x.TotalPrice).HasColumnName("Toplam Fiyat").HasColumnType("money").IsOptional();
            Property(x => x.UnitPrice).HasColumnName("Birim Fiyat").HasColumnType("money").IsOptional();

            Ignore(x => x.ID);
            HasKey(x => new
            {
                x.OrderID,
                x.ProductID
            });

            ToTable("Satışlar");
        }
    }
}
