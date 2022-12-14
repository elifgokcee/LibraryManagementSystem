using LibraryManagamentSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagamentSystem.DataAccess.Concrete.EntityFramework.Mapping
{
    public class RoleMap :EntityTypeConfiguration<Role>
    {
        public RoleMap()
        {
            ToTable(@"Roles", @"dbo");

            HasKey(x => x.Id);

            Property(x => x.RoleName).HasColumnName("RoleName");
            
        }
    }
}
