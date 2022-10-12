
using LibraryManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business.Abstract
{
    public interface AuthorService :EntityService<Author>
    {
        string GetNameAndSurName(int id);
        bool IsAlreadyBeen(string name,string surname);
    }
}
