using FluentValidation;
using LibraryManagamentSystem.Business.ValidationRules;
using LibraryManagamentSystem.Entities.Concrete;
using LibraryManagementSystem.Business.ValidationRules;
using LibraryManagementSystem.Entities.Concrete;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagamentSystem.Business.DependencyResolvers.Ninject
{
    public class ValidationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Book>>().To<BookValidator>().InSingletonScope();
            Bind<IValidator<BookRezervation>>().To<BookReservationValidator>().InSingletonScope();
            Bind<IValidator<Member>>().To<MemberValidator>().InSingletonScope();
            Bind<IValidator<Publisher>>().To<PublisherValidator>().InSingletonScope();
            Bind<IValidator<User>>().To<UserValidator>().InSingletonScope();
            Bind<IValidator<Author>>().To<AuthorValidator>().InSingletonScope();
            Bind<IValidator<Language>>().To<LanguageValidator>().InSingletonScope();
            Bind<IValidator<Role>>().To<RoleValidator>().InSingletonScope();

        }
    }
}
