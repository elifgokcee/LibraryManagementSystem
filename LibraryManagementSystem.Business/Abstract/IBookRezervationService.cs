using LibraryManagementSystem.Entities.Concrete;

using LibraryManagementSystem.Business.Abstract;
using LibraryManagementSystem.Entities.Concrete.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business.Abstract
{
    public interface IBookRezervationService:EntityService<BookRezervation>
    {
        void Dead(int Id);
        List<BookReservationDetails> GetActiverezervations();
         BookReservationDetails GetBookReservationDetailsById(int id);
        bool IsReservationNumberInUse(int number);

        BookReservationDetails GetActiveReservationByBookId(int bookId);
        void DeleteByBookId(int bookId);

        List<BookReservationDetails> GetBookReservationDetailsByReserveNumber(int reservationNumber,int isActive);
        List<BookReservationDetails> GetBookReservationDetails();
        BookRezervation GetBookReservationByBookId(int bookId);

        List<BookRezervation> GetBookRezervationByMemberId(int memberId);
    }
}
