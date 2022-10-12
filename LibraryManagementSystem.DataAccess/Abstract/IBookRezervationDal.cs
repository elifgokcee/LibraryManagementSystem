using LibraryManagementSystem.Entities.Concrete;
using LibraryManagementSystem.Core.DataAccess;
using LibraryManagementSystem.Entities.Concrete.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Entities.Concrete;

namespace LibraryManagementSystem.DataAccess.Abstract
{
    public interface IBookRezervationDal:IEntityRepository<BookRezervation>
    {
         BookReservationDetails GetBookReservationDetailsById(int id);
         List<BookReservationDetails> GetBookReservationDetails();
        List<BookReservationDetails> GetBookReservationDetailsByReserveNumber(int id,int isActive);
        BookReservationDetails GetBookReservationDetailsByBookId(int id);

    }
}
