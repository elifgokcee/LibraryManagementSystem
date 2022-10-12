using FluentValidation;
using LibraryManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business.ValidationRules
{
    public class AuthorValidator: AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(p => p.AuthorName).NotEmpty().WithMessage("Author name can't be blank"); 
            RuleFor(p => p.AuthorName).Length(3,50).WithMessage("Author name must be between 3 and 50 in length");
            RuleFor(p => p.AuthorSurName).NotEmpty().WithMessage("Author surname can't be blank");
            RuleFor(p => p.AuthorSurName).Length(2, 50).WithMessage("Author surname must be between 2 and 50 in length");

        }
    }
}
