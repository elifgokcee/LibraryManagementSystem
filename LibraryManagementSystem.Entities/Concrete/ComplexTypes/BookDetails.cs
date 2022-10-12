using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities.Concrete.ComplexTypes
{
    public class BookDetails
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string CategoryName { get; set; }

        public string AuthorName { get; set; }
        public string AuthorSurName { get; set; }   

        public string PublisherName { get; set; }   

        public string LanguageNmae { get; set; }    

        public DateTime PublicationYear { get; set; }

        public int IsReserved { get; set; }

    }
}
