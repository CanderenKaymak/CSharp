using Project.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
   public class SupplierMap : BaseMap<Supplier>
    {
        public SupplierMap()
        {
            Property(x => x.SupplierName).HasColumnName("Restoran Adı").HasMaxLength(50).IsRequired();
            Property(x => x.UrlWebHome).HasColumnName("Web Adresi").IsOptional();
            Property(x => x.Phone).HasColumnName("Tel NO").HasMaxLength(20).IsRequired();
            Property(x => x.Email).HasMaxLength(30).IsRequired();
            Property(x => x.IsActive).HasColumnName("Faal mi?").HasColumnType("bit").IsRequired();
            Property(x => x.IsBanned).HasColumnName("Banlı Mı?").HasColumnType("bit").IsRequired();
            Property(x => x.ActivationCode).HasColumnName("Aktivasyon Kodu").IsOptional();
            Property(x => x.ConfirmPassword).HasColumnName("Şifre Doğrulama");
            Property(x => x.SupRank).HasColumnName("Puan");
            Property(x => x.SupRegion).HasColumnName("Bölge");
            Property(x => x.Password).HasColumnName("Şifre").IsRequired();
            ToTable("Evler");


        }
    }
}
