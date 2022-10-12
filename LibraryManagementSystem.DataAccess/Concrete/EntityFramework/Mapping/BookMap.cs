using LibraryManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccess.Concrete.EntityFramework.Mapping
{
    public class BookMap:EntityTypeConfiguration<Book>
    {
        public BookMap()
        {

            ToTable(@"Books", @"dbo");
            HasKey(x => x.BookID);

            Property(x => x.BookID).HasColumnName("BookID");
            Property(x => x.Title).HasColumnName("Title");
            Property(x => x.PublicationYear).HasColumnName("PublicationYear");
            Property(x => x.AuthorID).HasColumnName("AuthorID");
            Property(x => x.PublisherID).HasColumnName("PublisherID");
            Property(x => x.LanguageID).HasColumnName("LanguageID");
            Property(x => x.CategoryID).HasColumnName("CategoryID");
            Property(x => x.IsRezerved).HasColumnName("IsRezerved");
        


        }
    }
}
