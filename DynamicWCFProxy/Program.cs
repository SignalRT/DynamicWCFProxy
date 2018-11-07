using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRT.DynamicWCFProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            WebServiceInvoker ws = new WebServiceInvoker( new Uri(@"http://www.dneonline.com/calculator.asmx"));

            // List available services
            //
            Console.WriteLine("Show available services.....");
            foreach (var service in ws.AvailableServices)
            {
                Console.WriteLine(String.Format( "The service {0} contains the methods: ", service) );

                foreach( var method in ws.EnumerateServiceMethods( service ))
                {
                    Console.WriteLine(method);
                }
            }

            // Try to invoke some methods
            //
            Console.WriteLine("Add 2 + 3");
            Int32 result = ws.InvokeMethod<Int32>("CalculatorSoapClient", "Add", new object[2] { 2, 3 });
            Console.WriteLine("Result: {0}", result);

            // 
            Console.ReadKey();
        }
    }
}
