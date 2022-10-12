using FluentValidation;
using LibraryManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagamentSystem.Business.ValidationRules
{
    public class PublisherValidator:AbstractValidator<Publisher>
    {
        public PublisherValidator()
        {
            RuleFor(x => x.PublisherName).NotEmpty().WithMessage("Publisher name can't be blank") ;
            RuleFor(x => x.PublisherID).NotEmpty();
        }
    }
}
