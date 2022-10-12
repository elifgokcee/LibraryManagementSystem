
using LibraryManagementSystem.Core.DataAccess.EntityFramework;
using LibraryManagementSystem.DataAccess.Abstract;
using LibraryManagementSystem.Entities.Concrete;
using LibraryManagementSystem.Entities.Concrete.ComplexTypes;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem.DataAccess.Concrete.EntityFramework
{
    public class EFBookDal : EFEntityRepositoryBase<Book, LibraryContext>, IBookDal
    {
        public List<BookDetails> GetBookDetails()
        {
            using (var context = new LibraryContext())
            {
                var result = from p in context.Books
                             join c in context.Categories on p.CategoryID equals c.CategoryID
                             join d in context.Authors on p.AuthorID equals d.AuthorID
                             join e in context.Publishers on p.PublisherID equals e.PublisherID
                             join f in context.Languages on p.LanguageID equals f.LanguageID


                             select new BookDetails
                             {
                                 BookID = p.BookID,
                                 Title = p.Title,
                                 CategoryName = c.CategoryName,
                                 AuthorName = d.AuthorName,
                                 LanguageNmae = f.LanguageName,
                                 PublisherName = e.PublisherName,
                                 PublicationYear = p.PublicationYear
                                 ,
                                 IsReserved = p.IsRezerved,
                                 AuthorSurName = d.AuthorSurName


                             };
                return result.ToList();


            }

        }
        public BookDetails GetBookDetailsById(int id)
        {
            using (var context = new LibraryContext())
            {
                var result = from p in context.Books
                   
                             join c in context.Categories on p.CategoryID equals c.CategoryID
                             join d in context.Authors on p.AuthorID equals d.AuthorID
                             join e in context.Publishers on p.PublisherID equals e.PublisherID
                             join f in context.Languages on p.LanguageID equals f.LanguageID
                             where p.BookID==id


                             select new BookDetails
                             {
                                 BookID = id,
                                 Title = p.Title,
                                 CategoryName = c.CategoryName,
                                 AuthorName = d.AuthorName,
                                 LanguageNmae = f.LanguageName,
                                 PublisherName = e.PublisherName,
                                 PublicationYear = p.PublicationYear
                                 ,
                                 IsReserved = p.IsRezerved,
                                 AuthorSurName = d.AuthorSurName


                             };
                return (BookDetails)result.FirstOrDefault();


            }

        }

      


        //public List<BookDetails> DoAllFilter(string bookName, int authorID, int publisherID,
        //   int languageID, int minYear, int maxYear, int categoryID)
        //{
        //    using (var context = new LibraryContext())
        //    {
        //        var result = from p in context.Books

        //                     join c in context.Categories on p.CategoryID equals c.CategoryID
        //                     join d in context.Authors on p.AuthorID equals d.AuthorID
        //                     join e in context.Publishers on p.PublisherID equals e.PublisherID
        //                     join f in context.Languages on p.LanguageID equals f.LanguageID
        //                     where p.Title.ToLower().Contains(bookName.ToLower()) && p.PublicationYear.Year <= maxYear
        //                     && p.PublicationYear.Year >= minYear
        //                     && p.CategoryID==categoryID && p.AuthorID==authorID 
        //                     && p.LanguageID ==languageID && p.PublisherID==publisherID
        //                     && p.IsRezerved==0




        //                     select new BookDetails
        //                     {
        //                         BookID = p.BookID,
        //                         Title = p.Title,
        //                         CategoryName = c.CategoryName,
        //                         AuthorName = d.AuthorName,
        //                         LanguageNmae = f.LanguageName,
        //                         PublisherName = e.PublisherName,
        //                         PublicationYear = p.PublicationYear
        //                         ,
        //                         IsReserved = p.IsRezerved,
        //                         AuthorSurName = d.AuthorSurName


        //                     };

        //        return result.ToList();


        //    }





    }
}
