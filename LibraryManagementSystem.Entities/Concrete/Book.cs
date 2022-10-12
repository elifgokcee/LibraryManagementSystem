
using LibraryManagementSystem.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities.Concrete
{
    public class Book :IEntity
    {
        public virtual int BookID { get; set; }
        public virtual int CategoryID { get; set; }
        public virtual int AuthorID { get; set; }

        public virtual int LanguageID { get; set; }

        public virtual int PublisherID { get; set; }

        public virtual DateTime PublicationYear { get; set; }
        public virtual string Title { get; set; }

        public virtual int IsRezerved { get; set; }
       

         

    }
}
