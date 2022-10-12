using LibraryManagementSystem.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagamentSystem.Entities.Concrete
{
    public class Member :IEntity
    {
        public virtual int Id { get; set; } 
        public virtual string FirstName { get; set; }    
        public virtual  string LastName { get; set; }  
        
        public virtual DateTime DateOfBirth { get; set; }   

        public virtual string TcNo { get; set; }    

    }
}
