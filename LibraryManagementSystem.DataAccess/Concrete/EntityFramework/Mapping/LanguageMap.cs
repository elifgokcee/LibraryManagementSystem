using LibraryManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccess.Concrete.EntityFramework.Mapping
{
    public class LanguageMap:EntityTypeConfiguration<Language>
    {
        public LanguageMap()
        {
            ToTable(@"Languages", @"dbo");
            HasKey(x => x.LanguageID);
            Property(x => x.LanguageName).HasColumnName("LanguageName");
        }
    }
}
