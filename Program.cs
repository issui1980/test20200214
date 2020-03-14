using System;
using System.Text;
using System.Threading;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder execInfo = new StringBuilder();
            execInfo.AppendLine(Environment.UserDomainName);
            //execInfo.AppendLine(Thread.CurrentPrincipal.Identity.Name);
            execInfo.AppendLine(System.Environment.UserName);
            execInfo.AppendLine(AppDomain.CurrentDomain.BaseDirectory);

            Console.WriteLine("Hello World!");
            Console.WriteLine(execInfo.ToString());
        }
    }
}
