using LibraryManagementSystem.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities.Concrete
{
    public class Category :IEntity
    {
        public virtual int CategoryID { get; set; } 
        public virtual string CategoryName { get; set; }    

    }
}
