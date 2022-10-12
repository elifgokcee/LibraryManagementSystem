using LibraryManagementSystem.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities.Concrete
{
    public class User :IEntity
    {
        public virtual int UserID { get; set; }
        public virtual string UserName { get; set; }   

        public virtual string Password { get; set; }
        public virtual string Role { get; set; }
        public virtual int RoleId { get; set; } 

    }
}
