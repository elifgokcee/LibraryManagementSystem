using LibraryManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business.Abstract
{
    public interface UserService : EntityService<User>
    {
        bool Login(string userName,string password);
        string GetRole(string userName, string password);

        bool IsUserNameAlredyBeen(string username);

      
        User GetUser(string userName,string password);

    }
}
