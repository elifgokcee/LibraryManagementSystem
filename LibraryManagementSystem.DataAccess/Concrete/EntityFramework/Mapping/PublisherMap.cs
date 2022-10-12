using LibraryManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Publisher = LibraryManagementSystem.Entities.Concrete.Publisher;

namespace LibraryManagementSystem.DataAccess.Concrete.EntityFramework.Mapping
{
    public class PublisherMap:EntityTypeConfiguration<Publisher>
    {
        public PublisherMap()
        {
            ToTable(@"Publishers", @"dbo");
            HasKey(x => x.PublisherID);
        
            Property(x => x.PublisherName).HasColumnName("PublisherName");
           
       
        }
    }
}
