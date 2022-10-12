using FluentValidation;
using LibraryManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business.ValidationRules
{
    public class BookValidator: AbstractValidator<Book>
    {
        public BookValidator()
        {
            
          
            RuleFor(p => p.PublicationYear).LessThan(DateTime.Now);

            RuleFor(p => p.Title).NotEmpty().WithMessage("Title can't be blank");
            RuleFor(p => p.PublisherID).NotEmpty();
            RuleFor(p => p.CategoryID).NotEmpty();
            RuleFor(p => p.AuthorID).NotEmpty();
            RuleFor(p => p.BookID).NotEmpty();
            RuleFor(p => p.PublicationYear).NotEmpty().WithMessage("Publish year can't be blank");
            RuleFor(p => p.IsRezerved).NotEmpty();
            RuleFor(p => p.LanguageID).NotEmpty();

        }
    }
}
