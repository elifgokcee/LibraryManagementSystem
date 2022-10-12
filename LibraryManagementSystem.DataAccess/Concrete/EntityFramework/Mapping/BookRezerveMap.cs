
using LibraryManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccess.Concrete.EntityFramework.Mapping
{
    public class BookRezerveMap : EntityTypeConfiguration<BookRezervation>
    {
        public BookRezerveMap()
        {
            ToTable(@"BookRezervations", @"dbo");

            HasKey(x => x.Id);

           
            Property(x => x.RezervePersonId).HasColumnName("RezervePersonId");
            Property(x => x.DeadDate).HasColumnName("DeadDate");
            Property(x => x.CreatedDate).HasColumnName("CreatedDate");
            Property(x => x.RezervationNumber).HasColumnName("RezervationNumber");
            Property(x => x.BookID).HasColumnName("BookID");
            Property(x => x.IsActive).HasColumnName("IsActive");




        }

    }
}
