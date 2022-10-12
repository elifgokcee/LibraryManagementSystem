using LibraryManagementSystem.Business.Abstract;
using LibraryManagementSystem.Business.Concrete;
using LibraryManagementSystem.DataAccess.Abstract;
using LibraryManagamentSystem.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.DataAccess.Concrete.EntityFramework;
using LibraryManagamentSystem.Business.Concrete;
using LibraryManagamentSystem.Business.Abstract;
using LibraryManagamentSystem.DataAccess.Abstract;
using LibraryManagamentSystem.Business.ServiceAdapters;
using LibraryManagamentSystem.Business.ValidationRules;

namespace LibraryManagementSystem.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<CategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<AuthorService>().To<AuthorManager>().InSingletonScope();
            Bind<BookService>().To<BookManager>().InSingletonScope();
            Bind<LanguageService>().To<LanguageManager>().InSingletonScope();
            Bind<UserService>().To<UserManager>().InSingletonScope();
            Bind<PublisherService>().To<PublisherManager>().InSingletonScope();
            Bind<IBookRezervationService>().To<BookRezervationManager>().InSingletonScope();
            Bind<RoleService>().To<RoleManager>().InSingletonScope();
            Bind<MemberService>().To<MemberManager>().InSingletonScope();
            Bind<MemberValidator>().To<MemberValidator>().InSingletonScope();

            Bind<IKpsService>().To<KpsServiceAdapter>().InSingletonScope();



            Bind<DbContext>().To<LibraryContext>().InSingletonScope();

            Bind<IMemberDal>().To<EFMemberDal>();
            Bind<ICategoryDal>().To<EFCategoryDal>();
            Bind<IUserDal>().To<EFUserDal>();
            Bind<IBookDal>().To<EFBookDal>().InSingletonScope();
            Bind<IAuthorDal>().To<EFAuthorDal>();
            Bind<ILanguageDal>().To<EFLanguageDal>();
            Bind<IPublisherDal>().To<EFPublisherDal>();
            Bind<IBookRezervationDal>().To<EFRezerveDal>();
            Bind<IRoleDal>().To<EFRoleDal>().InSingletonScope();




        }
    }
}
