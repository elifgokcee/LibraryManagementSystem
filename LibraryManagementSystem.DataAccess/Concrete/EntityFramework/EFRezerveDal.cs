using LibraryManagementSystem.DataAccess.Abstract;
using LibraryManagementSystem.Entities.Concrete;
using LibraryManagementSystem.Entities.Concrete.ComplexTypes;
using LibraryManagementSystem.Core.DataAccess.EntityFramework;
using LibraryManagementSystem.DataAccess.Abstract;
using LibraryManagementSystem.DataAccess.Concrete.EntityFramework;
using LibraryManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccess.Concrete.EntityFramework
{
    public class EFRezerveDal : EFEntityRepositoryBase<BookRezervation, LibraryContext>, IBookRezervationDal
    {
        public List<BookReservationDetails> GetBookReservationDetails()
        {
            using (var context = new LibraryContext())
            {
                var result = from p in context.BookRezervations
                             join d in context.Books on p.BookID equals d.BookID
                             join e in context.Members on p.RezervePersonId equals e.Id


                             select new BookReservationDetails
                             {
                                 BookID = p.BookID,
                                 BookName = d.Title,
                                 CreatedDate = p.CreatedDate,
                                 IsActive = p.IsActive,
                                 RezervePersonName = e.FirstName,
                                 Id = p.Id,
                                 RezervationNumber = p.RezervationNumber,
                                 ReservePersonId=e.Id
                                 


                             };
                return result.ToList();


            }
        }
        public BookReservationDetails GetBookReservationDetailsByBookId(int bookId)
        {
            using (var context = new LibraryContext())
            {
                var result = from p in context.BookRezervations
                             join d in context.Books on p.BookID equals d.BookID
                             join e in context.Members on p.RezervePersonId equals e.Id
                             where p.BookID == bookId


                             select new BookReservationDetails
                             {
                                 BookID = p.BookID,
                                 BookName = d.Title,
                                 CreatedDate = p.CreatedDate,
                                 IsActive = 1,
                                 RezervePersonName = e.FirstName,
                                 Id = p.Id,
                                 RezervationNumber = p.RezervationNumber,
                                 ReservePersonId=e.Id,



                             };
                return (BookReservationDetails)result;


            }

        }
        
      
        public List<BookReservationDetails> GetBookReservationDetailsByReserveNumber(int reserveNumber,int isActive)
        {
            using (var context = new LibraryContext())
            {
                var result = from p in context.BookRezervations
                             join c in context.Books on p.BookID equals c.BookID
                             join e in context.Members on p.RezervePersonId equals e.Id


                             select new BookReservationDetails
                             {
                                 BookID = p.BookID,
                                 BookName = c.Title,
                                 CreatedDate = p.CreatedDate,
                                 IsActive = isActive,
                                 RezervePersonName = e.FirstName,
                                 Id = p.Id,
                                 RezervationNumber = reserveNumber,
                                 ReservePersonId= e.Id, 
                                 



                             };
                return result.ToList();


            }
        }
        public BookReservationDetails GetBookReservationDetailsById(int id)
        {
            using (var context = new LibraryContext())
            {
                var result = from p in context.BookRezervations
                             join d in context.Books on p.BookID equals d.BookID
                             join e in context.Members on p.RezervePersonId equals e.Id
                             where p.Id==id

                             select new BookReservationDetails
                             {
                                 BookID = p.BookID,
                                 BookName = d.Title,
                                 CreatedDate = p.CreatedDate,
                                 IsActive = p.IsActive,
                                 RezervePersonName = e.FirstName,
                                 Id = p.Id,
                                 RezervationNumber = p.RezervationNumber,
                                 ReservePersonId=e.Id



                             };
                return (BookReservationDetails)result.FirstOrDefault();


            }
        }
    }
}
