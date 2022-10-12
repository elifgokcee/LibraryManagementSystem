using LibraryManagementSystem.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities.Concrete
{
    public class BookRezervation : IEntity
    {
       
        public virtual int Id { get; set; } 
        public virtual int BookID { get; set; } 
        public virtual  int RezervationNumber { get; set; }
        public virtual int RezervePersonId { get; set; }
        public virtual int IsActive { get; set; }

        public virtual DateTime CreatedDate { get; set; }

        public virtual DateTime? DeadDate { get; set; }   
    }
}
