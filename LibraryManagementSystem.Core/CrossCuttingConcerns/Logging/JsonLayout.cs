using log4net.Core;
using log4net.Layout;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Core.CrossCuttingConcerns.Logging
{
    public class JsonLayout : LayoutSkeleton
    {
        public override void ActivateOptions()
        {
        
        }

        public override void Format(TextWriter writer, LoggingEvent loggingEvent)
        {
            var LogEvent = new SerializableLogEvent(loggingEvent);
            var json=JsonConvert.SerializeObject(LogEvent,Formatting.Indented);
            writer.WriteLine(json); 
        }
    }
}
