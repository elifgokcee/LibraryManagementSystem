
using LibraryManagementSystem.Business.DependencyResolvers.Ninject;
using LibraryManagementSystem.DataAccess.Abstract;
using LibraryManagementSystem.DataAccess.Concrete.EntityFramework;
using LibraryManagementSystem.Entities.Concrete;
using LibraryManagementSystem.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Entities.Concrete.ComplexTypes;

using LibraryManagementSystem.Core.Aspects.LogAspects;
using LibraryManagementSystem.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using LibraryManagementSystem.Core.Aspects.ValidationAspects;
using LibraryManagementSystem.Business.ValidationRules;
using LibraryManagamentSystem.Core.CrossCuttingConcerns.Caching.Microsoft;
using LibraryManagamentSystem.Core.Aspects.CacheAspects;
using LibraryManagamentSystem.Core.Utilities.Mappers;
using AutoMapper;

namespace LibraryManagementSystem.Business.Concrete
{
    public class BookManager : BookService
    {

        private IBookDal _efBookDal;
        private readonly IMapper _iMapper;

        public BookManager(IBookDal efBookDal,IMapper iMapper)
        {
            _efBookDal = efBookDal;
            _iMapper = iMapper;   

        }
      
        [CacheAspect(typeof(MemoryCacheManager))]
    
       
     

     
        public void MakeRezerve(int Id)
        {
            Book book = _efBookDal.Get(x => x.BookID == Id);
            if (book.IsRezerved == 0)
            {
                book.IsRezerved = 1;
                _efBookDal.Update(book);
            }

        }

        public void NotRezerve(int Id)
        {
            Book book = _efBookDal.Get(x => x.BookID == Id);
            if (book != null && book.IsRezerved == 1)
            {
                book.IsRezerved = 0;
                _efBookDal.Update(book);
            }

        }

        [CacheAspect(typeof(MemoryCacheManager))]
        

        public List<BookDetails> GetNonReservedBooks()
        
        {
            return _efBookDal.GetBookDetails().Where(x=>x.IsReserved==0).ToList();
        }

   
      

        public List<BookDetails> DoAllFilter(string bookName, int authorID, int pubsliherID,
            int languageID, int minYear, int maxYear, int categoryID)

        {
            List<BookDetails> bookDetailsList = new List<BookDetails>();
            if (authorID != -1)
            {
                bookDetailsList =
                    _efBookDal.GetBookDetails().Where(x => _efBookDal.Get(y => y.BookID == x.BookID).AuthorID == authorID).ToList();
            }
            else
            {
                bookDetailsList = _efBookDal.GetBookDetails();
            }
            if (pubsliherID != -1)
            {
                bookDetailsList =
              bookDetailsList.Where(x => _efBookDal.Get(y => y.BookID == x.BookID).PublisherID == pubsliherID).ToList();
            }
            if (languageID != -1)
            {
                bookDetailsList =
                     bookDetailsList.Where(x => _efBookDal.Get(y => y.BookID == x.BookID).LanguageID == languageID).ToList();
            }

             if (categoryID != -1)
            {
                    bookDetailsList =
                        bookDetailsList.Where(x => _efBookDal.Get(y => y.BookID == x.BookID).CategoryID == categoryID).ToList();
            }
            bookDetailsList = bookDetailsList.Where(x => x.Title.ToLower().Contains(bookName.ToLower())&&
            x.PublicationYear.Year<=maxYear&&x.PublicationYear.Year>=minYear).ToList();



            return bookDetailsList;
        }

        public List<BookDetails> GetBookDetails()
        {
            var books = _iMapper.Map<List<BookDetails>>(_efBookDal.GetBookDetails());
            return books;
        }

        [FluentValidationAspect(typeof(BookValidator))]
        public Book Update(Book book)
        {
            return _efBookDal.Update(book);
        }

        public List<Book> GetAll()
        {
            var books = _iMapper.Map<List<Book>>(_efBookDal.GetList());
            return books;
        }

        public Book GetById(int id)
        {
            var book=_iMapper.Map<Book>(_efBookDal.Get(x => x.BookID == id));
            return book;
        }
        public BookDetails GetBookDetailsById(int id)
        {
            var book = _iMapper.Map<BookDetails>(_efBookDal.GetBookDetailsById(id));
            return book;
        }
        [FluentValidationAspect(typeof(BookValidator))]
        public Book Add(Book book)
        {
          _iMapper.Map<Book>(_efBookDal.Add(book));
            return book;
        }

        public void Delete(Book entity)
        {
           _efBookDal.Delete(entity);   

        }

      
    }
}
