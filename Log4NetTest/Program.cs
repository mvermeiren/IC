using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4NetTest
{
    class Program
    {

        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            //BasicConfigurator.Configure();
            XmlConfigurator.Configure();


            log.Info("pre-start2");

            Console.WriteLine("Log4Net Test!");

            log.Error("error test2");
            log.Debug("error evaded, debug succes2");
            Console.ReadLine();

        }
    }
}
