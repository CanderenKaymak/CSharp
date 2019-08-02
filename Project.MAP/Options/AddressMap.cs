using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class AddressMap:BaseMap<Address>
    {
        public AddressMap()
        {
            
            Property(x => x.AdressName).HasColumnName("Adres Başlığı").HasMaxLength(20).IsOptional();
            Property(x => x.SentAddress).HasColumnName("Adres").IsOptional().HasMaxLength(200);
            ToTable("Adresler");

        }
    }
}
