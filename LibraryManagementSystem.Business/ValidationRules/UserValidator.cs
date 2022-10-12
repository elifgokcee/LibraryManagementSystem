using FluentValidation;
using LibraryManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business.ValidationRules
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.UserID).NotEmpty().WithMessage("Invalid user");
            RuleFor(p=>p.UserName).NotEmpty().WithMessage("Username can't be blank");
            RuleFor(p=>p.Password).NotEmpty().WithMessage("Password can't be blank");
            RuleFor(p => p.UserName).Length(3,50).WithMessage("Username must be between 3 and 50 in length");
            RuleFor(p => p.Password).Length(5,50).WithMessage("Password must be between 5 and 50 in length");
            RuleFor(p => p.RoleId).NotEmpty().WithMessage("User role can't be blank")   ;

        }
    }
}
