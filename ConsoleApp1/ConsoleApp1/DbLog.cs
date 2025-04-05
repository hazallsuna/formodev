using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DbLog: ILog
    {

        public bool Log(string message)
        {
            Console.WriteLine(message + " database kaydedildi");
            return true;
        }
    }
}
