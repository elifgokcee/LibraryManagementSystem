using LibraryManagementSystem.Entities.Concrete.ComplexTypes;
using System.Collections.Generic;

namespace LibraryManagementSystem.MVCWebUI
{
    public class BookReservationListViewModel
    {
        public List<BookReservationDetails> BookReservations { get; set; }
    }
}