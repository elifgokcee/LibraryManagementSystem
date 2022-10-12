using LibraryManagamentSystem.DataAccess.Abstract;
using LibraryManagamentSystem.Entities.Concrete;
using LibraryManagementSystem.Core.DataAccess.EntityFramework;
using LibraryManagementSystem.DataAccess.Concrete.EntityFramework;
using LibraryManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagamentSystem.DataAccess.Concrete.EntityFramework
{
    public class EFMemberDal: EFEntityRepositoryBase<Member, LibraryContext>,IMemberDal
    {
    }
}
