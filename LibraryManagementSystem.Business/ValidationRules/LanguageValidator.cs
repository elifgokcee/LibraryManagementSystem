using FluentValidation;
using LibraryManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagamentSystem.Business.ValidationRules
{
    public class LanguageValidator:AbstractValidator<Language>
    {
        public LanguageValidator()
        {
            RuleFor(x => x.LanguageName).NotEmpty();
            RuleFor(x => x.LanguageID).NotEmpty();

        }
    }
}
