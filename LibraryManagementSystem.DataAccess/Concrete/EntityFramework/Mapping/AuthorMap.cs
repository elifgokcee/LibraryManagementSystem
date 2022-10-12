using LibraryManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccess.Concrete.EntityFramework.Mapping
{
    public class AuthorMap:EntityTypeConfiguration<Author>
    {
        public AuthorMap()
        {
            ToTable(@"Authors", @"dbo");

            HasKey(x => x.AuthorID);

            Property(x => x.AuthorSurName).HasColumnName("AuthorSurName");
            Property(x => x.AuthorName).HasColumnName("AuthorName");
        }
    }
}
