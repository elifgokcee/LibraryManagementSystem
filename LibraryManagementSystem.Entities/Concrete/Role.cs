using LibraryManagementSystem.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagamentSystem.Entities.Concrete
{
    public class Role :IEntity
    {
        public virtual int Id { get; set; } 
        public virtual  string RoleName { get; set; }    
    }
}
