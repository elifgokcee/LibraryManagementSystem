using LibraryManagementSystem.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities.Concrete
{
    public class Publisher:IEntity
    {
        public virtual int PublisherID { get; set; }    
        public virtual string PublisherName { get; set; }   

    }
}
