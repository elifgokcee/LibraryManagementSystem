using LibraryManagamentSystem.Business.DependencyResolvers.Ninject;
using LibraryManagementSystem.Business.Abstract;
using LibraryManagementSystem.Business.Concrete;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business.DependencyResolvers.Ninject
{
    public class InstanceFactory
    {
      

        public static T GetInstance<T>()
        {
            var  kernel=new StandardKernel(new BusinessModule(),new AutoMapperModule(),new ValidationModule());
            return kernel.Get<T>();

        }
    }
}
