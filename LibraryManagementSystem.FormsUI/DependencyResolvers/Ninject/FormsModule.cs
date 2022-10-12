using LibraryManagamentSystem.FormsUI.Auth.Concrete;
using LibraryManagamentSystem.FormsUI.Auth;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagamentSystem.FormsUI.DependencyResolvers.Ninject
{
    public class FormsModule : NinjectModule
    {
        public override void Load()
        {
            Bind<SessionService>().To<SessionManager>().InSingletonScope();
        }
    }
}
