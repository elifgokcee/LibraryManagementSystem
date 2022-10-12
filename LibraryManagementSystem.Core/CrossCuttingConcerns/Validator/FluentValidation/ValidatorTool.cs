using FluentValidation;
using LibraryManagementSystem.Core.Entities.Abstract;
using Ninject.Activation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Core.CrossCuttingConcerns.Validator.FluentValidation
{
    public static class ValidatorTool
    {

        public static int FluentValidator(IValidator validator, IEntity entity)
        {
            var context = new ValidationContext<IEntity>(entity);
            var validationResult = validator.Validate(context);
            
            if (validationResult.Errors.Count > 0)
            {
                return validationResult.Errors.Count;

            }
            else
            {
                return 0;
            }

        }
    }
}
