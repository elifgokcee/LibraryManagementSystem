using LibraryManagamentSystem.Entities.Concrete;
using LibraryManagementSystem.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagamentSystem.Business.Abstract
{
    public interface MemberService:EntityService<Member>
    {
        bool isAlreadyBeen(string TcNo);
        int GetIdByTCNo(string TcNo);

        Member GetMemberByTCNo(string TcNo);
    }
}
