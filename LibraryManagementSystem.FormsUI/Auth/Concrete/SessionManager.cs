using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagamentSystem.FormsUI.Auth.Concrete
{
    public class SessionManager : SessionService
    {
        public void DeadSessionn(Session session)
        {
            session.UserName = "";
            session.Password = "";
            session.Role = "";
        }
    }
}
