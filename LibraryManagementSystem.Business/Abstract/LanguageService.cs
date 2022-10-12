using LibraryManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business.Abstract
{
    public interface LanguageService : EntityService<Language>
    {
        bool IsAlreadyBeen(string languageName);
    }
}
