using Project.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
   public class OrderMap:BaseMap<Order>
    {
        public OrderMap()
        {
            Property(x => x.OrderName).HasColumnName("Sipariş Adı").HasMaxLength(40).IsRequired();
            Property(x => x.OrderDate).HasColumnName("Sipariş Tarihi").HasColumnType("datetime").IsOptional();
            Property(x => x.RequiredDate).HasColumnName("Ulaştırılması Gereken Tarih").HasColumnType("datetime").IsOptional();
            Property(x => x.Note).HasColumnName("Sipariş Notu").HasMaxLength(200).IsOptional();

            ToTable("Siparişler");
            

        }
    }
}
