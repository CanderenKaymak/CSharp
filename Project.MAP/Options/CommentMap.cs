using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
   public class CommentMap:BaseMap<Comment>
    {
        public CommentMap()
        {
            Property(x => x.ComDescription).HasColumnName("Yorum").HasMaxLength(300).IsRequired();
            Property(x => x.ComTitle).HasColumnName("Başlık").HasMaxLength(50).IsOptional();
            ToTable("Yorumlar");
        }
    }
}
