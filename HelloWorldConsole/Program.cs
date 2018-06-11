using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldAPI;

namespace HelloWorldConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var writeLocation = ConfigurationManager.AppSettings["WriteToDB"];

            var thisConsole = new HelloWorldAPI.Console();
            thisConsole.WriteDbConfig = writeLocation;
            thisConsole.PrintGreeting = "Hello World";

            System.Console.WriteLine(thisConsole.PrintGreeting);
          //  System.Console.Write(thisConsole.WriteDbConfig);

            System.Console.ReadKey();
        }
    }
}
