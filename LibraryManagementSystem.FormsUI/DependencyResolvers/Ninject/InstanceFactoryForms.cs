using LibraryManagementSystem.Business.DependencyResolvers.Ninject;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagamentSystem.FormsUI.DependencyResolvers.Ninject
{
    public class InstanceFactoryForms
    {


        public static T GetInstance<T>()
        {
            var kernel = new StandardKernel(new FormsModule());
            return kernel.Get<T>();

        }
    }
}
