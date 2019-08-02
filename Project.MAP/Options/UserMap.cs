using Project.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
   public class UserMap:BaseMap<User>
    {
        public UserMap()
        {
            Property(x => x.UserName).HasColumnName("Kullanıcı Adı").IsRequired().HasMaxLength(30);
            Property(x => x.Password).HasColumnName("Şifre").HasMaxLength(30).IsRequired();
            Property(x => x.UserRole).HasColumnName("Yetki").IsOptional();
            Property(x => x.IsBanned).HasColumnName("Banlı mı?").IsOptional().HasColumnType("bit");
            Property(x => x.IsActive).HasColumnName("Aktif mi?").IsOptional().HasColumnType("bit");
            Property(x => x.Email).HasMaxLength(100).IsOptional();
            Property(x => x.ActivationCode).HasColumnName("Aktivasyon Kodu").IsOptional();
            Ignore(x => x.ConfirmPassword);
            HasOptional(x => x.UserProfile).WithRequired(x => x.User);
            ToTable("Kullanıcılar");
        
        }
    }
}
