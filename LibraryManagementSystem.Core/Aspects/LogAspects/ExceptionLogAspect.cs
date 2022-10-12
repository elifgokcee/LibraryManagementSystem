using LibraryManagementSystem.Core.CrossCuttingConcerns.Logging;
using PostSharp.Aspects;
using PostSharp.Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagamentSystem.Core.Aspects.LogAspects
{
    [Serializable]
   
    public class ExceptionLogAspect :OnMethodBoundaryAspect
    {
       
       
            private Type _loggerType;
            private LoggerService _loggerService;
            public ExceptionLogAspect(Type loggerType=null)
        {
            _loggerType = loggerType;   

        }
        public override void OnException(MethodExecutionArgs args)
        {
            if (_loggerService!=null) {
                _loggerService.Error(args.Exception);
            }
        }
        public override void RuntimeInitialize(MethodBase method)
        {
            if (_loggerType.BaseType != typeof(LoggerService))
            {
                throw new Exception("Wrong exception");
            }
            _loggerService = (LoggerService)Activator.CreateInstance(_loggerType);
            base.RuntimeInitialize(method);
        }
    }
}
