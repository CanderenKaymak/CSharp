using Project.MODEL;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
   public class BaseMap<T>: EntityTypeConfiguration<T> where T : BaseEntity
    {
        public BaseMap()
        {
            Property(z => z.CreatedDate).HasColumnName("Veri Oluşturulma Tarihi").IsOptional();
            Property(x => x.DeletedDate).HasColumnName("Veri Silinme Tarihi").IsOptional();
            Property(zz => zz.ModifiedDate).HasColumnName("Veri Güncellenme Tarihi").IsOptional();

            Property(c => c.Status).HasColumnName("Veri Durumu");
        }

    }
}
