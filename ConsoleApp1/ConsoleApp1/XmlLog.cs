using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class XmlLog : ILog
    {

        public bool Log(string message)
        {
            Console.WriteLine(message + " xml e kaydedildi");
            return true;
        }
    }
}
