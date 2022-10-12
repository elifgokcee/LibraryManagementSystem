using LibraryManagementSystem.DataAccess.Concrete.EntityFramework.Mapping;
using LibraryManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LibraryManagamentSystem.Entities.Concrete;
using LibraryManagamentSystem.DataAccess.Concrete.EntityFramework.Mapping;

namespace LibraryManagementSystem.DataAccess.Concrete.EntityFramework
{
    public class LibraryContext : DbContext
    {

        public LibraryContext() 
        {
            Database.SetInitializer<LibraryContext>(null);
        }
        

    protected override void OnModelCreating(DbModelBuilder builder)
    {
            builder.Configurations.Add(new UserMap());
            builder.Configurations.Add(new RoleMap());
            builder.Configurations.Add(new BookMap());
            builder.Configurations.Add(new LanguageMap());
            builder.Configurations.Add(new PublisherMap());
            builder.Configurations.Add(new AuthorMap());
            builder.Configurations.Add(new CategoryMap());
            builder.Configurations.Add(new BookRezerveMap());
            builder.Configurations.Add(new MemberMap());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<BookRezervation> BookRezervations { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
