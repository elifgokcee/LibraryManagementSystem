using LibraryManagamentSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagamentSystem.Business.ServiceAdapters
{
    public interface IKpsService
    {
        bool ValidateMember(Member member);
    }
}
