using LibraryManagementSystem.Entities.Concrete.ComplexTypes;
using LibraryManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business.Abstract
{
    public interface BookService : EntityService<Book>
    {
        
        List<BookDetails> GetNonReservedBooks();
      
        void MakeRezerve(int Id);
        void NotRezerve(int Id);

        List<BookDetails> DoAllFilter(string bookName,int authorID,int pubsliherID,int languageID,int minYear,int maxYear,int categoryID);

        List<BookDetails> GetBookDetails();
         BookDetails GetBookDetailsById(int id);



    }
}
