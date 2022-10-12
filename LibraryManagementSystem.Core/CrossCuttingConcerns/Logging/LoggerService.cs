using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Core.CrossCuttingConcerns.Logging
{
    [Serializable]
    public class LoggerService
    {
        private ILog _ILog;
        public LoggerService(ILog ıLog)
        {
            _ILog = ıLog;   
        }
        public bool IsInfoEnabled=> _ILog.IsInfoEnabled;
        public bool IsWarnEnabled=>_ILog.IsWarnEnabled; 
        public bool IsErrorEnabled=>_ILog.IsErrorEnabled;   
        public bool IsFatalEnabled=>_ILog.IsFatalEnabled;   

        public bool IsDebugEnabled=>_ILog.IsDebugEnabled;
        public void Info(object getMessage) {
            if (IsInfoEnabled) {
                _ILog.Info(getMessage);
            }
        }
        public void Warn(object getMessage)
        {
            if (IsWarnEnabled)
            {
                _ILog.Warn(getMessage);
            }
        }
        public void Debug(object getMessage)
        {
            if (IsDebugEnabled)
            {
                _ILog.Debug(getMessage);
            }
        }
        public void Error(object getMessage)
        {
            if (IsErrorEnabled)
            {
                _ILog.Error(getMessage);
            }
        }
        public void Fatal(object getMessage)
        {
            if (IsFatalEnabled)
            {
                _ILog.Fatal(getMessage);
            }
        }
    }
}
