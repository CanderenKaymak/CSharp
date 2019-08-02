using Project.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
   public class EmployeeMap:BaseMap<Employee>
    {

        public EmployeeMap()
        {
            Property(x => x.FirstName).HasColumnName("Ad").HasMaxLength(20).IsRequired();
            Property(x => x.LastName).HasColumnName("Soyad").HasMaxLength(20).IsRequired();
            Property(x => x.BirthDate).HasColumnName("Doğum Tarihi").HasColumnType("datetime2").IsRequired();
            Property(x => x.Country).HasColumnName("Ülke").HasMaxLength(30).IsOptional();
            Property(x => x.City).HasColumnName("Şehir").HasMaxLength(30).IsOptional();
            Property(x => x.Address).HasColumnName("Adres").HasMaxLength(200).IsOptional();
            Property(x => x.Phone).HasColumnName("Telefon").HasMaxLength(15).IsOptional();
            Property(x => x.ImagePath).HasColumnName("İmaj Patikası").IsOptional();
            Property(x => x.Email).IsOptional();
            ToTable("Kuryeler");
        }
    }
}
