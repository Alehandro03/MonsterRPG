using MonsterRPG.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterRPG.Buiness
{
    public class UserConfigurations : EntityTypeConfiguration<User>
    {
        public UserConfigurations() //Конфиг позволяет при создании табл задать к примеру ограничения по кол-ву вводимых символов в names
        {

            this.Property(u => u.FirstName)
                .IsRequired()
                .HasMaxLength(50);
            this.Property(u => u.LastName)
                .IsRequired()
                .HasMaxLength(50);
            this.Property(u => u.NickName)
                .IsRequired()
                .HasMaxLength(50);
        
        
        }
    }
}
