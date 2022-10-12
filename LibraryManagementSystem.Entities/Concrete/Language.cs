using LibraryManagementSystem.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities.Concrete
{
    public class Language : IEntity
    {
        public virtual  int LanguageID { get; set; }
        public virtual string LanguageName { get; set; }   
    }
}
