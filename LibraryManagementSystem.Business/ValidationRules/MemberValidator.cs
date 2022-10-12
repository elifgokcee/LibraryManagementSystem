using FluentValidation;
using LibraryManagamentSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagamentSystem.Business.ValidationRules
{
    public class MemberValidator:AbstractValidator<Member>
    {
        public MemberValidator()
        {
            RuleFor(p => p.FirstName).NotNull().WithMessage("First name can't be blank");
            RuleFor(p => p.FirstName).Length(3,50);
            RuleFor(p => p.LastName).NotNull().WithMessage("Last name can't be blank");
            RuleFor(p => p.LastName).Length(2, 50);
            RuleFor(p => p.DateOfBirth).NotNull().WithMessage("Date of birth can't be blank");
            RuleFor(p => p.TcNo).NotNull().WithMessage("Identity number can't be blank");
            RuleFor(p => p.TcNo).Length(11).WithMessage("Identity number length must be 11 digits");
        }
    }
}
