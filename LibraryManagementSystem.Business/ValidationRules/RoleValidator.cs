using FluentValidation;
using LibraryManagamentSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagamentSystem.Business.ValidationRules
{
    public class RoleValidator:AbstractValidator<Role>
    {
        public RoleValidator()
        {


            RuleFor(p => p.Id).NotEmpty();

            RuleFor(p => p.RoleName).NotEmpty();
        }
    }
}
