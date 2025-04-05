using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /* public class LogManager
     {
         public XmlLog xmlLog;
         public DbLog dbLog;
         public JsonLog jsonLog;

         //parametre alan constructor

         public LogManager(XmlLog xmlLog, DbLog dbLog, JsonLog jsonLog)
         {
             this.xmlLog = xmlLog;
             this.dbLog = dbLog;
             this.jsonLog = jsonLog;
         }
         public void LogKaydet(LogType type, string message)
         {
             switch (type)
             {
                 case LogType.xml:
                     xmlLog.xmlKayit(message); break;
                 case LogType.db:
                     dbLog.dbKayit(message); break;
                 case LogType.json:
                     jsonLog.jsonKaydet(message); break;
                 default: break;
             }
         }
 }*/
    public class LogManager
    {
        private readonly Dictionary<LogType, ILog> _loggers;

        public LogManager(Dictionary<LogType, ILog> loggers)
        {
            _loggers = loggers;
        }

        public void LogKaydet(LogType type, string message)
        {
            if (_loggers.ContainsKey(type))
            {
                _loggers[type].Log(message);
            }
            else
            {
                Console.WriteLine("Log tipi bulunamadı.");
            }
        }
    }

}
