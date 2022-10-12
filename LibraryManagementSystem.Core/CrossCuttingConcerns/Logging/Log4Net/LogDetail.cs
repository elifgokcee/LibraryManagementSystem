﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Core.CrossCuttingConcerns.Logging.Log4Net
{
    public class LogDetail
    {
        public string FullName { get; set; }    
        public string MethodName { get; set; }
        public List<LogParameter> Parameters { get; set; }  
    }
}
