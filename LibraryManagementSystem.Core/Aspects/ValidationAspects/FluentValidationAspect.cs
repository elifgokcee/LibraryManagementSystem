using FluentValidation;
using LibraryManagementSystem.Core.CrossCuttingConcerns.Validator.FluentValidation;
using LibraryManagementSystem.Core.Entities.Abstract;
using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Core.Aspects.ValidationAspects
{
    [Serializable]
    public class FluentValidationAspect : OnMethodBoundaryAspect
    {
        Type _validatorType;
        public FluentValidationAspect(Type validatorType)
        {
            _validatorType = validatorType;
        }
        public override void OnEntry(MethodExecutionArgs args)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            var entities = args.Arguments.Where(x => x.GetType() == entityType);
            foreach (var entity in entities)
            {
                ValidatorTool.FluentValidator(validator, (IEntity)entity);
            }
        }
    }
}