using LibraryManagementSystem.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities.Concrete
{
    public class Author :IEntity
    {
      

        public virtual int AuthorID {get; set;}
        public virtual string AuthorName {get; set;}

        public virtual string AuthorSurName { get; set;}    
        public virtual string NameAndSurName { get {
                return AuthorName + "  " + AuthorSurName;
            } }    
    }
    
}
