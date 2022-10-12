using LibraryManagamentSystem.FormsUI.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.FormsUI
{
    public static class BuildForm
    {
        public static void Home(Session session){
            
            Form home = new Home(session);
            
            home.Show();
        }
        public static void Login()
        {
            Form login = new LoginForm();
            login.Show();
        }
    }
}
