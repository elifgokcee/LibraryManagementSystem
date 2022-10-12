using LibraryManagamentSystem.Entities.Concrete;
using LibraryManagementSystem.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagamentSystem.DataAccess.Abstract
{
    public interface IRoleDal:IEntityRepository<Role>
    {
    }
}
