using LibraryManagementSystem.Entities.Concrete.ComplexTypes;
using LibraryManagementSystem.Core.DataAccess;
using LibraryManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccess.Abstract
{
    public interface IBookDal : IEntityRepository<Book>
    {
        List<BookDetails> GetBookDetails();
         BookDetails GetBookDetailsById(int id);
       
        //List<BookDetails> DoAllFilter(string bookName, int authorID, int pubsliherID,
        //    int languageID, int minYear, int maxYear, int categoryID);
    }
}
