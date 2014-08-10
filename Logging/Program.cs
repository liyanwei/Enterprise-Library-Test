using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Fluent;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.Logging.TraceListeners;

namespace Logging
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //LogEntry logEntry = new LogEntry();

            //logEntry.EventId = 1;
            //logEntry.Priority = 1;
            //logEntry.Title = "标题党";
            //logEntry.Message = "http://www.cnblogs.com/huangcong/";
            //logEntry.Categories.Add("C#学习");
            //logEntry.Categories.Add("Microsoft Enterprise Library学习");

            //Logger.Writer.Write(logEntry);
            //Console.WriteLine("日志写入完成!");

            //LoggingConfiguration 
            //LogWriter defaultWriter = EnterpriseLibraryContainer.Current.GetInstance<LogWriter>();
            //defaultWriter.Write("nihao", "General");
            LogWriterFactory logWriterFactory = new LogWriterFactory();
            LogWriter logWriter = logWriterFactory.Create();
            logWriter.Write("nihao", "Category");
            
            Console.WriteLine("日志写入完成!");
        }
    }
}
