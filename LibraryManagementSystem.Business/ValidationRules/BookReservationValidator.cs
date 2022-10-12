using FluentValidation;
using LibraryManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagamentSystem.Business.ValidationRules
{
    public class BookReservationValidator:AbstractValidator<BookRezervation>
    {
        public BookReservationValidator()
        {

            RuleFor(p => p.IsActive).NotEmpty();

            RuleFor(p => p.CreatedDate).NotEmpty().WithMessage("Created date can't  be blank");

            RuleFor(p => p.Id).NotEmpty();

            RuleFor(p => p.BookID).NotEmpty().WithMessage("Book exists"); ;

            RuleFor(p => p.RezervationNumber).NotEmpty().WithMessage("Reservation number can't be blank"); ;
            RuleFor(p => p.RezervationNumber).GreaterThanOrEqualTo(100000).WithMessage("Reservation number can't less than 100000");
            RuleFor(p => p.RezervationNumber).LessThanOrEqualTo(999999).WithMessage("Reservation number can't greater than 100000");

            RuleFor(p => p.RezervePersonId).NotEmpty().WithMessage("Member exists");
        }
    }
}
