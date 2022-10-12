using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities.Concrete.ComplexTypes
{
    public class BookReservationDetails
    {
        public virtual int Id { get; set; }
        public virtual int BookID { get; set; }
        public string BookName { get; set; }
        public virtual int RezervationNumber { get; set; }
        public virtual string RezervePersonName { get; set; }
        public virtual int IsActive { get; set; }

        public virtual DateTime CreatedDate { get; set; }
        public virtual int ReservePersonId { get; set; }



    }
}
